//using FastColoredTextBoxNS;
using ScintillaNET;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Remotrix.DockForms
{
    public partial class QueryDockForm
    {

        public QueryDockForm()
        {
            InitializeComponent();

            // BASIC CONFIG
            TextArea.Dock = System.Windows.Forms.DockStyle.Fill;
            TextArea.TextChanged += this.OnTextChanged;

            // INITIAL VIEW CONFIG
            TextArea.WrapMode = WrapMode.None;
            TextArea.IndentationGuides = IndentView.LookBoth;

            InitSyntaxColoring();
            InitColors();
            InitNumberMargin();

        }

        private void OnTextChanged(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// the background color of the text area
        /// </summary>
        private const int BACK_COLOR = 0x2A211C;

        /// <summary>
        /// default text color of the text area
        /// </summary>
        private const int FORE_COLOR = 0xB7B7B7;

        /// <summary>
        /// change this to whatever margin you want the line numbers to show in
        /// </summary>
        private const int NUMBER_MARGIN = 1;

        /// <summary>
        /// change this to whatever margin you want the bookmarks/breakpoints to show in
        /// </summary>
        private const int BOOKMARK_MARGIN = 2;
        private const int BOOKMARK_MARKER = 2;

        /// <summary>
        /// change this to whatever margin you want the code folding tree (+/-) to show in
        /// </summary>
        private const int FOLDING_MARGIN = 3;

        /// <summary>
        /// set this true to show circular buttons for code folding (the [+] and [-] buttons on the margin)
        /// </summary>
        private const bool CODEFOLDING_CIRCULAR = true;

        private void InitNumberMargin()
        {

            TextArea.Styles[Style.LineNumber].BackColor = IntToColor(BACK_COLOR);
            TextArea.Styles[Style.LineNumber].ForeColor = IntToColor(FORE_COLOR);
            TextArea.Styles[Style.IndentGuide].ForeColor = IntToColor(FORE_COLOR);
            TextArea.Styles[Style.IndentGuide].BackColor = IntToColor(BACK_COLOR);

            var nums = TextArea.Margins[NUMBER_MARGIN];
            nums.Width = 30;
            nums.Type = MarginType.Number;
            nums.Sensitive = true;
            nums.Mask = 0;

            TextArea.MarginClick += TextArea_MarginClick;
        }

        private void TextArea_MarginClick(object sender, MarginClickEventArgs e)
        {

        }

        public static Color IntToColor(int rgb)
        {
            return Color.FromArgb(255, (byte)(rgb >> 16), (byte)(rgb >> 8), (byte)rgb);
        }

        private void InitColors()
        {

            TextArea.SetSelectionBackColor(true, IntToColor(0x114D9C));

        }

        private void InitSyntaxColoring()
        {

            // Configure the default style
            TextArea.StyleResetDefault();
            TextArea.Styles[Style.Default].Font = "Consolas";
            TextArea.Styles[Style.Default].Size = 12;
            TextArea.Styles[Style.Default].Bold = true;
            TextArea.Styles[Style.Default].BackColor = IntToColor(0xFFFFFF);
            TextArea.Styles[Style.Default].ForeColor = IntToColor(0x212121);
            TextArea.StyleClearAll();

            // TextArea.Margins[0].Width = 20;

            // Configure the CPP (C#) lexer styles
            // Set the Styles
            TextArea.Styles[Style.LineNumber].ForeColor = Color.FromArgb(255, 128, 128, 128);  //Dark Gray
            TextArea.Styles[Style.LineNumber].BackColor = Color.FromArgb(255, 228, 228, 228);  //Light Gray
            TextArea.Styles[Style.Sql.Comment].ForeColor = Color.Green;
            TextArea.Styles[Style.Sql.CommentLine].ForeColor = Color.Green;
            TextArea.Styles[Style.Sql.CommentLineDoc].ForeColor = Color.Green;
            TextArea.Styles[Style.Sql.Number].ForeColor = Color.Maroon;
            TextArea.Styles[Style.Sql.Word].ForeColor = Color.Blue;
            TextArea.Styles[Style.Sql.Word2].ForeColor = Color.Fuchsia;
            TextArea.Styles[Style.Sql.User1].ForeColor = Color.Gray;
            TextArea.Styles[Style.Sql.User2].ForeColor = Color.FromArgb(255, 00, 128, 192);    //Medium Blue-Green
            TextArea.Styles[Style.Sql.User3].ForeColor = Color.FromArgb(255, 128, 128, 192);    //Medium Blue-Green
            TextArea.Styles[Style.Sql.String].ForeColor = Color.Red;
            TextArea.Styles[Style.Sql.Character].ForeColor = Color.Red;
            TextArea.Styles[Style.Sql.Operator].ForeColor = Color.Blue;

            // Set keyword lists
            // Word = 0
            TextArea.SetKeywords(0, @"add alter as authorization backup begin bigint binary bit break browse bulk by cascade case catch check checkpoint close clustered column commit compute constraint containstable continue create current cursor cursor database date datetime datetime2 datetimeoffset dbcc deallocate decimal declare default delete deny desc disk distinct distributed double drop dump else end errlvl escape except exec execute exit external fetch file fillfactor float for foreign freetext freetexttable from full function goto grant group having hierarchyid holdlock identity identity_insert identitycol if image index insert int intersect into key kill limit lineno load merge money national nchar nocheck nocount nolock nonclustered ntext numeric nvarchar of off offsets on open opendatasource openquery openrowset openxml option order over percent plan precision primary print proc procedure public raiserror read readtext real reconfigure references replication restore restrict return revert revoke rollback rowcount rowguidcol rule save schema securityaudit select set setuser shutdown smalldatetime smallint smallmoney sql_variant statistics table table tablesample text textsize then time timestamp tinyint to top tran transaction trigger truncate try union unique uniqueidentifier update updatetext use user values varbinary varchar varying view waitfor when where while with writetext xml go ");
            // Word2 = 1
            TextArea.SetKeywords(1, @"ascii cast char charindex ceiling coalesce collate contains convert current_date current_time current_timestamp current_user floor isnull max min nullif object_id session_user substring system_user tsequal ");
            // User1 = 4
            TextArea.SetKeywords(4, @"all and any between cross exists in inner is join left like not null or outer pivot right some unpivot ( ) * ");
            // User2 = 5
            SetUserKeyword(@"sys objects sysobjects ");
        }

        public string Query
        {
            get => TextArea.Text;
            internal set => TextArea.Text = value;
        }

        internal List<string> userKeywords = new List<string>();
        internal List<string> userKeywords2 = new List<string>();
        public void SetUserKeyword(string text)
        {
            userKeywords.AddRange(text.Split(' '));
            TextArea.SetKeywords(5, string.Join(" ", userKeywords) + " ");
        }

        public void SetUserKeyword2(string text)
        {
            userKeywords2.AddRange(text.Split(' '));
            TextArea.SetKeywords(6, string.Join(" ", userKeywords2) + " ");
        }
    }
}
