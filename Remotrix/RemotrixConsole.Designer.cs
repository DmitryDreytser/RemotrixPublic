using WeifenLuo.WinFormsUI.Docking;

namespace Remotrix
{
    partial class RemotrixConsole : DockContent
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
            this.mainDockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StartQuery = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.baseAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainDockPanel
            // 
            this.mainDockPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainDockPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainDockPanel.DocumentStyle = WeifenLuo.WinFormsUI.Docking.DocumentStyle.DockingSdi;
            this.mainDockPanel.Location = new System.Drawing.Point(-1, 72);
            this.mainDockPanel.Name = "mainDockPanel";
            this.mainDockPanel.Size = new System.Drawing.Size(1066, 442);
            this.mainDockPanel.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.StartQuery);
            this.panel1.Controls.Add(this.ConnectButton);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.Login);
            this.panel1.Controls.Add(this.baseAddress);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 67);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // StartQuery
            // 
            this.StartQuery.Location = new System.Drawing.Point(505, 40);
            this.StartQuery.Name = "StartQuery";
            this.StartQuery.Size = new System.Drawing.Size(137, 20);
            this.StartQuery.TabIndex = 9;
            this.StartQuery.Text = "Выполнить";
            this.StartQuery.UseVisualStyleBackColor = true;
            this.StartQuery.Click += new System.EventHandler(this.StartQuery_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(362, 40);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(137, 20);
            this.ConnectButton.TabIndex = 10;
            this.ConnectButton.Text = "Подключиться";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(754, 41);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(299, 20);
            this.Password.TabIndex = 7;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(754, 15);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(299, 20);
            this.Login.TabIndex = 8;
            // 
            // baseAddress
            // 
            this.baseAddress.Location = new System.Drawing.Point(53, 14);
            this.baseAddress.Name = "baseAddress";
            this.baseAddress.Size = new System.Drawing.Size(589, 20);
            this.baseAddress.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Адрес:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(697, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Логин:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(697, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Пароль:";
            // 
            // RemotrixConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1065, 514);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainDockPanel);
            this.Name = "RemotrixConsole";
            this.Text = "RemotrixConsole";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DockPanel mainDockPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button StartQuery;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox baseAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

