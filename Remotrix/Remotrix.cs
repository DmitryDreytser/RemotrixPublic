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

namespace Remotrix
{
    public class Remotrix
    {
        public List<DataTable> Schema = new List<DataTable>();

        public string LastQuery = null;
        public float time = 0;

        string domain;
        string login;
        string password;


        private HttpClient connection = null;
        private string SessionID = null;

        bool connected = false;

        public Remotrix(string domain, string login, string password, HttpClientHandler proxy = null)
        {
            this.domain = domain;
            this.login = login;
            this.password = password;
            if(null != proxy)
                connection = new HttpClient(proxy);
            else
                connection = new HttpClient();
        }

        public void Close()
        {
            connection?.Dispose();
            connection = null;
            connected = false;
        }

        public async Task<bool> Connect()
        {
            connection.BaseAddress = new Uri(this.domain);
            var result = await connection.GetAsync("/bitrix/admin/");
            var resp = await result.Content.ReadAsStringAsync();

            using (var context = (BrowsingContext)BrowsingContext.New(Configuration.Default))
            {
                using (var document = await context.OpenAsync(req => req.Content(resp)))
                {
                    document.Domain = this.domain;
                    SessionID = ((IHtmlInputElement)document.QuerySelector("input#sessid")).Value;
                }
            }

            var auth = new Dictionary<string, string>
            {
                {"AUTH_FORM", "Y"},
                {"Login", "yes"},
                {"TYPE", "AUTH"},
                {"USER_LOGIN", login},
                {"USER_PASSWORD", password},
                {"captcha_sid", ""},
                {"captcha_word", ""},
                {"sessid", SessionID},
            };

            result = await connection.PostAsync("/bitrix/admin/?login=yes", new FormUrlEncodedContent(auth));
            resp = await result.Content.ReadAsStringAsync();

            result = await connection.GetAsync("/bitrix/admin/");
            resp = await result.Content.ReadAsStringAsync();

            connected = true;
            return connected;
        }

        public DataTable ExecQuerySync(string Query)
        {
            try
            {
                return ExecQuery(Query).Result;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return new DataTable();
        }

        public async Task<DataTable> ExecQuery(string Query)
        {
            var result = await connection.PostAsync("/bitrix/admin/sql.php?PAGEN_1=1&SHOWALL_1=1&lang=ru&mode=frame&table_id=tbl_sql",
                new FormUrlEncodedContent(new Dictionary<string, string>
                {
                    {"query", Query},
                    {"sessid", SessionID}
                })).ConfigureAwait(false);
            var resp = await result.Content.ReadAsStringAsync().ConfigureAwait(false);

            if (result.StatusCode != System.Net.HttpStatusCode.OK)
                throw new Exception(resp);

            bool success = false;
            time = 0;

            DataTable data = new DataTable();
            using (var context = (BrowsingContext)BrowsingContext.New(Configuration.Default))
            {
                using (var document = await context.OpenAsync(req => req.Content(resp)).ConfigureAwait(false))
                {
                    success = document.QuerySelector("div.adm-info-message-green") != null;

                    if(!success)
                        throw new Exception("Ошибка выполнения запроса.");

                    document.Domain = this.domain;
                    var header = ((IHtmlTableElement)document.QuerySelector("table#tbl_sql")).Head;
                    foreach (var cell in header.Rows[0].Cells)
                    {
                        data.Columns.Add(new DataColumn(cell.TextContent.TrimStart(new char[]{'\t','\n'}).TrimEnd(new char[] { '\t', '\n' }), Type.GetType("System.String")));
                    }

                    var rows = ((IHtmlTableElement)document.QuerySelector("table#tbl_sql")).Bodies[0].Rows;
                    foreach (var row in rows)
                    {
                        var datarow = data.NewRow();
                        int i = 0;
                        foreach (var cell in row.Cells)
                        {
                            datarow[i++] = cell.Text();
                        }
                        data.Rows.Add(datarow);
                    }

                    time = float.Parse(document.QuerySelector("div.adm-info-message").QuerySelector("b").InnerHtml.Replace(".", ","));
                }
            }

            LastQuery = Query;
            return data;
        }

        public async Task<List<object>> GetSchema()
        {
            var Tables = await ExecQuery("SELECT * FROM INFORMATION_SCHEMA.TABLES");

            foreach(DataRow tbl in Tables.Rows)
            {
                var tt = tbl["TABLE_NAME"];
            }

            return new List<object>();
        }
    }
}
