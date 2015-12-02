using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGSOFT
{
    public class Klient
    {
        public static int numer = 1;

        private int _idKlient;
        public int idKlient
        {
            get
            {
                return this._idKlient;
            }
        }

        private string _imie;
        public string imie
        {
            get
            {
                return this._imie;
            }

            set
            {
                this._imie = value;
            }
        }

        private string _nazwisko;
        public string nazwisko
        {
            get
            {
                return this._nazwisko;
            }

            set
            {
                this._nazwisko = value;
            }
        }

        private string _stanowisko;
        public string stanowisko {
            get
            {
                return this._stanowisko;
            }
            set
            {
                this._stanowisko = value;
            }
        }
        private string _pesel;
        public string pesel
        {
            get
            {
                return this._pesel;
            }
            set
            {
                this._pesel = value;
            }
        }

        public Klient()
        {
            this._idKlient = numer;
            numer++;
        }


        public string NazwaOsoby()
        {
            return this._nazwisko + ' ' + this._imie;

        }

    }
}
