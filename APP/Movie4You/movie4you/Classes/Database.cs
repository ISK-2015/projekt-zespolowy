using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Movie4You
{
    public sealed class Database
    {
        private MySqlConnection conn;
        private MySqlConnectionStringBuilder connbuild;

        private string lastexceptionmessage;
        private int lastexceptionnumber;

        //
        //USTAWIENIA WPISANE DO KODU, DLA WYGODY
        //
        

        private string _server = "serwer1585870.home.pl";
        private string _database = "18659907_0000002";
        private string _user = "18659907_0000002";
        
        public Database(string server, string database, string user, string password)
        {
            connbuild = new MySqlConnectionStringBuilder();
            connbuild.Server = server;
            connbuild.Database = database;
            connbuild.UserID = user;
            connbuild.Password = password;


            conn = new MySqlConnection(connbuild.ConnectionString);
        }
        public Database(string password)
        {
            connbuild = new MySqlConnectionStringBuilder();
            connbuild.Server = _server;
            connbuild.Database = _database;
            connbuild.UserID = _user;
            connbuild.Password = password;
            connbuild.Keepalive = 30;

            conn = new MySqlConnection(connbuild.ConnectionString);
        }
        public bool TryConnect()
        {
            bool _rt = true;
            try
            { this.Connect(); }
            catch(MySql.Data.MySqlClient.MySqlException ex)
            {
                _rt = false;
                lastexceptionmessage = ex.Message;
                lastexceptionnumber = ex.Number;
            }
            return _rt;
        }
        public void ChangePassword(string pass)
        {
            conn = null;
            connbuild.Password = pass;
            conn = new MySqlConnection(connbuild.ConnectionString);
        }

        #region INTERFACE IMPLEMENTATION
        public void Connect()
        {
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void Disconnect()
        {
            if(conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

        }
        public DataSet Select(string what, string where)
        {
            if(conn.State == ConnectionState.Open)
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT " + what + " FROM " + where;
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet data = new DataSet();
                adapter.Fill(data);
                return data;
            }
            else
            {
                return null;
            }
        }
        public DataSet Select(string what, string where, string order)
        {
            if (conn.State == ConnectionState.Open)
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT " + what + " FROM " + where + " ORDER BY " + order + " DESC";
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet data = new DataSet();
                adapter.Fill(data);
                return data;
            }
            else
            {
                return null;
            }
        }
        public void Delete()
        {

        }
        public void Update()
        {

        }
        public void Insert()
        {

        }
        #endregion


        public ConnectionState State
        {
            get
            {
                return conn.State;
            }
        }
        public string ExceptionMessage
        {
            get
            {
                return lastexceptionmessage;
            }
        }
        public int ExceptionNumber
        {
            get
            {
                return lastexceptionnumber;
            }
        }

    }
}
