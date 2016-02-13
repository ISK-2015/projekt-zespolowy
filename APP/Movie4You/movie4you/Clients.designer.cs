namespace Movie4You
{
    partial class Clients
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
            this.ClientsMenuStrip = new System.Windows.Forms.MenuStrip();
            this.RefreshClientsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddClientMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveClientMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditClientMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientsdDataGrid = new System.Windows.Forms.DataGridView();
            this.ClientPropPanel = new System.Windows.Forms.Panel();
            this.ClientsMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsdDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientsMenuStrip
            // 
            this.ClientsMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ClientsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshClientsMenuItem,
            this.AddClientMenuItem,
            this.RemoveClientMenuItem,
            this.EditClientMenuItem});
            this.ClientsMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ClientsMenuStrip.Name = "ClientsMenuStrip";
            this.ClientsMenuStrip.Size = new System.Drawing.Size(984, 47);
            this.ClientsMenuStrip.TabIndex = 0;
            this.ClientsMenuStrip.Text = "ClientMenuStrip";
            // 
            // RefreshClientsMenuItem
            // 
            this.RefreshClientsMenuItem.Image = global::Movie4You.Properties.Resources.database_reload1;
            this.RefreshClientsMenuItem.Name = "RefreshClientsMenuItem";
            this.RefreshClientsMenuItem.Size = new System.Drawing.Size(63, 43);
            this.RefreshClientsMenuItem.Text = "Odswież";
            this.RefreshClientsMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RefreshClientsMenuItem.Click += new System.EventHandler(this.RefreshClientsMenuItem_Click);
            // 
            // AddClientMenuItem
            // 
            this.AddClientMenuItem.Image = global::Movie4You.Properties.Resources.add1;
            this.AddClientMenuItem.Name = "AddClientMenuItem";
            this.AddClientMenuItem.Size = new System.Drawing.Size(88, 43);
            this.AddClientMenuItem.Text = "Dodaj klienta";
            this.AddClientMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // RemoveClientMenuItem
            // 
            this.RemoveClientMenuItem.Image = global::Movie4You.Properties.Resources.trash_empty1;
            this.RemoveClientMenuItem.Name = "RemoveClientMenuItem";
            this.RemoveClientMenuItem.Size = new System.Drawing.Size(84, 43);
            this.RemoveClientMenuItem.Text = "Usuń klienta";
            this.RemoveClientMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // EditClientMenuItem
            // 
            this.EditClientMenuItem.Image = global::Movie4You.Properties.Resources.edit_alt_11;
            this.EditClientMenuItem.Name = "EditClientMenuItem";
            this.EditClientMenuItem.Size = new System.Drawing.Size(90, 43);
            this.EditClientMenuItem.Text = "Edytuj klienta";
            this.EditClientMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ClientsdDataGrid
            // 
            this.ClientsdDataGrid.AllowUserToAddRows = false;
            this.ClientsdDataGrid.AllowUserToDeleteRows = false;
            this.ClientsdDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientsdDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsdDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.ClientsdDataGrid.Location = new System.Drawing.Point(3, 50);
            this.ClientsdDataGrid.MultiSelect = false;
            this.ClientsdDataGrid.Name = "ClientsdDataGrid";
            this.ClientsdDataGrid.ReadOnly = true;
            this.ClientsdDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientsdDataGrid.Size = new System.Drawing.Size(730, 431);
            this.ClientsdDataGrid.TabIndex = 1;
            // 
            // ClientPropPanel
            // 
            this.ClientPropPanel.Location = new System.Drawing.Point(740, 51);
            this.ClientPropPanel.Name = "ClientPropPanel";
            this.ClientPropPanel.Size = new System.Drawing.Size(241, 430);
            this.ClientPropPanel.TabIndex = 2;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ClientPropPanel);
            this.Controls.Add(this.ClientsdDataGrid);
            this.Controls.Add(this.ClientsMenuStrip);
            this.Name = "Clients";
            this.Size = new System.Drawing.Size(984, 484);
            this.ClientsMenuStrip.ResumeLayout(false);
            this.ClientsMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsdDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem RefreshClientsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddClientMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveClientMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditClientMenuItem;
        private System.Windows.Forms.MenuStrip ClientsMenuStrip;
        private System.Windows.Forms.DataGridView ClientsdDataGrid;
        private System.Windows.Forms.Panel ClientPropPanel;
    }
}
