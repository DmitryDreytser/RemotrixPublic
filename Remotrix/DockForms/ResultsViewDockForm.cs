using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
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
            get => Results.DataSource ; 
            internal set => Results.DataSource = value;
        }
    }
}
