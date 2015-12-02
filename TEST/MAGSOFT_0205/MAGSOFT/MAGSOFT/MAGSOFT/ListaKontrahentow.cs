using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAGSOFT
{
    public partial class ListaKontrahentow : Form
    {
        private static ListaKontrahentow okno;
        
        public ListaKontrahentow()
        {
            InitializeComponent();
            string zapytanie = "SELECT * FROM KontrahenciTab ;";
           // BazaDanych.PokazDane(zapytanie, KontrahenciGridView1);
        }

        public static ListaKontrahentow pobierzInstancjeOkna()
        {
            if (okno == null || okno.IsDisposed) okno = new ListaKontrahentow();
            return okno;
        }

        private void ListaKontrahentow_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

    }
}
