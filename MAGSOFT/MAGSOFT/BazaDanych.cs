using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;

namespace MAGSOFT
{
    class BazaDanych
    {
        SQLiteConnection polaczenie;

        public BazaDanych()//źródło bazy
        {
            this.polaczenie = new SQLiteConnection("Data Source=BDmagsoft.s3db;Version=3;");
        }
        
        public IList<Klient> GetListaKlient()
        {
            IList<Klient> lista = new List<Klient>();
            try
            {
                polaczenie.Open();

                SQLiteCommand polecenie;
                polecenie = polaczenie.CreateCommand();
                //zapytanie
                polecenie.CommandText = "SELECT KlientID AS ID, KlientNazwisko AS Nazwisko, KlientImie AS Imie, KlientAdres AS Adres, KlientKontakt AS Kontakt FROM KlienciTab ;";
                //wykonaj zapytanie
                SQLiteDataReader reader = polecenie.ExecuteReader();

                while (reader != null && reader.Read())
                {
                    //wczytuje kolumny
                    int ID = reader.GetInt16(0);
                    string Nazwisko = reader.GetString(1);
                    string Imię = reader.GetString(2);
                    string Adres = reader.GetString(3);
                    string Kontakt = reader.GetString(4);

                    //Klient NowyKlient = new Klient(Nazwisko, Imię, Adres, Kontakt);


                    //lista.Add(NowyKlient);
                }

                polaczenie.Close();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                
            }

            return lista;
        }

        public Klient GetKlient(int id)
        {
            Klient klient = null;

            try
            {
                polaczenie.Open();

                SQLiteCommand polecenie;
                polecenie = polaczenie.CreateCommand();
                polecenie.CommandText = "SELECT KlientID AS ID, KlientNazwisko AS Nazwisko, KlientImie AS Imie, KlientAdres AS Adres, KlientKontakt AS Kontakt FROM KlienciTab WHERE KlientID = @id;";
                polecenie.Parameters.AddWithValue("@id", id);

                SQLiteDataReader reader = polecenie.ExecuteReader();

                while (reader != null && reader.Read())
                {
                    int ID = reader.GetInt16(0);
                    string Nazwisko = reader.GetString(1);
                    string Imię = reader.GetString(2);
                    string Adres = reader.GetString(3);
                    string Kontakt = reader.GetString(4);

                    //klient = new Klient(ID, Nazwisko, Imię, Adres, Kontakt);
                }

                polaczenie.Close();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return klient;
        }

        public void DodajKlient(Klient klient)
        {
            try
            {
                polaczenie.Open();

                SQLiteCommand zapytanie;
                zapytanie = polaczenie.CreateCommand();

                zapytanie.Parameters.AddWithValue("@ID", klient.ID);
                zapytanie.Parameters.AddWithValue("@nazwisko", klient.Nazwisko);
                zapytanie.Parameters.AddWithValue("@imie", klient.Imie);
                zapytanie.Parameters.AddWithValue("@adres", klient.Adres);
                zapytanie.Parameters.AddWithValue("@kontakt", klient.Kontakt);
                //zapytanie.CommandText = "INSERT INTO KlienciTab (KlientID, KlientNazwisko, KlientImie, KlientAdres, KlientKontakt) VALUES(@ID, @nazwisko, @imie, @adres, @kontakt)";
                zapytanie.CommandText = "INSERT INTO KlienciTab (KlientID, KlientNazwisko) VALUES(null, mateusz);";

                zapytanie.ExecuteNonQuery();

                polaczenie.Close();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
       
        //sprawdz numer ostatniego rekordu; +1 i wyswietl w textbox ID w nowyklient
        
    }
}
