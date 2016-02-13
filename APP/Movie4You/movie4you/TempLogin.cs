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
    public partial class TempLoginForm : Form
    {
        private Main mainappform;
        public TempLoginForm(Main parentform)
        {
            InitializeComponent();
            mainappform = parentform;
            login_textbox.Focus();
        }
        
        private void login_button_Click(object sender, EventArgs e)
        {
          //  mainappform.dbpass(password_textbox.Text);
            //MessageBox.Show(password_textbox.Text);
            if (mainappform.database.TryConnect() == true)
            {
                mainappform.Enabled = true;
                mainappform.WindowState = FormWindowState.Normal;
                this.Close();
            }
            else
            {
                StringBuilder err = new StringBuilder();
                err.Append("Wystąpił błąd podczas połączenia z bazą.");
                err.AppendLine("MySQLConnector zwrócił następujący błąd:");
                err.AppendLine(mainappform.database.ExceptionMessage);
                MessageBox.Show(err.ToString(), "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void password_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                login_button.PerformClick();
            }
        }

        private void login_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                password_textbox.Focus();
            }
        }
    }
}
