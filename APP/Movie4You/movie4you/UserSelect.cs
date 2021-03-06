﻿using System;
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
        private Main mainappform;

        //////////////////////////////////////////
        //NIE INICJALIZOWAĆ BAZY PONOWNIE!      //
        //można korzystać z bazy poprzez np.:   //
        //mainappform.database.Select()         //
        //////////////////////////////////////////

        /*      public Database database;
                public UserSelect(MainForm parentform,string pass)
                {
                    InitializeComponent();
                    mainappform = parentform;
                    database = new Database(pass);
                }
        */
        public UserSelect(Main parentform)
        {
            InitializeComponent();
            mainappform = parentform;
        }


        #region BUTTON CODE
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = mainappform.database.Select("*", "tb_client").Tables[0].DefaultView;
        }
        /*
        private void button3_Click(object sender, EventArgs e)
        {
            mainappform.selecteduser(label2.Text);
            this.Close();
        }
        */
        private void button4_Click(object sender, EventArgs e)
        {
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
