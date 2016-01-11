namespace Movie4You
{
    partial class TempLoginForm
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
            this.login_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.MaskedTextBox();
            this.login_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_textbox
            // 
            this.login_textbox.Location = new System.Drawing.Point(156, 33);
            this.login_textbox.Name = "login_textbox";
            this.login_textbox.Size = new System.Drawing.Size(144, 20);
            this.login_textbox.TabIndex = 0;
            this.login_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.login_textbox_KeyPress);
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(156, 75);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(144, 20);
            this.password_textbox.TabIndex = 1;
            this.password_textbox.UseSystemPasswordChar = true;
            this.password_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_textbox_KeyPress);
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Location = new System.Drawing.Point(85, 36);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(65, 13);
            this.login_label.TabIndex = 4;
            this.login_label.Text = "Użytkownik:";
            this.login_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(111, 78);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(39, 13);
            this.password_label.TabIndex = 5;
            this.password_label.Text = "Hasło:";
            this.password_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(12, 119);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(100, 30);
            this.login_button.TabIndex = 2;
            this.login_button.Text = "Zaloguj";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(272, 119);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(100, 30);
            this.exit_button.TabIndex = 3;
            this.exit_button.Text = "Zamknij";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // TempLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.login_textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TempLoginForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowanie do Movie4You";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login_textbox;
        private System.Windows.Forms.MaskedTextBox password_textbox;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button exit_button;
    }
}