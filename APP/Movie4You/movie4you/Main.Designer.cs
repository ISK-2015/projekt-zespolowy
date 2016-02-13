namespace Movie4You
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.connect_menuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnect_menuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.clients_menuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.movies_menuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.carriers_menuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.rents_meniutem = new System.Windows.Forms.ToolStripMenuItem();
            this.users_menuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.about_menuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_menuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatusStip = new System.Windows.Forms.StatusStrip();
            this.connection_statusstip = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.mainMenuStrip.SuspendLayout();
            this.mainStatusStip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connect_menuitem,
            this.disconnect_menuitem,
            this.clients_menuitem,
            this.movies_menuitem,
            this.carriers_menuitem,
            this.users_menuitem,
            this.rents_meniutem,
            this.about_menuitem,
            this.exit_menuitem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.mainMenuStrip.Size = new System.Drawing.Size(1968, 59);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "MainMenuStrip";
            // 
            // connect_menuitem
            // 
            this.connect_menuitem.Image = global::Movie4You.Properties.Resources.connect_alt_21;
            this.connect_menuitem.Name = "connect_menuitem";
            this.connect_menuitem.Size = new System.Drawing.Size(53, 51);
            this.connect_menuitem.Text = "Połącz";
            this.connect_menuitem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.connect_menuitem.Click += new System.EventHandler(this.connect_menuitem_Click);
            // 
            // disconnect_menuitem
            // 
            this.disconnect_menuitem.Image = global::Movie4You.Properties.Resources.connection_error_alt_21;
            this.disconnect_menuitem.Name = "disconnect_menuitem";
            this.disconnect_menuitem.Size = new System.Drawing.Size(58, 51);
            this.disconnect_menuitem.Text = "Rozłącz";
            this.disconnect_menuitem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.disconnect_menuitem.Visible = false;
            this.disconnect_menuitem.Click += new System.EventHandler(this.disconnect_menuitem_Click);
            // 
            // clients_menuitem
            // 
            this.clients_menuitem.Enabled = false;
            this.clients_menuitem.Image = global::Movie4You.Properties.Resources.users_alt1;
            this.clients_menuitem.Name = "clients_menuitem";
            this.clients_menuitem.Size = new System.Drawing.Size(54, 51);
            this.clients_menuitem.Text = "Klienci";
            this.clients_menuitem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.clients_menuitem.Click += new System.EventHandler(this.clients_menuitem_Click);
            // 
            // movies_menuitem
            // 
            this.movies_menuitem.Enabled = false;
            this.movies_menuitem.Image = global::Movie4You.Properties.Resources.cinema1;
            this.movies_menuitem.Name = "movies_menuitem";
            this.movies_menuitem.Size = new System.Drawing.Size(48, 51);
            this.movies_menuitem.Text = "Filmy";
            this.movies_menuitem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // carriers_menuitem
            // 
            this.carriers_menuitem.Enabled = false;
            this.carriers_menuitem.Image = global::Movie4You.Properties.Resources.MD_cd1;
            this.carriers_menuitem.Name = "carriers_menuitem";
            this.carriers_menuitem.Size = new System.Drawing.Size(59, 51);
            this.carriers_menuitem.Text = "Nośniki";
            this.carriers_menuitem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // rents_meniutem
            // 
            this.rents_meniutem.Enabled = false;
            this.rents_meniutem.Image = global::Movie4You.Properties.Resources.content1;
            this.rents_meniutem.Name = "rents_meniutem";
            this.rents_meniutem.Size = new System.Drawing.Size(94, 51);
            this.rents_meniutem.Text = "Wypożyczenia";
            this.rents_meniutem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // users_menuitem
            // 
            this.users_menuitem.Enabled = false;
            this.users_menuitem.Image = global::Movie4You.Properties.Resources.users1;
            this.users_menuitem.Name = "users_menuitem";
            this.users_menuitem.Size = new System.Drawing.Size(86, 51);
            this.users_menuitem.Text = "Użytkownicy";
            this.users_menuitem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.users_menuitem.Click += new System.EventHandler(this.users_menuitem_Click);
            // 
            // about_menuitem
            // 
            this.about_menuitem.Image = global::Movie4You.Properties.Resources.about1;
            this.about_menuitem.Name = "about_menuitem";
            this.about_menuitem.Size = new System.Drawing.Size(86, 51);
            this.about_menuitem.Text = "O programie";
            this.about_menuitem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.about_menuitem.Click += new System.EventHandler(this.about_menuitem_Click);
            // 
            // exit_menuitem
            // 
            this.exit_menuitem.Image = global::Movie4You.Properties.Resources.cancel1;
            this.exit_menuitem.Name = "exit_menuitem";
            this.exit_menuitem.Size = new System.Drawing.Size(59, 51);
            this.exit_menuitem.Text = "Wyjście";
            this.exit_menuitem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.exit_menuitem.Click += new System.EventHandler(this.exit_menuitem_Click);
            // 
            // mainStatusStip
            // 
            this.mainStatusStip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connection_statusstip});
            this.mainStatusStip.Location = new System.Drawing.Point(0, 1031);
            this.mainStatusStip.Name = "mainStatusStip";
            this.mainStatusStip.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.mainStatusStip.Size = new System.Drawing.Size(1968, 22);
            this.mainStatusStip.TabIndex = 1;
            this.mainStatusStip.Text = "statusstrip";
            // 
            // connection_statusstip
            // 
            this.connection_statusstip.Name = "connection_statusstip";
            this.connection_statusstip.Size = new System.Drawing.Size(98, 17);
            this.connection_statusstip.Text = "Status połączenia";
            // 
            // mainpanel
            // 
            this.mainpanel.Location = new System.Drawing.Point(0, 113);
            this.mainpanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1968, 917);
            this.mainpanel.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1968, 1053);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.mainStatusStip);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Main";
            this.Text = "Movie4You";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainStatusStip.ResumeLayout(false);
            this.mainStatusStip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem connect_menuitem;
        private System.Windows.Forms.ToolStripMenuItem disconnect_menuitem;
        private System.Windows.Forms.ToolStripMenuItem clients_menuitem;
        private System.Windows.Forms.ToolStripMenuItem movies_menuitem;
        private System.Windows.Forms.ToolStripMenuItem carriers_menuitem;
        private System.Windows.Forms.ToolStripMenuItem rents_meniutem;
        private System.Windows.Forms.ToolStripMenuItem users_menuitem;
        private System.Windows.Forms.ToolStripMenuItem about_menuitem;
        private System.Windows.Forms.ToolStripMenuItem exit_menuitem;
        private System.Windows.Forms.StatusStrip mainStatusStip;
        private System.Windows.Forms.ToolStripStatusLabel connection_statusstip;
        private System.Windows.Forms.Panel mainpanel;
    }
}