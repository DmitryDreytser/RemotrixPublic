using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using FastColoredTextBoxNS;
using Remotrix.DockForms;
using WeifenLuo.WinFormsUI.Docking;

namespace Remotrix
{
    
    public partial class RemotrixConsole 
    {
        private Remotrix dB = null;
        private AutocompleteMenu acMenu = null;
        private QueryDockForm QueryBox;
        private ResultsViewDockForm Results;
        private DbStructDockForm DbStructView;

        public RemotrixConsole()
        {
            InitializeComponent();
            mainDockPanel.Theme = new VS2015BlueTheme();
            StartQuery.Enabled = false;

            QueryBox = new QueryDockForm();
            QueryBox.Show(mainDockPanel, DockState.Document);

            Results = new ResultsViewDockForm();
            Results.Show(mainDockPanel, DockState.DockBottom);
            DbStructView = new DbStructDockForm();
            DbStructView.Show(mainDockPanel, DockState.DockLeft);
            DbStructView.OnSelectMenuClick += Select_Click;
            DbStructView.OnTableExpand += DbStructView_OnTableExpand;
        }

        private async Task DbStructView_OnTableExpand(object sender, TreeViewCancelEventArgs e)
        {
            var item = e.Node;
            var str = item.Text;
            item.Text += " (обновление)";
            item.Nodes[0].Text = "";
            var Fields = await dB.ExecQuery($"DESCRIBE {item.Parent.Text}.{item.Tag}");
            e.Node.TreeView.BeginUpdate();
            item.Nodes.Clear();
            item.Nodes.AddRange(Fields.AsEnumerable().Select(f => new TreeNode($"{f[0]} [{f[1]}]") {Tag = f[0], ImageIndex = 2, SelectedImageIndex = 2})
                .ToArray());
            e.Node.TreeView.EndUpdate();
            item.Text = str;
        }

        private async void FillTables(DataTable data)
        {
            DbStructView.Nodes.Clear();
            DbStructView.Nodes.AddRange(data.AsEnumerable().Select(x => x["TABLE_SCHEMA"].ToString()).Distinct().Select(x => new TreeNode(x,
                data.AsEnumerable().Where(c => c["TABLE_SCHEMA"].ToString() == x).Select(c => new TreeNode($"{c["TABLE_NAME"]} [{c["TABLE_ROWS"]}]", new TreeNode[1]{new TreeNode("dummy")}) { Tag = c["TABLE_NAME"], ImageIndex = 1, SelectedImageIndex = 1 }
                ).OrderBy(t => t.Text).ToArray()
                )
            { Name = x, ImageIndex = 0 , SelectedImageIndex = 3}).ToArray());

            QueryBox.SetUserKeyword(string.Join(" ",DbStructView.Nodes.Cast<TreeNode>().Select(x => x.Text).ToArray()));
            QueryBox.SetUserKeyword2(string.Join(" ", data.AsEnumerable().Select(x => x["TABLE_NAME"]).ToArray()));

            //Parallel.ForEach(DbStructView.Nodes.Cast<TreeNode>(), async (TreeNode par) =>
            //{
            //    Parallel.ForEach(par.Nodes.Cast<TreeNode>(), async (TreeNode item) =>
            //    {
            //        item.TreeView.BeginInvoke((MethodInvoker)async delegate
            //       {
            //           var Fields = await dB.ExecQuery($"DESCRIBE {item.Parent.Text}.{item.Tag}");
            //           item.Nodes.AddRange(Fields.AsEnumerable().Select(f => new TreeNode($"{f[0]} [{f[1]}]") { Tag = f[0]}).ToArray());
            //       });
            //    });
            //});

            StartQuery.Enabled = true;
        }

        private async void Connect_Click(object sender, EventArgs e)
        {
            dB = new Remotrix(baseAddress.Text, Login.Text, Password.Text);
            await dB.Connect();
            var data = await dB.ExecQuery("SELECT * FROM INFORMATION_SCHEMA.TABLES");
            FillTables(data);
         }

        private async void StartQuery_Click(object sender, EventArgs e)
        {
            StartQuery.Enabled = false;
            try
            {
                Results.DataSource = await dB.ExecQuery(QueryBox.Query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                StartQuery.Enabled = true;
            }
        }

        private async void Select_Click(object sender, EventArgs e)
        {
            if(DbStructView.SelectedNode.Level == 1)
            {
                if (DbStructView.SelectedNode.Nodes[0].Text == "dummy")
                {
                   await DbStructView_OnTableExpand(sender,
                        new TreeViewCancelEventArgs(DbStructView.SelectedNode, false, TreeViewAction.Unknown));
                }
                QueryBox.Query = $"SELECT\r\n{String.Join(",\r\n", DbStructView.SelectedNode.Nodes.Cast<TreeNode>().Select(x => $"\t\t{DbStructView.SelectedNode.Tag}.{x.Tag} as {x.Tag}"))}\r\n\tFROM {DbStructView.SelectedNode.Parent.Text}.{DbStructView.SelectedNode.Tag} AS {DbStructView.SelectedNode.Tag} LIMIT 1000";
            }
        }


    }
}
