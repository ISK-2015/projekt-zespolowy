using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace VIDSOFT
{
    public class Klient
    {
        public static int numer = 1;

        private int _idKlient;
        public int ID
        {
            get
            {
                return this._idKlient;
            }
        }

        private string _imie;
        public string Imie
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
        public string Nazwisko
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

        private string _adres;
        public string Adres
        {
            get
            {
                return this._adres;
            }
            set
            {
                this._adres = value;
            }
        }

        private string _kontakt;
        public string Kontakt
        {
            get
            {
                return this._kontakt;
            }
            set
            {
                this._kontakt = value;
            }
        }

        public Klient(int id)
        {
            if(id>0){
                this._idKlient = id;
                this.Pobierz_klienta();
            }
        } 

        private void  Pobierz_klienta()
        {
            try
            {
                SQLiteConnection polaczenie;
                polaczenie = new SQLiteConnection("Data Source=BDmagsoft.s3db;Version=3;");
                polaczenie.Open();

                SQLiteCommand polecenie;
                polecenie = polaczenie.CreateCommand();
                polecenie.CommandText = "SELECT * FROM KlienciTab WHERE KlientID = @id;";
                polecenie.Parameters.AddWithValue("@id", _idKlient);

                SQLiteDataReader reader = polecenie.ExecuteReader();

                while (reader != null && reader.Read())
                {
                    this._nazwisko = reader.GetString(1);
                    this._imie = reader.GetString(2);
                    this._adres = reader.GetString(3);
                    this._kontakt = reader.GetString(4);
                }

                polaczenie.Close();
            }

            catch (Exception e)
            {
             
            }
        }

        public void Zapisz()
        {
            if (_idKlient == 0)
            {
                try
                {
                    SQLiteConnection polaczenie;
                    polaczenie = new SQLiteConnection("Data Source=BDmagsoft.s3db;Version=3;");
                    polaczenie.Open();

                    SQLiteCommand zapytanie;
                    zapytanie = polaczenie.CreateCommand();

                    zapytanie.Parameters.AddWithValue("@nazwisko", this._nazwisko);
                    zapytanie.Parameters.AddWithValue("@imie", this._imie);
                    zapytanie.Parameters.AddWithValue("@adres", this._adres);
                    zapytanie.Parameters.AddWithValue("@kontakt", this._kontakt);
                    zapytanie.CommandText = "INSERT INTO KlienciTab (KlientID, KlientNazwisko, KlientImie, KlientAdres, KlientKontakt) VALUES(null, @nazwisko, @imie, @adres, @kontakt)";
                    zapytanie.ExecuteNonQuery();
                    //zapytanie.CommandText = "SELECT last_insert_rowid()";
                    //_idKlient = (int)zapytanie.ExecuteScalar();
                    polaczenie.Close();
                }

                catch (Exception e)
                {
                    //MessageBox.Show(e.Message);
                }
            }
            else
            {
                // Update where id==
            }
        }

        public void Usun()
        {
            //Tutaj piszesz procedure usuniecia ( where id='this._idKlenta')
        }
        


    }
}
