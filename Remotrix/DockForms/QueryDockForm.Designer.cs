using WeifenLuo.WinFormsUI.Docking;
namespace Remotrix.DockForms
{
    partial class QueryDockForm: DockContent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextArea = new ScintillaNET.Scintilla();
            this.SuspendLayout();
            // 
            // TextArea
            // 
            this.TextArea.Lexer = ScintillaNET.Lexer.Sql;
            this.TextArea.Location = new System.Drawing.Point(2, 0);
            this.TextArea.Name = "TextArea";
            this.TextArea.Size = new System.Drawing.Size(797, 450);
            this.TextArea.TabIndex = 8;
            this.TextArea.Text = "";
            // 
            // QueryDockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextArea);
            this.Name = "QueryDockForm";
            this.Text = "Текст запроса";
            this.ResumeLayout(false);

        }

        #endregion
        private ScintillaNET.Scintilla TextArea;
    }
}