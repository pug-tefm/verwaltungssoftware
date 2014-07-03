using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PuG_Verwaltungssoftware.Klassen;

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
            c_Mitarbeiter myMitarbeiter = new c_Mitarbeiter();

            // Variablendeklaration und Initialisierung
            String vorname;
            String nachname;
            String gebDatum;
            String strasse;
            String hNummer;
            String ort;
            String initBenutzer;
            String initPasswort;

            String strSQL = String.Empty;

            int plz;
            int posId = 0;
            double gehalt;


            // =====================================
            //   Ueberpruefung auf leere Textfelder
            // =====================================

            // Persoenliche Daten
            if (tbVorname.Text != "" && tbNachname.Text != "" && dtpDatum.Text != "")
            {
                vorname = tbVorname.Text;
                nachname = tbNachname.Text;
                // GebDatum umformatieren
                gebDatum = dtpDatum.Text;
                DateTime date = Convert.ToDateTime(gebDatum);
                gebDatum = date.ToString("yyyy-MM-dd");
            }
            else
            {
                MessageBox.Show("Sie haben nicht alle Persönlichen Daten angegeben.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Anschrift
            if (tbStrasse.Text != "" && tbHausnummer.Text != "" && tbOrt.Text != "" && tbPlz.Text != "")
            {
                strasse = tbStrasse.Text;
                ort = tbOrt.Text;
                if (c_Helper.wrongCharNumberExtra(tbHausnummer.Text) == false && c_Helper.numFormat(tbPlz.Text) == false)
                {
                    hNummer = tbHausnummer.Text;
                    plz = Convert.ToInt32(tbPlz.Text);
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
                gehalt = Convert.ToDouble(tbGehalt.Text);
                if (c_Helper.numFormatPunktKomma(gehalt.ToString()) == true)
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
                initBenutzer = tbInitUser.Text;
                initPasswort = tbInitPasswort.Text;
                if (initBenutzer.Length < 3 || initPasswort.Length < 8)
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
                        posId = arrPosId[i];
                    }
                }
            }
            else
            {
                MessageBox.Show("Login-Daten ausfüllen.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }



            myMitarbeiter.setVorname(vorname);
            myMitarbeiter.setNachname(nachname);
            myMitarbeiter.setGebDatum(gebDatum);
            myMitarbeiter.setStrasse(strasse);
            myMitarbeiter.setOrt(ort);
            myMitarbeiter.setHausnummer(hNummer);
            myMitarbeiter.setPlz(plz);
            myMitarbeiter.setGehalt(gehalt);
            myMitarbeiter.setBenutzername(initBenutzer);
            myMitarbeiter.setPasswort(initPasswort);
            myMitarbeiter.setPositionId(posId);



            // =====================================
            //     Daten in Datenbank schreiben
            // ===================================== 

            int dBConnectOk = c.openConnection();
            if (dBConnectOk == 0)
            {
                strSQL = "INSERT INTO mitarbeiter (position_id, benutzername, passwort, vorname, nachname, geburtsdatum, strasse, hausnummer, plz, ort, gehalt)" +
                    "VALUES ('" + posId + "', '" + initBenutzer + "', '" + c_Helper.encrypt(initPasswort) + "' , '" + vorname + "', '" + nachname + "', '" + gebDatum + "', '" + strasse + "', '" + hNummer + "', '" + plz + "', '" + ort + "', '" + (gehalt.ToString()).Replace(",",".") + "');";
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
