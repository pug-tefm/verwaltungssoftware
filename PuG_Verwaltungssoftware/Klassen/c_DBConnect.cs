using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace PuG_Verwaltungssoftware
{
    class c_DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string username;
        private string password;

        // Konstruktor
        public c_DBConnect()
        {
            initialize();
        }

        private void initialize()
        {
            server = "localhost";
            database = "pug_software";
            username = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        // Verbindung zur Datenbank herstellen
        public int openConnection()
        {
            try
            {
                connection.Open();
                return 0;
            }
            catch (MySqlException ex)
            {
                return 1;
            }
        }

        // Datenbankverbindung schliessen
        private bool closeConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement
        public void insert(string query, string textMB)
        {
            try
            {
                MySqlCommand myCommand = new MySqlCommand(query, connection);
                MySqlDataReader myReader;

                myReader = myCommand.ExecuteReader(); // Command ausführen

                MessageBox.Show(textMB, " wurde hinzugefügt"); // MSG bei success
            }
            catch (Exception ex) // Fehler
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Update statement
        public void update(string query, string textMB)
        {
            try
            {
                MySqlCommand myCommand = new MySqlCommand(query, connection);
                MySqlDataReader myReader;

                myReader = myCommand.ExecuteReader(); // Command ausführen

                MessageBox.Show(textMB + "wurde upgedated"); // MSG bei success
            }
            catch (Exception ex) // Fehler
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Delete statement
        public void delete(string query, string textMB)
        {
            try
            {
                MySqlCommand myCommand = new MySqlCommand(query, connection);
                MySqlDataReader myReader;

                myReader = myCommand.ExecuteReader(); // Command ausführen

                MessageBox.Show(textMB + " wurde gelöscht"); // MSG bei success
            }
            catch (Exception ex) // Fehler
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Select statement
        public List<string>[] select()
        {
            List<string>[] list = new List<string>[3];
            return list;
        }

        //Count statement
        public bool count(String query)
        {
            try
            {
                MySqlCommand myCommand = new MySqlCommand(query, connection);
                MySqlDataReader myReader;

                myReader = myCommand.ExecuteReader(); // Command ausführen
                bool count = myReader.HasRows;

                return count;
            }
            catch (Exception ex) // Fehler
            {
                //MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Backup
        public void backup()
        {
        }

        //Restore
        public void restore()
        {
        }

    }
}
