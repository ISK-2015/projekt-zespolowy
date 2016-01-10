namespace VIDSOFT
{
    partial class OProgramie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OProgramie));
            this.OProgramie_etyk = new System.Windows.Forms.Label();
            this.Wersja = new System.Windows.Forms.Label();
            this.Autorzy_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OProgramie_etyk
            // 
            this.OProgramie_etyk.Dock = System.Windows.Forms.DockStyle.Top;
            this.OProgramie_etyk.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OProgramie_etyk.Location = new System.Drawing.Point(5, 5);
            this.OProgramie_etyk.Name = "OProgramie_etyk";
            this.OProgramie_etyk.Size = new System.Drawing.Size(274, 37);
            this.OProgramie_etyk.TabIndex = 0;
            this.OProgramie_etyk.Text = "Video4You";
            this.OProgramie_etyk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Wersja
            // 
            this.Wersja.Location = new System.Drawing.Point(12, 46);
            this.Wersja.Name = "Wersja";
            this.Wersja.Size = new System.Drawing.Size(264, 30);
            this.Wersja.TabIndex = 3;
            this.Wersja.Text = "label1";
            this.Wersja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Autorzy_text
            // 
            this.Autorzy_text.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Autorzy_text.Location = new System.Drawing.Point(8, 81);
            this.Autorzy_text.Margin = new System.Windows.Forms.Padding(5);
            this.Autorzy_text.Name = "Autorzy_text";
            this.Autorzy_text.Size = new System.Drawing.Size(268, 275);
            this.Autorzy_text.TabIndex = 4;
            this.Autorzy_text.Text = "label1";
            this.Autorzy_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OProgramie
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.Autorzy_text);
            this.Controls.Add(this.Wersja);
            this.Controls.Add(this.OProgramie_etyk);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "OProgramie";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "O programie";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label OProgramie_etyk;
        private System.Windows.Forms.Label Wersja;
        private System.Windows.Forms.Label Autorzy_text;
    }
}