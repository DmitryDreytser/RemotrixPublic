using Remotrix.DockForms;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Remotrix
{

    public partial class RemotrixConsole
    {
        private Remotrix dB = null;
        private QueryDockForm QueryBox;
        private ResultsViewDockForm Results;
        private DbStructDockForm DbStructView;

        private string Settings = "remotrixconsole.ini";

        public RemotrixConsole()
        {
            InitializeComponent();
            mainDockPanel.Theme = new VS2015BlueTheme();
            this.BackColor = mainDockPanel.Theme.ColorPalette.MainWindowActive.Background;
            panel1.BackColor = mainDockPanel.Theme.ColorPalette.DockTarget.Background;
            StartQuery.Enabled = false;
            
            QueryBox = new QueryDockForm();
            QueryBox.Show(mainDockPanel, DockState.Document);

            Results = new ResultsViewDockForm();
            Results.Show(QueryBox.Pane, DockAlignment.Bottom, 0.3);

            DbStructView = new DbStructDockForm();
            DbStructView.Show(mainDockPanel, DockState.DockLeft);
            DbStructView.OnSelectMenuClick += Select_Click;
            DbStructView.OnTableExpand += DbStructView_OnTableExpand;


            if (File.Exists(Settings))
            {
                var tmp = File.ReadAllText(Settings).Split(';');

                baseAddress.Text = Encoding.ASCII.GetString(Convert.FromBase64String(tmp[0]));
                Login.Text = Encoding.ASCII.GetString(Convert.FromBase64String(tmp[1]));
                Password.Text = Encoding.ASCII.GetString(Convert.FromBase64String(tmp[2]));
            }
        }

        private async Task DbStructView_OnTableExpand(object sender, TreeViewCancelEventArgs e)
        {
            var item = e.Node;
            var str = item.Text;
            
            item.Text += " (обновление)";
            item.Nodes[0].Text = "";
            Results.SetStatus($"Загрузка структуры таблицы {item.Tag}...");
            var Fields = await dB.ExecQuery($"DESCRIBE {item.Parent.Text}.{item.Tag}");
            Results.SetTime(dB.time);
            e.Node.TreeView.BeginUpdate();
            item.Nodes.Clear();
            item.Nodes.AddRange(Fields.AsEnumerable().Select(f => new TreeNode($"{f[0]} [{f[1]}]") { Tag = f[0], ImageIndex = 2, SelectedImageIndex = 2 })
                .ToArray());
            e.Node.TreeView.EndUpdate();
            item.Text = str;
            Results.SetStatus("");
        }

        private async void FillTables(DataTable data)
        {
            DbStructView.Nodes.Clear();
            DbStructView.Nodes.AddRange(data.AsEnumerable().Select(x => x["TABLE_SCHEMA"].ToString()).Distinct().Select(x => new TreeNode(x,
                data.AsEnumerable().Where(c => c["TABLE_SCHEMA"].ToString() == x).Select(c => new TreeNode($"{c["TABLE_NAME"]} [{c["TABLE_ROWS"]}]", new TreeNode[1] { new TreeNode("dummy") }) { Tag = c["TABLE_NAME"], ImageIndex = 1, SelectedImageIndex = 1 }
                ).OrderBy(t => t.Text).ToArray()
                )
            { Name = x, ImageIndex = 0, SelectedImageIndex = 3 }).ToArray());

            QueryBox.SetUserKeyword(string.Join(" ", DbStructView.Nodes.Cast<TreeNode>().Select(x => x.Text).ToArray()));
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
            Results.SetStatus("Подключение успешно.");
            StartQuery.Enabled = true;
        }

        private async void ConnectButton_Click(object sender, EventArgs e)
        {
            Results.SetStatus("Авторизация в адаминистративной панели Bitrix...");
            dB = new Remotrix(baseAddress.Text, Login.Text, Password.Text);
            dB.OnParseProgress += DBOnOnParseProgress;
            await dB.Connect();
            Results.SetStatus("Получение структуры базы данных...");
            var data = await dB.ExecQuery("SELECT * FROM INFORMATION_SCHEMA.TABLES");
            Results.SetTime(dB.time);
            Results.SetStatus("Заполненние структуры таблиц...");

            File.WriteAllText(Settings, $"{Convert.ToBase64String(Encoding.ASCII.GetBytes(baseAddress.Text))};" +
                                        $"{Convert.ToBase64String(Encoding.ASCII.GetBytes(Login.Text))};" +
                                        $"{Convert.ToBase64String(Encoding.ASCII.GetBytes(Password.Text))}");

            FillTables(data);
        }

        private void DBOnOnParseProgress(float progress)
        {
            Results.SetProgress(progress);
        }

        private async void StartQuery_Click(object sender, EventArgs e)
        {
            StartQuery.Enabled = false;
            try
            {
                Results.DataSource = await dB.ExecQuery(QueryBox.Query);
                Results.SetTime(dB.time);
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
            if (DbStructView.SelectedNode.Level == 1)
            {
                if (DbStructView.SelectedNode.Nodes[0].Text == "dummy")
                {
                    await DbStructView_OnTableExpand(sender,
                         new TreeViewCancelEventArgs(DbStructView.SelectedNode, false, TreeViewAction.Unknown));
                }
                QueryBox.Query = $"SELECT\r\n{String.Join(",\r\n", DbStructView.SelectedNode.Nodes.Cast<TreeNode>().Select(x => $"\t\t{DbStructView.SelectedNode.Tag}.{x.Tag} as {x.Tag}"))}\r\n\tFROM {DbStructView.SelectedNode.Parent.Text}.{DbStructView.SelectedNode.Tag} AS {DbStructView.SelectedNode.Tag} LIMIT 1000";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
