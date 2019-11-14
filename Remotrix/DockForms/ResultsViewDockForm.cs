using System;
using System.IO;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Remotrix.DockForms
{
    public partial class ResultsViewDockForm : DockContent
    {


    void SetDoubleBuffered(Control c, bool value)
        {
            PropertyInfo pi = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic);
            pi?.SetValue(c, value, null);
        }

        public ResultsViewDockForm()
        {
            InitializeComponent();
            SetDoubleBuffered(Results, true);

        }

        public object DataSource
        {
            get => Results.DataSource;
            internal set
            {
                Results.DataSource = value;
                Results.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                Results.AutoResizeColumns();
                RowCount.Text = $"Обработано {Results.Rows.Count} строк";
            }
        }

        public async void SetStatus(string status)
        {
            statusStrip.BeginInvoke(
                (MethodInvoker) delegate { this.Status.Text = status; });
        }

        public async void SetTime(float time)
        {
            statusStrip.BeginInvoke(
                (MethodInvoker) delegate { this.Time.Text = $"Длительность запроса: {time} c"; });
        }

        public async void SetProgress(float progress)
        {
            statusStrip.BeginInvoke((MethodInvoker) delegate
            {
                this.toolStripProgressBar1.Value = (int) (progress * 100); 

            });
        }
    }
}
