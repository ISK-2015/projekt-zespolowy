namespace Movie4You
{
    partial class DatabasePassword
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
            this.DbPassLabel = new System.Windows.Forms.Label();
            this.DbPassTextBox = new System.Windows.Forms.TextBox();
            this.OKeyButton = new System.Windows.Forms.Button();
            this.CnclButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DbPassLabel
            // 
            this.DbPassLabel.AutoSize = true;
            this.DbPassLabel.Location = new System.Drawing.Point(70, 29);
            this.DbPassLabel.Margin = new System.Windows.Forms.Padding(20);
            this.DbPassLabel.Name = "DbPassLabel";
            this.DbPassLabel.Size = new System.Drawing.Size(145, 13);
            this.DbPassLabel.TabIndex = 0;
            this.DbPassLabel.Text = "Podaj hasło do bazy danych:";
            // 
            // DbPassTextBox
            // 
            this.DbPassTextBox.Location = new System.Drawing.Point(42, 65);
            this.DbPassTextBox.Name = "DbPassTextBox";
            this.DbPassTextBox.Size = new System.Drawing.Size(200, 20);
            this.DbPassTextBox.TabIndex = 1;
            // 
            // OKeyButton
            // 
            this.OKeyButton.Location = new System.Drawing.Point(13, 122);
            this.OKeyButton.Name = "OKeyButton";
            this.OKeyButton.Size = new System.Drawing.Size(75, 23);
            this.OKeyButton.TabIndex = 2;
            this.OKeyButton.Text = "OK";
            this.OKeyButton.UseVisualStyleBackColor = true;
            this.OKeyButton.Click += new System.EventHandler(this.OKeyButton_Click);
            // 
            // CnclButton
            // 
            this.CnclButton.Location = new System.Drawing.Point(197, 121);
            this.CnclButton.Name = "CnclButton";
            this.CnclButton.Size = new System.Drawing.Size(75, 23);
            this.CnclButton.TabIndex = 3;
            this.CnclButton.Text = "Anuluj";
            this.CnclButton.UseVisualStyleBackColor = true;
            this.CnclButton.Click += new System.EventHandler(this.CnclButton_Click);
            // 
            // DatabasePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 166);
            this.Controls.Add(this.CnclButton);
            this.Controls.Add(this.OKeyButton);
            this.Controls.Add(this.DbPassTextBox);
            this.Controls.Add(this.DbPassLabel);
            this.Name = "DatabasePassword";
            this.Text = "DatabasePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DbPassLabel;
        private System.Windows.Forms.TextBox DbPassTextBox;
        private System.Windows.Forms.Button OKeyButton;
        private System.Windows.Forms.Button CnclButton;
    }
}