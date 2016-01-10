using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Movie4You
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void LoadData()
        {
      
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string MyConnectionString = "Server=serwer1585870.home.pl;Database=18659907_0000002;Uid=18659907_0000002;Pwd="+textBox1.Text+";";
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            
            try
            {
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "select * FROM tb_client";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Clone();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string MyConnectionString = "Server=serwer1585870.home.pl;Database=18659907_0000002;Uid=18659907_0000002;Pwd=" + textBox1.Text + ";";
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            try
            {
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "select * FROM tb_movies";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0].DefaultView;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Clone();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string MyConnectionString = "Server=serwer1585870.home.pl;Database=18659907_0000002;Uid=18659907_0000002;Pwd=" + textBox1.Text + ";";
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            try
            {
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "select * FROM tb_user";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView3.DataSource = ds.Tables[0].DefaultView;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Clone();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string user = dataGridView1.SelectedRows[0].Cells[4].Value.ToString() +"_"+ dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            label2.Text = user;
            string userid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            label3.Text = userid;
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About AboutWindow = new About();
            AboutWindow.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
