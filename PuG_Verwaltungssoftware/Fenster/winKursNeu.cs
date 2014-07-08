using PuG_Verwaltungssoftware.Klassen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Tim
namespace PuG_Verwaltungssoftware
{
    public partial class winKursNeu : Form
    {
        // Klassenvariablen deklarieren
        private DataGridView  myGridKurse;
        private BindingSource myBindingSourceKurse;

        public winKursNeu(DataGridView dataGridViewKurse, BindingSource bindingSourceKurse)
        {
            InitializeComponent();

            // ToolTips generieren
            c_Helper.setToolTip(btSpeichern, "Speichern");
            c_Helper.setToolTip(btSchliessen, "Schließen");

            // Klassenvariablen initialisieren
            myGridKurse          = dataGridViewKurse;
            myBindingSourceKurse = bindingSourceKurse;

            dtpUhrzeitBis.Value = dtpUhrzeitBis.Value.AddHours(+1); // Stunde um 1 erhöhen

            c_Mitarbeiter.comboBoxFill(cbKursleiter, ""); // ComboBox mit den Mitarbeitern befüllen

            gueltigerWochentagPruefen();
        }

        /**************************************************************************/
        /* private void btSchliessen_Click(object sender, EventArgs e)            */
        /**************************************************************************/
        /* Form schliesen. Die Funktion                                           */
        /* winKursOeffnen_FormClosing(object sender, FormClosingEventArgs e)      */
        /* wird dadurch indirekt ausgerufen.                                      */
        /**************************************************************************/
        private void btSchliessen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /******************************************************************************/
        /* private void winKursNeu_FormClosing(object sender, FormClosingEventArgs e) */
        /******************************************************************************/
        /* Wenn das Fenster geschlossen wird, wird überprüft ob es Eingaben gab.      */
        /* Wenn dies der Fall war wird eine MessageBox ausgegeben sonst das           */
        /* Fenster geschlossen.                                                       */
        /******************************************************************************/
        private void winKursNeu_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Sind Felder ausgefüllt worden ?
            if (tbBezeichnung.Text.Trim().Length != 0 || cbKursleiter.SelectedIndex != -1 || tbPreis.Text.Trim().Length != 0
                || tbMaxTeilnehmer.Text.Trim().Length != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Wollen Sie das Fenster ohne zu Speichern schließen?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        /**************************************************************************/
        /* private void btSpeichern_Click(object sender, EventArgs e)             */
        /**************************************************************************/
        /* Wenn der Button speichern gedrückt wurde werden alle Felder auf ihr    */
        /* korrektes Format überprüft. Bei einem falschen Format wird ein Fehler  */
        /* ausgegeben und die Eingabe wird nicht gespeichert. Wenn keine Fehler   */
        /* vorhanden, wird das Von und Bis Datum an den Wochentag angepasst. Dann */
        /* werden die Daten für SQL Formatiert und der INSERT Befehl wird         */
        /* abgeschickt.  Dannach wird das gridView aktualisiert und man wird      */
        /* gefragt ob man einen weiteren Kurs erfassen möchte.                    */
        /**************************************************************************/
        private void btSpeichern_Click(object sender, EventArgs e)
        {
            bool fehlerGefunden = false;

            // Fehlerüberprüfung Anfang
            bool fehlerBezeichnung = c_Helper.wrongCharNumberExtra(tbBezeichnung.Text /*, 100*/);
            if (fehlerBezeichnung == true)
            {
                fehlerGefunden = true;
                MessageBox.Show("'" + tbBezeichnung.Text + "' Bitte Eingabe überprüfen", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            bool fehlerPreis = c_Helper.numFormatPunktKomma(tbPreis.Text /*, 6*/);
            if (fehlerPreis == true)
            {
                fehlerGefunden = true;
                MessageBox.Show("'" + tbPreis.Text + "' Bitte Eingabe überprüfen", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            bool fehlerMaxTeilnehmer = c_Helper.numFormat(tbMaxTeilnehmer.Text /*, 3*/);
            if (fehlerMaxTeilnehmer == true)
            {
                fehlerGefunden = true;
                MessageBox.Show("'" + tbMaxTeilnehmer.Text + "' Bitte Eingabe überprüfen", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (dtpDatumVon.Value.Date > dtpDatumBis.Value.Date)
            {
                fehlerGefunden = true;
                MessageBox.Show("Von Datum kann nicht größer als Bis Datum sein", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (dtpUhrzeitVon.Value.TimeOfDay > dtpUhrzeitBis.Value.TimeOfDay)
            {
                fehlerGefunden = true;
                MessageBox.Show("Von Uhrzeit kann nicht größer als Bis Uhrzeit sein", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Fehlerüberprüfung Ende

            if (fehlerGefunden == true)
            {
                MessageBox.Show("Datensatz wurde nicht gespeichert", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (tbBezeichnung.Text.Trim().Length != 0 || cbKursleiter.SelectedIndex != -1 || tbPreis.Text.Trim().Length != 0
                    || tbMaxTeilnehmer.Text.Trim().Length != 0 || cbWochentag.SelectedIndex != -1)
                {
                    // Anfang Datum Von und Bis an Wochentag anpassen
                    DateTime myDateTimeVon = dtpDatumVon.Value.Date;
                    DateTime myDateTimeBis = dtpDatumBis.Value.Date;
                    String wochentag = c_Helper.umwandlungWochentagGerToEng(cbWochentag.Text);

                    while (dtpDatumVon.Value.DayOfWeek.ToString() != wochentag)
                    {
                        myDateTimeVon = myDateTimeVon.AddDays(+1);
                        if (myDateTimeVon.DayOfWeek.ToString() == wochentag)
                        {
                            dtpDatumVon.Value = myDateTimeVon.Date;
                            break;
                        }
                    }

                    while (dtpDatumBis.Value.DayOfWeek.ToString() != wochentag)
                    {
                        myDateTimeBis = myDateTimeBis.AddDays(-1);
                        if (myDateTimeBis.DayOfWeek.ToString() == wochentag)
                        {
                            dtpDatumBis.Value = myDateTimeBis.Date;
                            break;
                        }
                    }
                    cbWochentag.Text = c_Helper.umwandlungWochentagEngToGer(wochentag);

                    // Ende Datum Von und Bis an Wochentag anpassen

                    c_DBConnect myConnection = new c_DBConnect();
                    int connected = myConnection.openConnection();
                    if (connected == 0) // Kein Fehler Connect
                    {
                        // Format für SQL anpassen
                        String datumVon     = dtpDatumVon.Value.ToString("yyyy-MM-dd");
                        String datumBis     = dtpDatumBis.Value.ToString("yyyy-MM-dd");
                        String uhrzeitVon   = dtpUhrzeitVon.Value.TimeOfDay.ToString().Substring(0, 5);
                        String uhrzeitBis   = dtpUhrzeitBis.Value.TimeOfDay.ToString().Substring(0, 5);
                        String kursleiter   = new String(cbKursleiter.Text.Where(c => Char.IsDigit(c)).ToArray());
                        String preis        = tbPreis.Text.Replace(",", ".");
                        String intWochentag = c_Helper.umwandlungWochentagInInt(c_Helper.umwandlungWochentagEngToGer(wochentag)).ToString();
                        
                        // Abfrage String generieren
                        String query = "INSERT INTO kurse (kursleiter_id, bezeichnung , preis, akt_teilnehmer, max_teilnehmer, datum_von, datum_bis, wochentag, " +
                                        "uhrzeit_von, uhrzeit_bis) VALUES (" + kursleiter + ", '" + tbBezeichnung.Text + "', " + preis + ", " + "0" +
                                        ", " + tbMaxTeilnehmer.Text + ", '" + datumVon + "', '" + datumBis + "', " + intWochentag + ", '" + uhrzeitVon + 
                                        "', '" + uhrzeitBis + "');";

                        bool ok = myConnection.insert(query, "Kurs"); // SQL Befehl ausführen
                        if (ok == true) // Kein Fehler
                        {
                            myConnection.closeConnection();
                            int connectedZwei = myConnection.openConnection();
                            if (connectedZwei == 0) // Kein Fehler Connect
                            {
                                // DridView aktualisieren
                                myConnection.displayData("SELECT kurs_id, CONCAT('(', mitarbeiter_id,') ', vorname, ', ', nachname) " +
                                              "AS Kursleiter, bezeichnung, preis, akt_teilnehmer, max_teilnehmer, datum_von, datum_bis, wochentag, uhrzeit_von, uhrzeit_bis " +
                                              "FROM kurse k, mitarbeiter m WHERE k.kursleiter_id = m.mitarbeiter_id;", myGridKurse);
                                myConnection.closeConnection();

                                // Headertexte anpassen
                                DataTable gridKurseTable = (DataTable)(myGridKurse.DataSource);
                                gridKurseTable.Columns["kurs_id"].ColumnName        = "Kurs-ID";
                                gridKurseTable.Columns["bezeichnung"].ColumnName    = "Bezeichnung";
                                gridKurseTable.Columns["preis"].ColumnName          = "Preis";
                                gridKurseTable.Columns["akt_teilnehmer"].ColumnName = "Akt. Teilnehmer";
                                gridKurseTable.Columns["max_teilnehmer"].ColumnName = "Max. Teilnehmer";
                                gridKurseTable.Columns["datum_von"].ColumnName      = "Datum Von";
                                gridKurseTable.Columns["datum_bis"].ColumnName      = "Datum Bis";
                                gridKurseTable.Columns["wochentag"].ColumnName      = "Wochentag";
                                gridKurseTable.Columns["uhrzeit_von"].ColumnName    = "Uhrzeit Von";
                                gridKurseTable.Columns["uhrzeit_bis"].ColumnName    = "Uhrzeit Bis";

                                c_Helper.changeColumnDataType(gridKurseTable, "Wochentag", typeof(String)); // Type von Wochentag ändern (int to string)
                                myGridKurse.Columns["Wochentag"].DisplayIndex = 8;

                                for (int i = 0; i < gridKurseTable.Rows.Count; i++)
                                {
                                    String wert = c_Helper.umwandlungIntInWochentag(Convert.ToInt32(gridKurseTable.Rows[i]["Wochentag"]));
                                    gridKurseTable.Rows[i]["Wochentag"] = wert;
                                }

                                // Aktualisierten Inhalt binden (für die Suche)
                                myBindingSourceKurse.DataSource = myGridKurse.DataSource;
                                myGridKurse.DataSource = myBindingSourceKurse;
                            }
                            else // Fehler Connect
                            {
                                MessageBox.Show("Verbindungsfehler!\nÜbersicht konnte nicht aktualisiert werden.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            DialogResult dialogResult = MessageBox.Show("Wollen Sie einen weiteren Kurs erfassen?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (dialogResult == DialogResult.Yes)
                            {
                                // Werte auf default setzen
                                cbKursleiter.SelectedIndex = -1;
                                cbWochentag.SelectedIndex  = -1;

                                tbBezeichnung.Text   = "";
                                tbPreis.Text         = "";
                                tbMaxTeilnehmer.Text = "";

                                DateTime today      = DateTime.Now;
                                dtpDatumVon.Value   = today.Date;
                                dtpDatumBis.Value   = today.Date;
                                dtpUhrzeitVon.Value = DateTime.Parse(today.TimeOfDay.ToString());
                                dtpUhrzeitBis.Value = DateTime.Parse(today.TimeOfDay.ToString());
                            }
                            if (dialogResult == DialogResult.No)
                            {
                                this.Close();
                            }
                        }
                        myConnection.closeConnection();
                    }
                    else // Fehler Connect
                    {
                        MessageBox.Show("Datenbankverbindung konnte nicht hergestellt werden.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                else // Fehler leere Eingabe
                {
                    DialogResult dialogResult = MessageBox.Show("Bitte füllen Sie alle Felder aus.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /**************************************************************************/
        /* private void gueltigerWochentagPruefen()                               */
        /**************************************************************************/
        /* Es wird geprüft ob der ausgewählte Wochentag in dem eingebenen Von     */
        /* und Bis Datum überhaupt möglich ist. Diese Überprüfeung ist natürlich  */
        /* nur bei einem Datumsunterschied kleiner 7 Tage notwendig, sonst werden */
        /*  alle Wochentag zur Auswahl angeboten.                                 */
        /**************************************************************************/
        private void gueltigerWochentagPruefen()
        {
            cbWochentag.Items.Clear();

            // Nur gültige Wochentag auswählbar machen
            TimeSpan myTimeSpan = dtpDatumBis.Value.Date - dtpDatumVon.Value.Date;
            if (myTimeSpan.Days < 7) // Wenn kleiner 7 Tage
            {
                // Nur die möglichen Wochentag anzeigen 
                cbWochentag.Items.Clear();
                DateTime myDateTime = dtpDatumVon.Value.Date;
                while (myDateTime.Date <= dtpDatumBis.Value.Date)
                {
                    String myString = c_Helper.umwandlungWochentagEngToGer(myDateTime.DayOfWeek.ToString());
                    cbWochentag.Items.Add(myString);
                    myDateTime = myDateTime.AddDays(+1);
                }

                if (cbWochentag.Items.Count != 0)
                {
                    cbWochentag.SelectedIndex = 0;
                }
            }
            else // sonst alle anzeigen
            {
                cbWochentag.Items.Add("Montag");
                cbWochentag.Items.Add("Dienstag");
                cbWochentag.Items.Add("Mittwoch");
                cbWochentag.Items.Add("Donnerstag");
                cbWochentag.Items.Add("Freitag");
                cbWochentag.Items.Add("Samstag");
                cbWochentag.Items.Add("Sonntag");
            }
        }

        /**************************************************************************/
        /* private void dtpDatumVon_ValueChanged(object sender, EventArgs e)      */
        /**************************************************************************/
        /* Methode aufrufen, die prüft ob der ausgewählte Wochentag in dem        */
        /* eingebenen Von und Bis Datum überhaupt möglich ist.                    */
        /**************************************************************************/
        private void dtpDatumVon_ValueChanged(object sender, EventArgs e)
        {
            gueltigerWochentagPruefen();
        }

        /**************************************************************************/
        /* private void dtpDatumBis_ValueChanged(object sender, EventArgs e)      */
        /**************************************************************************/
        /* Methode aufrufen, die prüft ob der ausgewählte Wochentag in dem        */
        /* eingebenen Von und Bis Datum überhaupt möglich ist.                    */
        /**************************************************************************/
        private void dtpDatumBis_ValueChanged(object sender, EventArgs e)
        {
            gueltigerWochentagPruefen();
        }
    }
}
