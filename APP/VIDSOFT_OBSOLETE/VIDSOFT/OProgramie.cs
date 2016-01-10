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
    public partial class OProgramie : Form
    {
        public OProgramie()
        {
            InitializeComponent();
            OProgramie_etyk.Text = Application.ProductName.ToString();
            Wersja.Text = "Wersja programu: " + Application.ProductVersion.ToString();
            string autorzy_string = string.Format("Autorzy:{0}{0}Patryk Kamiński{0}Mateusz Świderski{0}Paweł Szydlik{0}{0}Program przygotowany na zaliczenie projektu grupowego{0}{0}SGGW 2015/2016", Environment.NewLine);
            Autorzy_text.Text = autorzy_string;

        }
    }
}
