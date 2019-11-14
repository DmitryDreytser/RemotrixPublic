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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.Time = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.RowCount = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Results)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Results
            // 
            this.Results.AllowUserToAddRows = false;
            this.Results.AllowUserToDeleteRows = false;
            this.Results.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Results.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Results.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Results.Location = new System.Drawing.Point(0, 0);
            this.Results.Name = "Results";
            this.Results.ReadOnly = true;
            this.Results.RowTemplate.ReadOnly = true;
            this.Results.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Results.Size = new System.Drawing.Size(800, 436);
            this.Results.StandardTab = true;
            this.Results.TabIndex = 2;
            this.Results.VirtualMode = true;
            // 
            // statusStrip
            // 
            this.statusStrip.AllowItemReorder = true;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status,
            this.RowCount,
            this.Time,
            this.toolStripProgressBar1});
            this.statusStrip.Location = new System.Drawing.Point(0, 437);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 24);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip";
            // 
            // Status
            // 
            this.Status.AutoSize = false;
            this.Status.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.Status.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.Status.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(150, 19);
            this.Status.Spring = true;
            this.Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Time
            // 
            this.Time.AutoSize = false;
            this.Time.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.Time.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.Time.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(150, 19);
            this.Time.Spring = true;
            this.Time.Text = "Время выполнения";
            this.Time.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.AutoSize = false;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(300, 18);
            this.toolStripProgressBar1.Step = 1;
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // RowCount
            // 
            this.RowCount.AutoSize = false;
            this.RowCount.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.RowCount.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.RowCount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RowCount.Name = "RowCount";
            this.RowCount.Size = new System.Drawing.Size(150, 19);
            this.RowCount.Spring = true;
            this.RowCount.Text = "Обработано 0 строк";
            // 
            // ResultsViewDockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.Results);
            this.Name = "ResultsViewDockForm";
            this.Text = "Результаты";
            ((System.ComponentModel.ISupportInitialize)(this.Results)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Results;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel Status;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel Time;
        private System.Windows.Forms.ToolStripStatusLabel RowCount;
    }
}