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
using AngleSharp.Html.Dom;

namespace Remotrix
{
    public partial class Form1 : Form
    {
        HttpClient connection = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            connection.BaseAddress = new Uri(this.baseAddress.Text);
            var result = await connection.GetAsync("/bitrix/admin/");
            var resp = await result.Content.ReadAsStringAsync();
            string SessionID;

            using (var context = (BrowsingContext)BrowsingContext.New(Configuration.Default))
            {
                using (var document = await context.OpenAsync(req => req.Content(resp)))
                {
                    document.Domain = this.baseAddress.Text;
                    SessionID = ((IHtmlInputElement)document.QuerySelector("input#sessid")).Value;
                }
            }

            var auth = new Dictionary<string, string>
            {
                {"AUTH_FORM", "Y"},
                {"Login", "yes"},
                {"TYPE", "AUTH"},
                {"USER_LOGIN", Login.Text},
                {"USER_PASSWORD", Password.Text},
                {"captcha_sid", ""},
                {"captcha_word", ""},
                {"sessid", SessionID},
            };

            result = await connection.PostAsync("/bitrix/admin/?login=yes", new FormUrlEncodedContent(auth));
            resp = await result.Content.ReadAsStringAsync();
            
                
            result = await connection.PostAsync("/bitrix/admin/sql.php?PAGEN_1=1&SHOWALL_1=1&lang=ru&mode=frame&table_id=tbl_sql", 
                new FormUrlEncodedContent(new Dictionary<string, string> 
                {
                    {"query", "SELECT * FROM INFORMATION_SCHEMA.TABLES"},
                    {"sessid", SessionID}
                } ));

            resp = await result.Content.ReadAsStringAsync();

            using (var context = (BrowsingContext)BrowsingContext.New(Configuration.Default))
            {
                using (var document = await context.OpenAsync(req => req.Content(resp)))
                {
                    document.Domain = this.baseAddress.Text;
                    var t = ((IHtmlTableElement)document.QuerySelector("table#tbl_sql"));

                    Results.DataSource = t.Rows.ToList();
                }
            }

            QueryBox.Text = resp;



        }
    }
}
