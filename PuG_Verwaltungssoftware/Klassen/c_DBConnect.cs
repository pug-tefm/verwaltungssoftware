using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace PuG_Verwaltungssoftware
{
    public class c_DBConnect
    {
        private MySqlConnection connection;
        private string server = "managed-5.7thserver.de";
        private string database = "c3_erik_schule";
        private string username = "c3_erik_schule";
        private string password = "t0xVxFCNtCRfOTmnShgwdqvq1mn9fPX7";

        // Konstruktor
        public c_DBConnect()
        {
            initialize();
        }

        private void initialize()
        {
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
        public bool closeConnection()
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
                
                MessageBox.Show(textMB + " wurde hinzugefügt", "Information", MessageBoxButtons.OK); // MSG bei success
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

                MessageBox.Show(textMB + "wurde upgedated", "Information", MessageBoxButtons.OK); // MSG bei success
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

                MessageBox.Show(textMB + " wurde gelöscht", "Information", MessageBoxButtons.OK); // MSG bei success
            }
            catch (Exception ex) // Fehler
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Select statement
        public DataTable select(String query)
        {
            MySqlCommand myCommand = new MySqlCommand(query, connection);
            MySqlDataAdapter myAdapter = new MySqlDataAdapter();

            myAdapter.SelectCommand = myCommand;
            DataTable dTable = new DataTable();
            myAdapter.Fill(dTable);

            if (dTable.Rows.Count >= 1)
            {
                return dTable;
            }
            else
            {
                return null;
            }
        }



        public void displayData(string query, DataGridView dataGridView) // SELECT
        {
            try
            {
                MySqlCommand myCommand = new MySqlCommand(query, connection);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter();

                myAdapter.SelectCommand = myCommand;
                DataTable dTable = new DataTable();
                myAdapter.Fill(dTable);
                dataGridView.DataSource = dTable;
            }
            catch (Exception ex) // Fehler
            {
                MessageBox.Show(ex.Message);
            }
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

        public int countRows(String query)
        {
            try
            {
                MySqlCommand myCommand = new MySqlCommand(query, connection);
                return Convert.ToInt32(myCommand.ExecuteScalar());
            }
            catch (Exception ex) // Fehler
            {
                MessageBox.Show(ex.Message);
                return -1;
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
