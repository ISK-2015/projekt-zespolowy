namespace MAGSOFT
{
    partial class ListaKontrahentow
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
            this.KontrahenciGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.KontrahenciGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // KontrahenciGridView1
            // 
            this.KontrahenciGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KontrahenciGridView1.ColumnHeadersVisible = false;
            this.KontrahenciGridView1.Location = new System.Drawing.Point(12, 28);
            this.KontrahenciGridView1.Name = "KontrahenciGridView1";
            this.KontrahenciGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.KontrahenciGridView1.Size = new System.Drawing.Size(578, 328);
            this.KontrahenciGridView1.TabIndex = 1;
            // 
            // ListaKontrahentow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 456);
            this.Controls.Add(this.KontrahenciGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListaKontrahentow";
            this.Text = "ListaKontrahentow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.ListaKontrahentow_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.KontrahenciGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView KontrahenciGridView1;
    }
}