namespace Remotrix
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.Results = new System.Windows.Forms.DataGridView();
            this.baseAddress = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.StartQuery = new System.Windows.Forms.Button();
            this.QueryBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.TreeContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Select = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Results)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueryBox)).BeginInit();
            this.TreeContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.ContextMenuStrip = this.TreeContextMenu;
            this.treeView1.Location = new System.Drawing.Point(12, 73);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(252, 747);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // Results
            // 
            this.Results.AllowUserToAddRows = false;
            this.Results.AllowUserToDeleteRows = false;
            this.Results.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Results.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Results.Location = new System.Drawing.Point(268, 471);
            this.Results.Name = "Results";
            this.Results.ReadOnly = true;
            this.Results.RowTemplate.ReadOnly = true;
            this.Results.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Results.Size = new System.Drawing.Size(1061, 349);
            this.Results.TabIndex = 1;
            this.Results.VirtualMode = true;
            // 
            // baseAddress
            // 
            this.baseAddress.Location = new System.Drawing.Point(12, 12);
            this.baseAddress.Name = "baseAddress";
            this.baseAddress.Size = new System.Drawing.Size(692, 20);
            this.baseAddress.TabIndex = 3;
            this.baseAddress.Text = "https://napopravku.ru";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(714, 13);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(346, 20);
            this.Login.TabIndex = 4;
            this.Login.Text = "o.dreytser@napopravku.ru";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(714, 39);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(346, 20);
            this.Password.TabIndex = 4;
            this.Password.Text = "Napopravku.ru123";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(12, 38);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(137, 20);
            this.ConnectButton.TabIndex = 5;
            this.ConnectButton.Text = "Подключиться";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.Connect_Click);
            // 
            // StartQuery
            // 
            this.StartQuery.Location = new System.Drawing.Point(155, 38);
            this.StartQuery.Name = "StartQuery";
            this.StartQuery.Size = new System.Drawing.Size(137, 20);
            this.StartQuery.TabIndex = 5;
            this.StartQuery.Text = "Выполнить";
            this.StartQuery.UseVisualStyleBackColor = true;
            this.StartQuery.Click += new System.EventHandler(this.StartQuery_Click);
            // 
            // QueryBox
            // 
            this.QueryBox.AllowSeveralTextStyleDrawing = true;
            this.QueryBox.AutoCompleteBrackets = true;
            this.QueryBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.QueryBox.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*" +
    "(?<range>:)\\s*(?<range>[^;]+);";
            this.QueryBox.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.QueryBox.BackBrush = null;
            this.QueryBox.BackColor = System.Drawing.SystemColors.Window;
            this.QueryBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.QueryBox.ChangedLineColor = System.Drawing.Color.Gainsboro;
            this.QueryBox.CharHeight = 14;
            this.QueryBox.CharWidth = 8;
            this.QueryBox.CommentPrefix = "--";
            this.QueryBox.CurrentPenSize = 3;
            this.QueryBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QueryBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.QueryBox.DocumentPath = null;
            this.QueryBox.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.QueryBox.IsReplaceMode = false;
            this.QueryBox.Language = FastColoredTextBoxNS.Language.SQL;
            this.QueryBox.Location = new System.Drawing.Point(270, 75);
            this.QueryBox.Name = "QueryBox";
            this.QueryBox.Paddings = new System.Windows.Forms.Padding(0);
            this.QueryBox.SelectionChangedDelayedEnabled = false;
            this.QueryBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.QueryBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("QueryBox.ServiceColors")));
            this.QueryBox.ShowFoldingLines = true;
            this.QueryBox.Size = new System.Drawing.Size(1059, 390);
            this.QueryBox.TabIndex = 6;
            this.QueryBox.VirtualSpace = true;
            this.QueryBox.WideCaret = true;
            this.QueryBox.Zoom = 100;
            // 
            // TreeContextMenu
            // 
            this.TreeContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Select});
            this.TreeContextMenu.Name = "TreeContextMenu";
            this.TreeContextMenu.Size = new System.Drawing.Size(180, 26);
            // 
            // Select
            // 
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(179, 22);
            this.Select.Text = "Select TOP 200 rows";
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 832);
            this.Controls.Add(this.QueryBox);
            this.Controls.Add(this.StartQuery);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.baseAddress);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.Results)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueryBox)).EndInit();
            this.TreeContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView Results;
        private System.Windows.Forms.TextBox baseAddress;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button StartQuery;
        private FastColoredTextBoxNS.FastColoredTextBox QueryBox;
        private System.Windows.Forms.ContextMenuStrip TreeContextMenu;
        private System.Windows.Forms.ToolStripMenuItem Select;
    }
}

