using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;



namespace VIDSOFT
{
    public partial class ListaKlientow : Form
    {
        private static ListaKlientow okno;
        
        

        public ListaKlientow()
        {
            
            InitializeComponent();
            //string zapytanie = "SELECT KlientID AS ID, KlientNazwisko AS Nazwisko, KlientImie AS Imie, KlientAdres AS Adres, KlientKontakt AS Kontakt FROM KlienciTab ;";
            //BazaDanych.PokazDane(zapytanie, KlienciDataGridView);
           // BazaDanych db = new BazaDanych();
           // IList<Klient> lista_klient = db.GetListaKlient();
           // var blist = new BindingList<Klient>(lista_klient);
            //KlienciDataGridView.DataSource = blist;
            
        }

        
        public static ListaKlientow pobierzInstancjeOkna()
        {
            if (okno == null || okno.IsDisposed) okno = new ListaKlientow();
            return okno;
        }

        

        private void FiltrujBox_TextChanged(object sender, EventArgs e)
        {
            //filtrowanie danych w tabeli;
            BindingSource zrodlo = new BindingSource();
            zrodlo.DataSource = KlienciDataGridView.DataSource;
            zrodlo.Filter = "Nazwisko LIKE '%" + FiltrujBox.Text + "%'";
            KlienciDataGridView.DataSource = zrodlo;
            
        }

       
        private void ListaKlientow_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void DodajKlientButton_Click(object sender, EventArgs e)
        {
            NowyKlient nowy = new NowyKlient();
            nowy.ShowDialog();
           
            
        }

        private void KlienciDataGridView_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                richTextBox1.Clear();
                DataGridViewRow wiersz = this.KlienciDataGridView.Rows[e.RowIndex];

                richTextBox1.Text += "\n" + "\tIdentyfikator w systemie: " + wiersz.Cells["ID"].Value.ToString() + "\n";
                richTextBox1.Text += "\tImię i Nazwisko: " + wiersz.Cells["Imie"].Value.ToString() + " " + wiersz.Cells["Nazwisko"].Value.ToString() + "\n";
                richTextBox1.Text += "\tAdres: " + wiersz.Cells["Adres"].Value.ToString() + "\n";
                richTextBox1.Text += "\tKontakt: " + wiersz.Cells["Kontakt"].Value.ToString() + "\n";

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EdycjaKlient edytuj = new EdycjaKlient();
            edytuj.ShowDialog();
        }

        private void ListaKlientow_Load(object sender, EventArgs e)
        {
            Pobierz_Klientow();
        }

        private void Pobierz_Klientow()
        {
            try
            {
                SQLiteConnection polaczenie;
                polaczenie = new SQLiteConnection("Data Source=BDmagsoft.s3db;Version=3;");
                polaczenie.Open();

                SQLiteCommand polecenie;
                polecenie = polaczenie.CreateCommand();
                polecenie.CommandText = "SELECT * FROM KlienciTab";

                SQLiteDataReader reader = polecenie.ExecuteReader();


                DataSet ds = new DataSet();
                var da = new SQLiteDataAdapter("SELECT * FROM KlienciTab", polaczenie);
                da.Fill(ds);
                KlienciDataGridView.DataSource = ds.Tables[0].DefaultView;



                polaczenie.Close();
            }

            catch (Exception e)
            {

            }
        }
        
        
    }
}
