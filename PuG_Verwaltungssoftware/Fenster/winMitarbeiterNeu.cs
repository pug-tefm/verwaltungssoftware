﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PuG_Verwaltungssoftware.Klassen;

// Florian
namespace PuG_Verwaltungssoftware
{
    public partial class winMitarbeiterNeu : Form
    {
        /*
         * ******************************
         *     Variablendeklarationen
         * ******************************
         * */
        int gLoginPosId = 0;   // Mitarbeiter-Nr. des angemeldeten Users
        int gLoginMaId = 0;   // Mitarbeiter-Nr. des angemeldeten Users

        c_DBConnect c = new c_DBConnect();
        DataGridView gGridView;


        public winMitarbeiterNeu(int loginId, int loginPosId, DataGridView grid)
        {
            InitializeComponent();

            // ToolTips generieren
            c_Helper.setToolTip(btSpeichern, "Speichern");
            c_Helper.setToolTip(btSchliessen, "Schließen");

            // ID festlegen
            gLoginMaId = loginId;
            gLoginPosId = loginPosId;

            // GridView zuweisen
            gGridView = grid;

        }


        /*
         * ******************************
         *         Control Events
         * ******************************
         * */

        private void winMitarbeiterNeu_Load(object sender, EventArgs e)
        {

            // =====================================
            //     Combobox mit Werten befuellen
            // =====================================

            string bezeichnung = "";
            int pos = 0;

            int dBConnectOk = c.openConnection();
            if (dBConnectOk == 0)
            {
                int rows = c.countRows("SELECT COUNT(*) FROM positionen;");
                if (rows > 0)
                {
                    DataTable result = c.select("SELECT pos_id, bezeichnung FROM positionen;");
                    if (result != null)
                    {
                        for (int i = 0; i < rows; i++)
                        {
                            bezeichnung = (String)result.Rows[i]["bezeichnung"];
                            ddlPosition.Items.Add(bezeichnung);
                        }
                    }
                }
                c.closeConnection();
            }

            // Combobox preselected Item
            for (int i = 0; i < ddlPosition.Items.Count; i++)
            {
                if (ddlPosition.Items[i].ToString() == "Normal")
                {
                    pos = i;
                }
            }
            ddlPosition.SelectedIndex = pos;

        }

        private void btSchliessen_Click(object sender, EventArgs e)
        {
            // Fenster schliessen
            if (tbVorname.Text.Trim().Length != 0 || tbNachname.Text.Trim().Length != 0 || tbStrasse.Text.Trim().Length != 0 || tbHausnummer.Text.Trim().Length != 0
                || tbOrt.Text.Trim().Length != 0 || tbPlz.Text.Trim().Length != 0 || tbGehalt.Text.Trim().Length != 0 || tbInitUser.Text.Trim().Length != 0 || tbInitPasswort.Text.Trim().Length != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Wollen Sie das Fenster ohne zu Speichern schließen?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btSpeichern_Click(object sender, EventArgs e)
        {

            // Neues Mitarbeiter Objekt anlegen
            c_Mitarbeiter neuerMitarbeiter = new c_Mitarbeiter();

            // Variablendeklaration und Initialisierung
            String strSQL = String.Empty;


            // =====================================
            //   Ueberpruefung auf leere Textfelder
            // =====================================

            // Persoenliche Daten
            if (tbVorname.Text != "" && tbNachname.Text != "" && dtpDatum.Text != "")
            {
                neuerMitarbeiter.setVorname(tbVorname.Text);
                neuerMitarbeiter.setNachname(tbNachname.Text);
                // GebDatum umformatieren
                neuerMitarbeiter.setGebDatum(dtpDatum.Text);
                DateTime date = Convert.ToDateTime(neuerMitarbeiter.getGebDatum());
                neuerMitarbeiter.setGebDatum(date.ToString("yyyy-MM-dd"));
            }
            else
            {
                MessageBox.Show("Sie haben nicht alle Persönlichen Daten angegeben.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Anschrift
            if (tbStrasse.Text != "" && tbHausnummer.Text != "" && tbOrt.Text != "" && tbPlz.Text != "")
            {
                neuerMitarbeiter.setStrasse(tbStrasse.Text);
                neuerMitarbeiter.setOrt(tbOrt.Text);
                if (c_Helper.wrongCharNumberExtra(tbHausnummer.Text) == false && c_Helper.numFormat(tbPlz.Text) == false)
                {
                    neuerMitarbeiter.setHausnummer(tbHausnummer.Text);
                    neuerMitarbeiter.setPlz(Convert.ToInt32(tbPlz.Text));
                }
                else
                {
                    MessageBox.Show("Falsches Format für die Felder Hausnummer und Postleitzahl.\nIm Feld Postleitzahl dürfen nur Zahlen stehen.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Sie haben nicht alle Anschrift-Daten angegeben.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Gehalt
            if (tbGehalt.Text != "")
            {
                neuerMitarbeiter.setGehalt(Convert.ToDouble(tbGehalt.Text));
                if (c_Helper.numFormatPunktKomma(tbGehalt.Text) == true)
                {
                    MessageBox.Show("Falsches Format für das Feld Gehalt.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Bitte Feld Gehalt ausfüllen.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Login - Daten
            if (tbInitUser.Text != "" && tbInitPasswort.Text != "")
            {
                neuerMitarbeiter.setBenutzername(tbInitUser.Text);
                neuerMitarbeiter.setPasswort(tbInitPasswort.Text);
                if (neuerMitarbeiter.getBenutzername().Length < 3 || neuerMitarbeiter.getPasswort().Length < 8)
                {
                    MessageBox.Show("Mindeslänge Benutzername: 3 Zeichen.\nMindestlänge Passwort: 8 Zeichen.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Ueberpruefen welche Position ausgewaehlt wurde
                int dbConnectOk = c.openConnection();
                DataTable result2 = c.select("SELECT * FROM positionen;");
                c.closeConnection();

                int[] arrPosId = new int[result2.Rows.Count];
                string[] arrPosBez = new string[result2.Rows.Count];

                if (dbConnectOk == 0)
                {

                    if (result2 != null)
                    {
                        for (int i = 0; i < result2.Rows.Count; i++)
                        {
                            arrPosId[i] = Convert.ToInt32(result2.Rows[i]["pos_id"]);
                            arrPosBez[i] = (result2.Rows[i]["bezeichnung"]).ToString();
                        }
                    }
                }

                for (int i = 0; i < arrPosId.Length; i++)
                {
                    if (ddlPosition.SelectedItem.ToString().Equals((arrPosBez[i]).ToString()))
                    {
                        neuerMitarbeiter.setPositionId(arrPosId[i]);
                    }
                }
            }
            else
            {
                MessageBox.Show("Login-Daten ausfüllen.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            // =====================================
            //     Daten in Datenbank schreiben
            // ===================================== 

            int dBConnectOk = c.openConnection();
            if (dBConnectOk == 0)
            {
                strSQL = "INSERT INTO mitarbeiter (position_id, benutzername, passwort, vorname, nachname, geburtsdatum, strasse, hausnummer, plz, ort, gehalt)" +
                    "VALUES ('" + neuerMitarbeiter.getPositionId() + "', '" + neuerMitarbeiter.getBenutzername() + "', '" + c_Helper.encrypt(neuerMitarbeiter.getPasswort()) + "' , '" + neuerMitarbeiter.getVorname() + "', '" + neuerMitarbeiter.getNachname() + "', '" + neuerMitarbeiter.getGebDatum() + "', '" + neuerMitarbeiter.getStrasse() + "', '" + neuerMitarbeiter.getHausnummer() + "', '" + neuerMitarbeiter.getPlz() + "', '" + neuerMitarbeiter.getOrt() + "', '" + (neuerMitarbeiter.getGehalt().ToString()).Replace(",",".") + "');";
                c.insert(strSQL, "Mitarbeiter");
                c.closeConnection();
                gridMitarbeiterAktualisieren();

                this.Close();  // Fenster schliessen
            }

        }


        /*
         * ******************************
         *        Eigene Methoden
         * ******************************
         * */

        private void gridMitarbeiterAktualisieren()
        {
            if (gLoginPosId == 1)
            {
                c.displayData("SELECT mitarbeiter_id, vorname, nachname, geburtsdatum FROM mitarbeiter;", gGridView);
            }
            else
            {
                c.displayData("SELECT mitarbeiter_id, vorname, nachname, geburtsdatum FROM mitarbeiter WHERE mitarbeiter_id = '" + gLoginMaId + "';", gGridView);
            }
        }

    }
}
