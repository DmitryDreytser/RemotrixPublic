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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.Results = new System.Windows.Forms.DataGridView();
            this.QueryBox = new System.Windows.Forms.RichTextBox();
            this.baseAddress = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.StartQuery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Results)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 73);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(255, 747);
            this.treeView1.TabIndex = 0;
            // 
            // Results
            // 
            this.Results.AllowUserToAddRows = false;
            this.Results.AllowUserToDeleteRows = false;
            this.Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Results.Location = new System.Drawing.Point(268, 471);
            this.Results.Name = "Results";
            this.Results.ReadOnly = true;
            this.Results.Size = new System.Drawing.Size(1061, 348);
            this.Results.TabIndex = 1;
            // 
            // QueryBox
            // 
            this.QueryBox.AcceptsTab = true;
            this.QueryBox.Location = new System.Drawing.Point(269, 73);
            this.QueryBox.Name = "QueryBox";
            this.QueryBox.Size = new System.Drawing.Size(1060, 392);
            this.QueryBox.TabIndex = 2;
            this.QueryBox.Text = "";
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 832);
            this.Controls.Add(this.StartQuery);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.baseAddress);
            this.Controls.Add(this.QueryBox);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Results)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView Results;
        private System.Windows.Forms.RichTextBox QueryBox;
        private System.Windows.Forms.TextBox baseAddress;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button StartQuery;
    }
}

