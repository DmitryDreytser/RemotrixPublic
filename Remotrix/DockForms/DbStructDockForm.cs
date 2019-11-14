using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Remotrix.DockForms
{
    public partial class DbStructDockForm : DockContent
    {

        void SetDoubleBuffered(Control c, bool value)
        {
            PropertyInfo pi = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic);
            pi?.SetValue(c, value, null);
        }


        public delegate void MenuEvent(object sender, EventArgs e);
        public delegate Task TreeViewEvent(object sender, TreeViewCancelEventArgs e);

        public event MenuEvent OnSelectMenuClick;
        public event TreeViewEvent OnTableExpand;
        public DbStructDockForm()
        {
            InitializeComponent();
            SetDoubleBuffered(structView, true);
        }

        public TreeNodeCollection Nodes => structView.Nodes;

        public TreeNode SelectedNode => structView.SelectedNode;

        private void selectMenuItem_Click(object sender, EventArgs e)
        {
            OnSelectMenuClick?.Invoke(sender, e);
        }

        private void structView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Level == 1 && e.Node.Nodes[0].Text == "dummy")
            {
                if (OnTableExpand != null)
                {
                    OnTableExpand(sender, e);
                }
            }
        }
    }
}
