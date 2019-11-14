namespace Remotrix.DockForms
{
    partial class DbStructDockForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DbStructDockForm));
            this.structView = new System.Windows.Forms.TreeView();
            this.TreeContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DbIcons = new System.Windows.Forms.ImageList(this.components);
            this.TreeContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // structView
            // 
            this.structView.ContextMenuStrip = this.TreeContextMenu;
            this.structView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.structView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.structView.FullRowSelect = true;
            this.structView.HideSelection = false;
            this.structView.ImageIndex = 0;
            this.structView.ImageList = this.DbIcons;
            this.structView.Location = new System.Drawing.Point(0, 0);
            this.structView.Name = "structView";
            this.structView.SelectedImageKey = "vdt80pui_1055.ico";
            this.structView.Size = new System.Drawing.Size(254, 832);
            this.structView.TabIndex = 1;
            this.structView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.structView_BeforeExpand);
            // 
            // TreeContextMenu
            // 
            this.TreeContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectMenuItem});
            this.TreeContextMenu.Name = "TreeContextMenu";
            this.TreeContextMenu.Size = new System.Drawing.Size(182, 48);
            // 
            // selectMenuItem
            // 
            this.selectMenuItem.Name = "selectMenuItem";
            this.selectMenuItem.Size = new System.Drawing.Size(181, 22);
            this.selectMenuItem.Text = "Select top 1000 rows";
            this.selectMenuItem.Click += new System.EventHandler(this.selectMenuItem_Click);
            // 
            // DbIcons
            // 
            this.DbIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("DbIcons.ImageStream")));
            this.DbIcons.TransparentColor = System.Drawing.Color.Black;
            this.DbIcons.Images.SetKeyName(0, "vdt80pui_1055.ico");
            this.DbIcons.Images.SetKeyName(1, "vdt80ui_2405.ico");
            this.DbIcons.Images.SetKeyName(2, "Column_16x_32.bmp");
            this.DbIcons.Images.SetKeyName(3, "msenv_6828.ico");
            this.DbIcons.Images.SetKeyName(4, "Folder_16x_32.bmp");
            this.DbIcons.Images.SetKeyName(5, "vdt80pui_1057.ico");
            // 
            // DbStructDockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 832);
            this.Controls.Add(this.structView);
            this.Name = "DbStructDockForm";
            this.Text = "Структура данных сервера";
            this.TreeContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView structView;
        private System.Windows.Forms.ContextMenuStrip TreeContextMenu;
        private System.Windows.Forms.ToolStripMenuItem selectMenuItem;
        private System.Windows.Forms.ImageList DbIcons;
    }
}