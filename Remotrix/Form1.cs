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

namespace Remotrix
{
    
    public partial class Form1 : Form
    {
        Remotrix dB = null;
        AutocompleteMenu acMenu = null;
        AutoCompleteStringCollection AutoCompleteStrings = new AutoCompleteStringCollection();

        public Form1()
        {
            InitializeComponent();
            StartQuery.Enabled = false;
            acMenu = new AutocompleteMenu(QueryBox);
                    //acLV = new AutocompleteListView(); 
            acMenu.Show();
        }

        private async void FillTables(DataTable data)
        {

            treeView1.Nodes.AddRange(data.AsEnumerable().Select(x => x["TABLE_SCHEMA"].ToString()).Distinct().Select(x => new TreeNode(x,
                data.AsEnumerable().Where(c => c["TABLE_SCHEMA"].ToString() == x).Select(c => new TreeNode($"{c["TABLE_NAME"]} [{c["TABLE_ROWS"]}]") { Tag = c["TABLE_NAME"] }
                ).OrderBy(t => t.Text).ToArray()
                )
            { Name = x }).ToArray());

            acMenu.Items.SetAutocompleteItems(data.AsEnumerable().Select(x => x["TABLE_SCHEMA"].ToString()).Distinct().ToArray());


            Parallel.ForEach(treeView1.Nodes.Cast<TreeNode>(), async (TreeNode par) =>
            {
                Parallel.ForEach(par.Nodes.Cast<TreeNode>(), async (TreeNode item) =>
                {
                    item.TreeView.BeginInvoke((MethodInvoker)async delegate
                   {
                       var Fields = await dB.ExecQuery($"DESCRIBE {item.Parent.Text}.{item.Tag}");
                       item.Nodes.AddRange(Fields.AsEnumerable().Select(f => new TreeNode($"{f[0]} [{f[1]}]") { Tag = f[0]}).ToArray());
                       acMenu.Items.SetAutocompleteItems(Fields.AsEnumerable().Select(f => $"{f[0]}").ToArray());
                       acMenu.Items.SetAutocompleteItems(new List<string> { item.Parent.Text, item.Tag.ToString() });
                       //acLV.SetAutocompleteItems({ item.Parent.Text});
                       //acLV.SetAutocompleteItems();
                   });
                });
            });

            StartQuery.Enabled = true;
        }

        private async void Connect_Click(object sender, EventArgs e)
        {
            dB = new Remotrix(baseAddress.Text, Login.Text, Password.Text);
            await dB.Connect();

            var data = await dB.ExecQuery("SELECT * FROM INFORMATION_SCHEMA.TABLES");
            QueryBox.Text = dB.LastQuery;
            Results.DataSource = data;
            FillTables(data);
            
         }

        private async void StartQuery_Click(object sender, EventArgs e)
        {
            StartQuery.Enabled = false;
            try
            {
                Results.DataSource = await dB.ExecQuery(QueryBox.Text);
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

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Results.Width = this.Width - treeView1.Width - 40;
            QueryBox.Width = this.Width - treeView1.Width - 40;
            Results.Height = this.Height - QueryBox.Height - 140;
            treeView1.Height = Results.Bottom - QueryBox.Top;
        }

        private async void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var item = e.Node;
            if (item.Level == 1 && item.Nodes.Count == 0)
            {
               e.Node.Nodes.AddRange( (await dB.ExecQuery($"DESCRIBE {item.Parent.Text}.{item.Text}")).AsEnumerable().Select(f => new TreeNode(f[0].ToString())).ToArray());
            }
        
        }

        private void Select_Click(object sender, EventArgs e)
        {
            if(treeView1.SelectedNode.Level == 1)
            {
                QueryBox.Text = $"SELECT\r\n{String.Join(",\r\n", treeView1.SelectedNode.Nodes.Cast<TreeNode>().Select(x => $"\t{treeView1.SelectedNode.Tag}.{x.Tag} as {x.Tag}"))}\r\nFROM {treeView1.SelectedNode.Parent.Text}.{treeView1.SelectedNode.Tag} AS {treeView1.SelectedNode.Tag} LIMIT 200";
            }
        }
    }
}
