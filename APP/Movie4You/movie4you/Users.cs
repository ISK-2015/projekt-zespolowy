using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie4You
{
    public partial class Users : UserControl
    {
        private Main mainform;

        public Users(Main parentform)
        {
            InitializeComponent();
            mainform = parentform;
        }

        private void AddUserMenuItem_Click(object sender, EventArgs e)
        {
            //Users_panel.Controls.Clear();
            //Users_panel.Controls.Add(UsersAddPanel);
        }

        private void RefreshMenuItem_Click(object sender, EventArgs e)
        {
            UsersDataGrid.DataSource = mainform.database.Select(@"id_user, username, fullname, login, pass, createdate, lastlogin_date", "tb_user").Tables[0];
        }
    }
}
