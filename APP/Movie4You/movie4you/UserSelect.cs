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
    public partial class UserSelect : Form
    {
        private MainForm mainappform;
        public Database database;

        public UserSelect(MainForm parentform,string pass)
        {
            InitializeComponent();
            mainappform = parentform;
            database = new Database(pass);
        }


        #region BUTTON CODE
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = database.Select("*", "tb_client").Tables[0].DefaultView;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainappform.selecteduser(label2.Text);
            mainappform.Enabled = true;
            mainappform.WindowState = FormWindowState.Normal;
            mainappform.selecteduser(label2.Text);
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mainappform.Enabled = true;
            mainappform.WindowState = FormWindowState.Normal;
            this.Close();
        }
        #endregion
        #region DATAGRID CODE
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           label2.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString() + "_" + dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            NewUser NU = new NewUser();
            NU.ShowDialog();
        }
    }
}
