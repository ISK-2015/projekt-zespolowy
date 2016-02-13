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
    public partial class Clients : UserControl
    {
        private Main mainform;

        public Clients(Main parentform)
        {
            InitializeComponent();
            mainform = parentform;
        }

        private void RefreshClientsMenuItem_Click(object sender, EventArgs e)
        {
            ClientsdDataGrid.DataSource = mainform.database.Select("*", "tb_client").Tables[0];
        }
    }
}
