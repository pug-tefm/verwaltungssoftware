﻿using System;
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

        // Florian
        private void initialize()
        {
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        // Florian
        // Verbindung zur Datenbank herstellen
        public int openConnection()
        {
            if (connection != null && connection.State == ConnectionState.Closed)
            {
                try
                {
                    connection.Open();
                    return 0;
                }
                catch (MySqlException)
                {
                    return 1;
                }
            }
            else if (connection != null && connection.State == ConnectionState.Open)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        // Florian
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

        // Tim
        //Insert statement
        public bool insert(string query, string textMB, int fehlerAus = 0)
        {
            try
            {
                MySqlCommand myCommand = new MySqlCommand(query, connection);
                MySqlDataReader myReader;

                myReader = myCommand.ExecuteReader(); // Command ausführen
                
                if(textMB.Trim().Length != 0) MessageBox.Show(textMB + " wurde hinzugefügt", "Information", MessageBoxButtons.OK); // MSG bei success
                return true;
            }
            catch (Exception ex) // Fehler
            {
                if (fehlerAus == 0)
                {
                    MessageBox.Show(ex.Message);
                }
                return false;
            }
        }

        // Tim
        //Update statement
        public bool update(string query, string textMB, int fehlerAus = 0)
        {
            try
            {
                MySqlCommand myCommand = new MySqlCommand(query, connection);
                MySqlDataReader myReader;

                myReader = myCommand.ExecuteReader(); // Command ausführen

                if (textMB.Trim().Length != 0) MessageBox.Show(textMB + " wurde geändert", "Information", MessageBoxButtons.OK); // MSG bei success
                return true;
            }
            catch (Exception ex) // Fehler
            {
                if (fehlerAus == 0)
                {
                    MessageBox.Show(ex.Message);
                }
                return false;
            }
        }

        // Tim
        //Delete statement
        public bool delete(string query, string textMB, int fehlerAus = 0)
        {
            try
            {
                MySqlCommand myCommand = new MySqlCommand(query, connection);
                MySqlDataReader myReader;

                myReader = myCommand.ExecuteReader(); // Command ausführen

                if (textMB.Trim().Length != 0) MessageBox.Show(textMB + " wurde gelöscht", "Information", MessageBoxButtons.OK); // MSG bei success
                return true;
            }
            catch (Exception ex) // Fehler
            {
                if (fehlerAus == 0)
                {
                    MessageBox.Show(ex.Message);
                }
                return false;
            }
        }

        // Flo und Erik
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

        // Tim
        public bool displayData(string query, DataGridView dataGridView, int fehlerAus = 0) // SELECT
        {
            try
            {
                MySqlCommand myCommand = new MySqlCommand(query, connection);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter();

                myAdapter.SelectCommand = myCommand;
                DataTable dTable = new DataTable();
                myAdapter.Fill(dTable);
                dataGridView.DataSource = dTable;
                return true;
            }
            catch (Exception ex) // Fehler
            {
                if (fehlerAus == 0)
                {
                    MessageBox.Show(ex.Message);
                }
                return false;
            }
        }

        // Florian
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
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        // Tim
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
