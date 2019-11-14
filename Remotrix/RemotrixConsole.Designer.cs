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
            this.baseAddress = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.StartQuery = new System.Windows.Forms.Button();
            this.mainDockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.SuspendLayout();
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
            // mainDockPanel
            // 
            this.mainDockPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainDockPanel.DocumentStyle = WeifenLuo.WinFormsUI.Docking.DocumentStyle.DockingSdi;
            this.mainDockPanel.Location = new System.Drawing.Point(1, 65);
            this.mainDockPanel.Name = "mainDockPanel";
            this.mainDockPanel.Size = new System.Drawing.Size(1059, 448);
            this.mainDockPanel.TabIndex = 7;
            // 
            // RemotrixConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 514);
            this.Controls.Add(this.mainDockPanel);
            this.Controls.Add(this.StartQuery);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.baseAddress);
            this.Name = "RemotrixConsole";
            this.Text = "RemotrixConsole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox baseAddress;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button StartQuery;
        private DockPanel mainDockPanel;
    }
}

