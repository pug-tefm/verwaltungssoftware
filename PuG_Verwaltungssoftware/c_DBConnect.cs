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
        private string userID;
        private string password;

        // Konstruktor
        public c_DBConnect()
        {
            initialize();
        }

        private void initialize()
        {
            server = "EriksServer";
            database = "PuG_Verwaltung";
            userID = "userID";
            password = "password";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + userID + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        // Verbindung zur Datenbank herstellen
        private bool openConnection()
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
        public void insert()
        {
        }

        //Update statement
        public void update()
        {
        }

        //Delete statement
        public void delete()
        {
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
