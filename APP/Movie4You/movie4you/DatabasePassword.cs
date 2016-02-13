using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie4You
{
    public partial class DatabasePassword : Form
    {
        public delegate void PassDelegate(string pass);

        public PassDelegate passwd;

        public DatabasePassword()
        {
            InitializeComponent();
            
        }

        private void OKeyButton_Click(object sender, EventArgs e)
        {
            if(DbPassTextBox.Text.Length < 1)
            {
                MessageBox.Show("Nie podałeś hasła!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                passwd(DbPassTextBox.Text);
                this.Close();
            }
        }

        private void CnclButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
