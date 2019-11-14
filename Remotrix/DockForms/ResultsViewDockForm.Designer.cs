namespace Remotrix.DockForms
{
    partial class ResultsViewDockForm
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
            this.Results = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Results)).BeginInit();
            this.SuspendLayout();
            // 
            // Results
            // 
            this.Results.AllowUserToAddRows = false;
            this.Results.AllowUserToDeleteRows = false;
            this.Results.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Results.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Results.Location = new System.Drawing.Point(0, 0);
            this.Results.Name = "Results";
            this.Results.ReadOnly = true;
            this.Results.RowTemplate.ReadOnly = true;
            this.Results.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Results.Size = new System.Drawing.Size(800, 450);
            this.Results.TabIndex = 2;
            this.Results.VirtualMode = true;
            // 
            // ResultsViewDockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Results);
            this.Name = "ResultsViewDockForm";
            this.Text = "Результаты";
            ((System.ComponentModel.ISupportInitialize)(this.Results)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Results;
    }
}