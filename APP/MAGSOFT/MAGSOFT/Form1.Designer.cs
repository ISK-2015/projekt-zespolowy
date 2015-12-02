namespace MAGSOFT
{
    partial class GlowneOkno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlowneOkno));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ListaKlientowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListaKontrahentowMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ZamknijMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListaKlientowMenuItem,
            this.ListaKontrahentowMenuItem1,
            this.oProgramieToolStripMenuItem,
            this.ZamknijMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(97, 472);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ListaKlientowMenuItem
            // 
            this.ListaKlientowMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ListaKlientowMenuItem.Image")));
            this.ListaKlientowMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ListaKlientowMenuItem.Name = "ListaKlientowMenuItem";
            this.ListaKlientowMenuItem.Size = new System.Drawing.Size(84, 95);
            this.ListaKlientowMenuItem.Text = "Lista klientów";
            this.ListaKlientowMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ListaKlientowMenuItem.Click += new System.EventHandler(this.ListaKlientowMenuItem_Click);
            // 
            // ListaKontrahentowMenuItem1
            // 
            this.ListaKontrahentowMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ListaKontrahentowMenuItem1.Image")));
            this.ListaKontrahentowMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ListaKontrahentowMenuItem1.Name = "ListaKontrahentowMenuItem1";
            this.ListaKontrahentowMenuItem1.Size = new System.Drawing.Size(85, 95);
            this.ListaKontrahentowMenuItem1.Text = "Kontrahenci";
            this.ListaKontrahentowMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ListaKontrahentowMenuItem1.Click += new System.EventHandler(this.ListaKontrahentowMenuItem1_Click);
            // 
            // ZamknijMenuItem
            // 
            this.ZamknijMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ZamknijMenuItem.Image")));
            this.ZamknijMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ZamknijMenuItem.Name = "ZamknijMenuItem";
            this.ZamknijMenuItem.Size = new System.Drawing.Size(85, 95);
            this.ZamknijMenuItem.Text = "Zamknij";
            this.ZamknijMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ZamknijMenuItem.Click += new System.EventHandler(this.ZamknijMenuItem_Click);
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("oProgramieToolStripMenuItem.Image")));
            this.oProgramieToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(88, 95);
            this.oProgramieToolStripMenuItem.Text = "O Programie";
            this.oProgramieToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // GlowneOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(683, 472);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GlowneOkno";
            this.Text = "MAG-SOFT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ListaKlientowMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ZamknijMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListaKontrahentowMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
    }
}

