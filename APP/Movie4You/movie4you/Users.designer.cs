namespace Movie4You
{
    partial class Users
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UsersMenuStrip = new System.Windows.Forms.MenuStrip();
            this.Users_panel = new System.Windows.Forms.Panel();
            this.UsersDataGrid = new System.Windows.Forms.DataGridView();
            this.RefreshMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddUserMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveUserMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditUserMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchUserMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FilterUsersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsersMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersMenuStrip
            // 
            this.UsersMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.UsersMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshMenuItem,
            this.AddUserMenuItem,
            this.RemoveUserMenuItem,
            this.EditUserMenuItem,
            this.SearchUserMenuItem,
            this.FilterUsersMenuItem});
            this.UsersMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.UsersMenuStrip.Name = "UsersMenuStrip";
            this.UsersMenuStrip.Size = new System.Drawing.Size(984, 47);
            this.UsersMenuStrip.TabIndex = 0;
            this.UsersMenuStrip.Text = "Usersmenustrip";
            // 
            // Users_panel
            // 
            this.Users_panel.Location = new System.Drawing.Point(721, 50);
            this.Users_panel.Name = "Users_panel";
            this.Users_panel.Size = new System.Drawing.Size(260, 431);
            this.Users_panel.TabIndex = 1;
            // 
            // UsersDataGrid
            // 
            this.UsersDataGrid.AllowUserToAddRows = false;
            this.UsersDataGrid.AllowUserToDeleteRows = false;
            this.UsersDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.UsersDataGrid.Location = new System.Drawing.Point(3, 50);
            this.UsersDataGrid.MultiSelect = false;
            this.UsersDataGrid.Name = "UsersDataGrid";
            this.UsersDataGrid.ReadOnly = true;
            this.UsersDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersDataGrid.Size = new System.Drawing.Size(712, 431);
            this.UsersDataGrid.TabIndex = 2;
            // 
            // RefreshMenuItem
            // 
            this.RefreshMenuItem.Image = global::Movie4You.Properties.Resources.database_reload1;
            this.RefreshMenuItem.Name = "RefreshMenuItem";
            this.RefreshMenuItem.Size = new System.Drawing.Size(63, 43);
            this.RefreshMenuItem.Text = "Odśwież";
            this.RefreshMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RefreshMenuItem.Click += new System.EventHandler(this.RefreshMenuItem_Click);
            // 
            // AddUserMenuItem
            // 
            this.AddUserMenuItem.Image = global::Movie4You.Properties.Resources.add1;
            this.AddUserMenuItem.Name = "AddUserMenuItem";
            this.AddUserMenuItem.Size = new System.Drawing.Size(119, 43);
            this.AddUserMenuItem.Text = "Dodaj użytkownika";
            this.AddUserMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AddUserMenuItem.Click += new System.EventHandler(this.AddUserMenuItem_Click);
            // 
            // RemoveUserMenuItem
            // 
            this.RemoveUserMenuItem.Image = global::Movie4You.Properties.Resources.trash_empty1;
            this.RemoveUserMenuItem.Name = "RemoveUserMenuItem";
            this.RemoveUserMenuItem.Size = new System.Drawing.Size(115, 43);
            this.RemoveUserMenuItem.Text = "Usuń użytkownika";
            this.RemoveUserMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // EditUserMenuItem
            // 
            this.EditUserMenuItem.Image = global::Movie4You.Properties.Resources.edit_alt_11;
            this.EditUserMenuItem.Name = "EditUserMenuItem";
            this.EditUserMenuItem.Size = new System.Drawing.Size(121, 43);
            this.EditUserMenuItem.Text = "Edytuj użytkownika";
            this.EditUserMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SearchUserMenuItem
            // 
            this.SearchUserMenuItem.Image = global::Movie4You.Properties.Resources.search1;
            this.SearchUserMenuItem.Name = "SearchUserMenuItem";
            this.SearchUserMenuItem.Size = new System.Drawing.Size(121, 43);
            this.SearchUserMenuItem.Text = "Szukaj użytkownika";
            this.SearchUserMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // FilterUsersMenuItem
            // 
            this.FilterUsersMenuItem.Image = global::Movie4You.Properties.Resources.filter1;
            this.FilterUsersMenuItem.Name = "FilterUsersMenuItem";
            this.FilterUsersMenuItem.Size = new System.Drawing.Size(128, 43);
            this.FilterUsersMenuItem.Text = "Filtruj użytkowników";
            this.FilterUsersMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UsersDataGrid);
            this.Controls.Add(this.Users_panel);
            this.Controls.Add(this.UsersMenuStrip);
            this.Name = "Users";
            this.Size = new System.Drawing.Size(984, 484);
            this.UsersMenuStrip.ResumeLayout(false);
            this.UsersMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip UsersMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AddUserMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveUserMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditUserMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchUserMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FilterUsersMenuItem;
        private System.Windows.Forms.Panel Users_panel;
        private System.Windows.Forms.DataGridView UsersDataGrid;
        private System.Windows.Forms.ToolStripMenuItem RefreshMenuItem;
    }
}
