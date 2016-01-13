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
    public partial class MainForm : Form
    {
#region CONSTRUCTORS
        private string _dbpass;
        //private string _selecteduser;
        public Database database;
        public void dbpass(string pass)
        {
            _dbpass = pass;
            database = new Database(_dbpass);
        }
        public void selecteduser(string us)
        {
            label1.Text = us;
        }
        
        #endregion
        //public bool dbpasscheck()
        //{

        //if (_dbpass == "err")
        //{ return false; }
        //else
        //{ return true; }
        //}

        public MainForm()
        {
            InitializeComponent();
            this.Enabled = false;
            TempLoginForm loginform = new TempLoginForm(this);
            loginform.TopLevel = true;
            loginform.ShowDialog();

        }

#region BUTTON CODE
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = database.Select("*", "tb_client").Tables[0].DefaultView;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = database.Select("*", "tb_movies").Tables[0].DefaultView;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = database.Select("*", "tb_user").Tables[0].DefaultView;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            UserSelect US = new UserSelect(this, _dbpass);
            US.TopLevel = true;
            US.ShowDialog();
        }
        #endregion
#region DATAGRID CODE
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //string user = dataGridView1.SelectedRows[0].Cells[4].Value.ToString() +"_"+ dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            //label2.Text = user;
            //string userid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            //label3.Text = userid;
            
        }
        #endregion
#region Strip Menu
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About AboutWindow = new About();
            AboutWindow.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion


    }
}
