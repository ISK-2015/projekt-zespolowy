namespace VIDSOFT
{
    partial class ListaKlientow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaKlientow));
            this.KlienciDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DodajKlientButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.FiltrujBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataSet1 = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.KlienciDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // KlienciDataGridView
            // 
            this.KlienciDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.KlienciDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KlienciDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KlienciDataGridView.Location = new System.Drawing.Point(0, 0);
            this.KlienciDataGridView.Name = "KlienciDataGridView";
            this.KlienciDataGridView.ReadOnly = true;
            this.KlienciDataGridView.RowHeadersVisible = false;
            this.KlienciDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.KlienciDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.KlienciDataGridView.ShowEditingIcon = false;
            this.KlienciDataGridView.Size = new System.Drawing.Size(717, 200);
            this.KlienciDataGridView.TabIndex = 0;
            this.KlienciDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KlienciDataGridView_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 269);
            this.panel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.DodajKlientButton);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(249, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 250);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wizytówka";
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(173, 164);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 59);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(88, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 59);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DodajKlientButton
            // 
            this.DodajKlientButton.Image = ((System.Drawing.Image)(resources.GetObject("DodajKlientButton.Image")));
            this.DodajKlientButton.Location = new System.Drawing.Point(7, 164);
            this.DodajKlientButton.Name = "DodajKlientButton";
            this.DodajKlientButton.Size = new System.Drawing.Size(75, 59);
            this.DodajKlientButton.TabIndex = 1;
            this.DodajKlientButton.UseVisualStyleBackColor = true;
            this.DodajKlientButton.Click += new System.EventHandler(this.DodajKlientButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(7, 18);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(352, 140);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "\n        Identyfikator w systemie:\n                      Imie i nazwisko:\n       " +
    "                              Adres:\n                                  Kontakt:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.FiltrujBox);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 251);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrowanie";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.Location = new System.Drawing.Point(62, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // FiltrujBox
            // 
            this.FiltrujBox.Location = new System.Drawing.Point(83, 51);
            this.FiltrujBox.Name = "FiltrujBox";
            this.FiltrujBox.Size = new System.Drawing.Size(100, 20);
            this.FiltrujBox.TabIndex = 0;
            this.FiltrujBox.TextChanged += new System.EventHandler(this.FiltrujBox_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.KlienciDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(717, 200);
            this.panel2.TabIndex = 3;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // ListaKlientow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 469);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListaKlientow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lista klientów";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.ListaKlientow_Activated);
            this.Load += new System.EventHandler(this.ListaKlientow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KlienciDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox FiltrujBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Button DodajKlientButton;
        private System.Data.DataSet dataSet1;
        public System.Windows.Forms.DataGridView KlienciDataGridView;
    }
}