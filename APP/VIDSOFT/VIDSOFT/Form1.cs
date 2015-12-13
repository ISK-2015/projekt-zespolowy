using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIDSOFT
{
    public partial class GlowneOkno : Form
    {
        public GlowneOkno()
        {
            InitializeComponent();
        }

        private void ZamknijMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ListaKlientowMenuItem_Click(object sender, EventArgs e)
        {
            ListaKlientow OknoPotomne = ListaKlientow.pobierzInstancjeOkna();
            OknoPotomne.MdiParent = this;
            OknoPotomne.Height = this.Height;
            OknoPotomne.Width = this.Width;
            OknoPotomne.BringToFront();
            OknoPotomne.Show();

        }

        private void ListaKontrahentowMenuItem1_Click(object sender, EventArgs e)
        {
            ListaKontrahentow OknoPotomne = ListaKontrahentow.pobierzInstancjeOkna();
            OknoPotomne.MdiParent = this;
            OknoPotomne.Height = this.Height;
            OknoPotomne.Width = this.Width;
            OknoPotomne.BringToFront();
            OknoPotomne.Show();
        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OProgramie OknoPotomne = new OProgramie();
            OknoPotomne.Show();
        }
    }
}
