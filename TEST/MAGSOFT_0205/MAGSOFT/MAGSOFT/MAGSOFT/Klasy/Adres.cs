using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGSOFT.Klasy
{
    class Adres
    {
        string _Ulica; //ukryty parametr z "_"
        public string Ulica //właściwość "Ulica" publiczne
        {
            set
            {
                //if (!value.Equals("Kopernika")) //jeśli wartość nie jest równa Kopiernika
                this._Ulica = value; // przypisz wartość _Ulica;
                /*else
                    throw new Exception("Niestety Kopernika jest niedozwolone!"); //jeśli jest równe Kopiernika to wyrzuć komunikat... ; */
            }
            get
            {
                return this._Ulica;
            }
        }

        string _NrDomu;
        public string NrDomu
        {
            set
            {
                this._NrDomu = value;
            }
            get
            {
                return this._NrDomu;
            }
        }

        string _NrMieszkania;
        public string NrMieszkania
        {
            set
            {
                this._NrMieszkania = value;
            }
            get
            {
                return this._NrMieszkania;
            }
        }

        string _Miasto;
        public string Miasto
        {
            set
            {
                this._Miasto = value;
            }
            get
            {
                return this._Miasto;
            }
        }

        string _KodPocztowy;
        public string KodPocztowy
        {
            set
            {
                this._KodPocztowy = value;
            }
            get
            {
                return this._KodPocztowy;
            }
        }

        string _Wojewodztwo;
        public string Wojewodztwo
        {
            set
            {
                this._Wojewodztwo = value;
            }
            get
            {
                return this._Wojewodztwo;
            }
        }

        string _Kraj;
        public string Kraj
        {
            set
            {
                this._Kraj = value;
            }
            get
            {
                return this._Kraj;
            }
        }


        /*
        public string getUlica()
        {
            return this.Ulica;
        }

        public void setUlica(string _ulica) //metoda publiczna ustawiająca parametry klasy które są private; void nie zwraca, tylko ustawia;
        {
            this.Ulica = _ulica;
        }
         */

    }
}
