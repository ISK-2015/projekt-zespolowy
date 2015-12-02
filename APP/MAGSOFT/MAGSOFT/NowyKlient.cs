using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MAGSOFT.Klasy;


namespace MAGSOFT
{
    public partial class NowyKlient : Form
    {
        public NowyKlient()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ZapisKlient_Click(object sender, EventArgs e)
        {

            Klient N = new Klient(0);
            N.Nazwisko = this.NazwiskoKlientBox.Text;
            N.Imie = this.ImieKlientBox.Text;
            N.Adres = this.AdresKlientBox.Text;
            N.Kontakt = this.KontaktKlientBox.Text;
            N.Zapisz();
           
            
            
            this.Close();
            

        }

        private void NowyKlient_Load(object sender, EventArgs e)
        {

        }
    }
}
