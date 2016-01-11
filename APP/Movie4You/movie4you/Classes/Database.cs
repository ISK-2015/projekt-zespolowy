using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Movie4You
{
    public class Database
    {
        private MySqlConnection connection;
        private string connectionstring;
        private string _exception;

        public Database(string pass)
        {
            connectionstring = @"Server=serwer1585870.home.pl;Database=18659907_0000002;Uid=18659907_0000002;Pwd=" + pass + ";";
            connection = new MySqlConnection(connectionstring);
        }
        public ConnectionState State
        {
            get
            {
                return connection.State;
            }
        }
        public string Exception
        {
            get
            {
                return _exception;
            }
        }
        public void Open()
        {
            connection.Open();
        }
        public void Close()
        {
            connection.Close();
        }
        public bool CheckConnection()
        {
            bool _result = true;
            try
            {
                connection.Open();
                connection.Close();
            }
            catch (MySqlException ex)
            {
                _exception = ex.ToString();
                _result = false;
                connection = null;
            }
            return _result;
        }
        //bardzo wstępna wersja, w sumie tylko przedstawia koncepcję jak bym to rozwiązał
        //potrzeba jeszcze przeciążania, koniecznie sprawdzania poprawności wprowadzonych danych i obsługi błędów
        public DataSet Select(string what, string table)
        {
            if (_Opener())
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT " + what + " FROM " + table;
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                return ds;
            }
            else
            {
                return null;
            }

        }
        private bool _Opener()
        {
            if (connection.State == ConnectionState.Open)
            {
                return true;
            }else if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                return true;
            }else
            {
                return false;
            }
        }
 
        }
}
