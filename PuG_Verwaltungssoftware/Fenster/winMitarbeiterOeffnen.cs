﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuG_Verwaltungssoftware
{
    public partial class winMitarbeiterOeffnen : Form
    {
        bool editMode = false;
        bool save = false;
        int gId = 0;

        public winMitarbeiterOeffnen(int id)
        {
            InitializeComponent();
            
            // ID festlegen
            gId = id;

        }

        private void winMitarbeiterOeffnen_Load(object sender, EventArgs e)
        {
            // DateTimePicker unsichtbar machen
            dtpDatum.Visible = false;

            // Variablendeklaration
            String vorname = String.Empty;
            String nachname = String.Empty;
            String gebDatum = String.Empty;
            String strasse = String.Empty;
            String hausnummer = String.Empty;
            String plz = String.Empty;
            String ort = String.Empty;
            String gehalt = String.Empty;
            String benutzername = String.Empty;
            String position = String.Empty;

            // Mitarbeiter-Daten abrufen
            c_DBConnect c = new c_DBConnect();
            int dbConnectOk = c.openConnection();
            if (dbConnectOk == 0)
            {
                DataTable result = c.select("SELECT * FROM mitarbeiter WHERE mitarbeiter_id = '" + gId + "'");
                if (result != null)
                {
                    vorname = (String)result.Rows[0]["vorname"];
                    nachname = (String)result.Rows[0]["nachname"];
                    //gebDatum = (String)result.Rows[0]["geburtsdatum"];
                    strasse = (String)result.Rows[0]["strasse"];
                    hausnummer = (String)result.Rows[0]["hausnummer"];
                    //plz = (String)result.Rows[0]["plz"];
                    ort = (String)result.Rows[0]["ort"];
                    //gehalt = (String)result.Rows[0]["gehalt"];
                    benutzername = (String)result.Rows[0]["benutzername"];
                    //position = (String)result.Rows[0]["position"];

                    tbVorname.Text = vorname;
                    tbNachname.Text = nachname;
                    //tbDatum.Text = gebDatum;
                    tbStrasse.Text = strasse;
                    tbHausnummer.Text = hausnummer;
                    //tbPlz.Text = plz;
                    tbOrt.Text = ort;
                    //tbGehalt.Text = gehalt;
                    tbBenutzername.Text = benutzername;
                    //tbPosition.Text = position;
                    
                }
            }
        }

        private void btSchliessen_Click(object sender, EventArgs e)
        {
            // Fenster schliessen
            if (editMode == true)
            {
                // MessageBox schliessen ohne speichern
                // ######## unvollständig ##########
                DialogResult dialogResult = MessageBox.Show("Wollen Sie das Fenster ohne zu Speichern schließen?", "Information", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {

                }
            }
            else
            {
                this.Close();
            }
            
        }

        private void btBearbeiten_Click(object sender, EventArgs e)
        {
            // Globale Variable true setzen
            editMode = true;
            
            // Textboxen readOnly --> false
            foreach (Control c in gbDaten.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    ((TextBox)c).ReadOnly = false;
                }
            }
            foreach (Control c in gbAnschrift.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    ((TextBox)c).ReadOnly = false;
                }
            }
            foreach (Control c in gbGehalt.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    ((TextBox)c).ReadOnly = false;
                }
            }
            foreach (Control c in gbLoginDaten.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    ((TextBox)c).ReadOnly = false;
                }
            }

            // Textbox Datum visible false und datepicker visible true und Position setzen
            int xVal = tbDatum.Location.X;
            int yVal = tbDatum.Location.Y;

            dtpDatum.Visible = true;
            tbDatum.Visible = false;
            //dtpDatum.Location.X = xVal;
            //dtpDatum.Location.Y = yVal;
        }

        private void btSpeichern_Click(object sender, EventArgs e)
        {
            // Globale Variable true setzen
            save = true;
        }

    }
}
