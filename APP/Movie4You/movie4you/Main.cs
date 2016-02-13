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
    public partial class Main : Form
    {
        public Database database;
        private string databasepassword = String.Empty;
        Image connect = Properties.Resources.connect_alt_21;
        Image disconnect = Properties.Resources.connection_error_alt_21;
        Users UsersPanel;
        Clients ClientsPanel;
        DatabasePassword dbpassdialog = new DatabasePassword();


        public Main()
        {
            InitializeComponent();
            UsersPanel = new Users(this);
            ClientsPanel = new Clients(this);
            connection_statusstip.Text = "Rozłączony";
            connection_statusstip.Image = disconnect;
            dbpassdialog.passwd = new DatabasePassword.PassDelegate(StorePass);
        }
        private void StorePass(string pwd)
        {
            databasepassword = pwd;
        }
        private void EnableMenu(bool state)
        {
            connect_menuitem.Visible = !state;
            disconnect_menuitem.Visible = state;
            clients_menuitem.Enabled = state;
            movies_menuitem.Enabled = state;
            carriers_menuitem.Enabled = state;
            rents_meniutem.Enabled = state;
            users_menuitem.Enabled = state;

        }

        private void exit_menuitem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void about_menuitem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void users_menuitem_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(UsersPanel);
        }

        private void connect_menuitem_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                dbpassdialog.ShowDialog();
                database = new Database(databasepassword);
            }
            if (database.TryConnect())
            {
                connection_statusstip.Text = "Połączono";
                connection_statusstip.Image = connect;
                EnableMenu(true);
            }
            else
            {
                MessageBox.Show(database.ExceptionMessage + "\n\n\nNumer:" + database.ExceptionNumber, "Błąd przy połączeniu z bazą", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (database.ExceptionNumber == 1045)
                {
                    dbpassdialog.ShowDialog();
                    database.ChangePassword(databasepassword);
                }
            }
        }

        private void disconnect_menuitem_Click(object sender, EventArgs e)
        {
            database.Disconnect();
            EnableMenu(false);
            connection_statusstip.Text = "Rozłączony";
            connection_statusstip.Image = disconnect;
        }

        private void clients_menuitem_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(ClientsPanel);
        }
    }
}
