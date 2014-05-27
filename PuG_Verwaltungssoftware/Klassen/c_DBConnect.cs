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
            server = "rdbms.strato.de";
            database = "DB1704156";
            username = "U1704156";
            password = "pugtefm2014";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        // Verbindung zur Datenbank herstellen
        public bool openConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                // Die zwei haeufigsten Error-Codes:
                // 0: Cannot connect to server.
                // 1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Verbindung zum Server fehlgeschlagen.\r\nBitte Administrator kontaktieren.");
                        break;
                    case 1045:
                        MessageBox.Show("Falscher Benutzername oder Passwort. Bitte erneut versuchen.");
                        break;
                    default:
                        MessageBox.Show("Fehler: " + ex.Message);
                        break;
                }
                return false;
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
        public int count()
        {
            int count = -1;
            return count;
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
