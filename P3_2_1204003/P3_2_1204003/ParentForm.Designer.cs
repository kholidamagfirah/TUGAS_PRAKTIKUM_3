namespace P3_2_1204003
{
    partial class ParentForm
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
            this.FileMenuItem = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WinowCascadeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowTileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenuItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.FileMenuItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.WindowMenuItem});
            this.FileMenuItem.Location = new System.Drawing.Point(0, 0);
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(317, 28);
            this.FileMenuItem.TabIndex = 1;
            this.FileMenuItem.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewMenuItem,
            this.ExitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // NewMenuItem
            // 
            this.NewMenuItem.Name = "NewMenuItem";
            this.NewMenuItem.Size = new System.Drawing.Size(181, 26);
            this.NewMenuItem.Text = "&New";
            this.NewMenuItem.Click += new System.EventHandler(this.NewMenuItem_Click);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(181, 26);
            this.ExitMenuItem.Text = "&Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // WindowMenuItem
            // 
            this.WindowMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WinowCascadeMenuItem,
            this.WindowTileMenuItem});
            this.WindowMenuItem.Name = "WindowMenuItem";
            this.WindowMenuItem.Size = new System.Drawing.Size(76, 24);
            this.WindowMenuItem.Text = "&Window";
            this.WindowMenuItem.Click += new System.EventHandler(this.windowToolStripMenuItem_Click);
            // 
            // WinowCascadeMenuItem
            // 
            this.WinowCascadeMenuItem.Name = "WinowCascadeMenuItem";
            this.WinowCascadeMenuItem.Size = new System.Drawing.Size(181, 26);
            this.WinowCascadeMenuItem.Text = "&Cascade";
            this.WinowCascadeMenuItem.Click += new System.EventHandler(this.WinowCascadeMenuItem_Click);
            // 
            // WindowTileMenuItem
            // 
            this.WindowTileMenuItem.Name = "WindowTileMenuItem";
            this.WindowTileMenuItem.Size = new System.Drawing.Size(181, 26);
            this.WindowTileMenuItem.Text = "&Tile";
            this.WindowTileMenuItem.Click += new System.EventHandler(this.WindowTileMenuItem_Click);
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 253);
            this.Controls.Add(this.FileMenuItem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.FileMenuItem;
            this.Name = "ParentForm";
            this.Text = "Parent Form";
            this.FileMenuItem.ResumeLayout(false);
            this.FileMenuItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WindowMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WinowCascadeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WindowTileMenuItem;
    }
}

