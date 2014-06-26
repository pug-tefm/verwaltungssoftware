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

namespace PuG_Verwaltungssoftware
{
    public partial class winKursNeu : Form
    {
        private DataGridView  myGridKurse;
        private BindingSource myBindingSourceKurse;

        public winKursNeu(DataGridView dataGridViewKurse, BindingSource bindingSourceKurse)
        {
            InitializeComponent();

            myGridKurse          = dataGridViewKurse;
            myBindingSourceKurse = bindingSourceKurse;

            c_Mitarbeiter.comboBoxFill(cbKursleiter, "");

            gueltigerWochentagPruefen();
        }

        private void btSchliessen_Click(object sender, EventArgs e)
        {
            // Fenster schliessen
            if (tbBezeichnung.Text.Trim().Length != 0 || cbKursleiter.SelectedIndex != -1 || tbPreis.Text.Trim().Length != 0
                || tbMaxTeilnehmer.Text.Trim().Length != 0)
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
            bool fehlerGefunden = false;

            // Fehlerüberprüfung Anfang
            bool fehlerBezeichnung = c_Helper.wrongCharNumberExtra(tbBezeichnung.Text, 100);
            if (fehlerBezeichnung == true)
            {
                fehlerGefunden = true;
                MessageBox.Show("'" + tbBezeichnung.Text + "' Bitte Eingabe überprüfen", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            bool fehlerPreis = c_Helper.numFormatPunktKomma(tbPreis.Text, 6);
            if (fehlerPreis == true)
            {
                fehlerGefunden = true;
                MessageBox.Show("'" + tbPreis.Text + "' Bitte Eingabe überprüfen", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            bool fehlerMaxTeilnehmer = c_Helper.numFormat(tbMaxTeilnehmer.Text, 3);
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
                    c_DBConnect myConnection = new c_DBConnect();
                    int connected = myConnection.openConnection();
                    if (connected == 0)
                    {
                        String datumVon   = dtpDatumVon.Value.ToString("yyyy-MM-dd");
                        String datumBis   = dtpDatumBis.Value.ToString("yyyy-MM-dd");
                        String uhrzeitVon = dtpUhrzeitVon.Value.TimeOfDay.ToString().Substring(0, 5);
                        String uhrzeitBis = dtpUhrzeitBis.Value.TimeOfDay.ToString().Substring(0, 5);
                        String kursleiter = new String(cbKursleiter.Text.Where(c => Char.IsDigit(c)).ToArray());
                        String preis      = tbPreis.Text.Replace(",", ".");

                        String query = "INSERT INTO kurse (kursleiter_id, bezeichnung , preis, akt_teilnehmer, max_teilnehmer, datum_von, datum_bis, wochentag, " +
                                        "uhrzeit_von, uhrzeit_bis) VALUES (" + kursleiter + ", '" + tbBezeichnung.Text + "', " + preis + ", " + "0" + 
                                        ", " + tbMaxTeilnehmer.Text + ", '" + datumVon + "', '" + datumBis + "', " + cbWochentag.SelectedIndex + ", '" + uhrzeitVon + 
                                        "', '" + uhrzeitBis + "');";

                        bool ok = myConnection.insert(query, "Kurs");
                        if (ok == true)
                        {
                            myConnection.closeConnection();
                            int connectedZwei = myConnection.openConnection();
                            if (connectedZwei == 0)
                            {
                                myConnection.displayData("SELECT kurs_id, CONCAT('(', mitarbeiter_id,') ', vorname, ', ', nachname) " +
                                              "AS kursleiter, bezeichnung, preis, akt_teilnehmer, max_teilnehmer, datum_von, datum_bis, wochentag, uhrzeit_von, uhrzeit_bis " +
                                              "FROM kurse k, mitarbeiter m WHERE k.kursleiter_id = m.mitarbeiter_id;", myGridKurse);
                                myConnection.closeConnection();

                                // Headertexte anpassen
                                DataTable gridKurseTable = (DataTable)(myGridKurse.DataSource);
                                gridKurseTable.Columns["kurs_id"].ColumnName        = "Kurs-ID";
                                gridKurseTable.Columns["kursleiter"].ColumnName     = "Kursleiter";
                                gridKurseTable.Columns["bezeichnung"].ColumnName    = "Bezeichnung";
                                gridKurseTable.Columns["akt_teilnehmer"].ColumnName = "Akt. Teilnehmer";
                                gridKurseTable.Columns["max_teilnehmer"].ColumnName = "Max. Teilnehmer";
                                gridKurseTable.Columns["datum_von"].ColumnName      = "Datum Von";
                                gridKurseTable.Columns["datum_bis"].ColumnName      = "Datum Bis";
                                gridKurseTable.Columns["wochentag"].ColumnName      = "Wochentag";
                                gridKurseTable.Columns["uhrzeit_von"].ColumnName    = "Uhrzeit Von";
                                gridKurseTable.Columns["uhrzeit_bis"].ColumnName    = "Uhrzeit Bis";

                                c_Helper.changeColumnDataType(gridKurseTable, "Wochentag", typeof(String), 9);

                                for (int i = 0; i < gridKurseTable.Rows.Count; i++)
                                {
                                    String wert = c_Helper.umwandlungIntInWochentag(Convert.ToInt32(gridKurseTable.Rows[i]["Wochentag"]));
                                    gridKurseTable.Rows[i]["Wochentag"] = wert;
                                }

                                myBindingSourceKurse.DataSource = myGridKurse.DataSource;
                                myGridKurse.DataSource = myBindingSourceKurse;
                            }
                            else
                            {
                                MessageBox.Show("Verbindungsfehler!\nÜbersicht konnte nicht aktualisiert werden.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            DialogResult dialogResult = MessageBox.Show("Wollen Sie einen weiteren Kurs erfassen?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (dialogResult == DialogResult.Yes)
                            {
                                cbKursleiter.SelectedIndex = -1;
                                cbWochentag.SelectedIndex = -1;

                                tbBezeichnung.Text = "";
                                tbPreis.Text = "";
                                tbMaxTeilnehmer.Text = "";

                                DateTime today = DateTime.Now;
                                dtpDatumVon.Value = today.Date;
                                dtpDatumBis.Value = today.Date;
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
                    else
                    {
                        MessageBox.Show("Datenbankverbindung konnte nicht hergestellt werden.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Bitte füllen Sie alle Felder aus.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void gueltigerWochentagPruefen()
        {
            cbWochentag.Items.Clear();

            // Nur gültige Wochentag auswählbar machen
            TimeSpan myTimeSpan = dtpDatumBis.Value.Date - dtpDatumVon.Value.Date;
            if (myTimeSpan.Days < 7)
            {
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
            else
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

        private void dtpDatumVon_ValueChanged(object sender, EventArgs e)
        {
            gueltigerWochentagPruefen();
        }

        private void dtpDatumBis_ValueChanged(object sender, EventArgs e)
        {
            gueltigerWochentagPruefen();
        }
    }
}
