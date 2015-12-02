namespace MAGSOFT
{
    partial class NowyKlient
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
            this.ImieKlientBox = new System.Windows.Forms.TextBox();
            this.NazwiskoKlientBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ZapisKlient = new System.Windows.Forms.Button();
            this.AnulujNowyButton = new System.Windows.Forms.Button();
            this.IDKlientBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AdresKlientBox = new System.Windows.Forms.TextBox();
            this.KontaktKlientBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ImieKlientBox
            // 
            this.ImieKlientBox.Location = new System.Drawing.Point(91, 46);
            this.ImieKlientBox.Name = "ImieKlientBox";
            this.ImieKlientBox.Size = new System.Drawing.Size(126, 20);
            this.ImieKlientBox.TabIndex = 0;
            // 
            // NazwiskoKlientBox
            // 
            this.NazwiskoKlientBox.Location = new System.Drawing.Point(91, 73);
            this.NazwiskoKlientBox.Name = "NazwiskoKlientBox";
            this.NazwiskoKlientBox.Size = new System.Drawing.Size(126, 20);
            this.NazwiskoKlientBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Adres";
            // 
            // ZapisKlient
            // 
            this.ZapisKlient.Location = new System.Drawing.Point(37, 205);
            this.ZapisKlient.Name = "ZapisKlient";
            this.ZapisKlient.Size = new System.Drawing.Size(87, 23);
            this.ZapisKlient.TabIndex = 6;
            this.ZapisKlient.Text = "Zapis";
            this.ZapisKlient.UseVisualStyleBackColor = true;
            this.ZapisKlient.Click += new System.EventHandler(this.ZapisKlient_Click);
            // 
            // AnulujNowyButton
            // 
            this.AnulujNowyButton.Location = new System.Drawing.Point(130, 205);
            this.AnulujNowyButton.Name = "AnulujNowyButton";
            this.AnulujNowyButton.Size = new System.Drawing.Size(87, 23);
            this.AnulujNowyButton.TabIndex = 7;
            this.AnulujNowyButton.Text = "Anuluj";
            this.AnulujNowyButton.UseVisualStyleBackColor = true;
            this.AnulujNowyButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // IDKlientBox
            // 
            this.IDKlientBox.Location = new System.Drawing.Point(91, 20);
            this.IDKlientBox.Name = "IDKlientBox";
            this.IDKlientBox.Size = new System.Drawing.Size(88, 20);
            this.IDKlientBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "ID";
            // 
            // AdresKlientBox
            // 
            this.AdresKlientBox.Location = new System.Drawing.Point(91, 100);
            this.AdresKlientBox.Name = "AdresKlientBox";
            this.AdresKlientBox.Size = new System.Drawing.Size(177, 20);
            this.AdresKlientBox.TabIndex = 11;
            // 
            // KontaktKlientBox
            // 
            this.KontaktKlientBox.Location = new System.Drawing.Point(91, 127);
            this.KontaktKlientBox.Name = "KontaktKlientBox";
            this.KontaktKlientBox.Size = new System.Drawing.Size(177, 20);
            this.KontaktKlientBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Kontakt (@/tel)";
            // 
            // NowyKlient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 262);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.KontaktKlientBox);
            this.Controls.Add(this.AdresKlientBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IDKlientBox);
            this.Controls.Add(this.AnulujNowyButton);
            this.Controls.Add(this.ZapisKlient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NazwiskoKlientBox);
            this.Controls.Add(this.ImieKlientBox);
            this.Name = "NowyKlient";
            this.Text = "NowyKlient";
            this.Load += new System.EventHandler(this.NowyKlient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ImieKlientBox;
        private System.Windows.Forms.TextBox NazwiskoKlientBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ZapisKlient;
        private System.Windows.Forms.Button AnulujNowyButton;
        private System.Windows.Forms.TextBox IDKlientBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AdresKlientBox;
        private System.Windows.Forms.TextBox KontaktKlientBox;
        private System.Windows.Forms.Label label5;
    }
}