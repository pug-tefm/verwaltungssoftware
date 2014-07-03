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

namespace PuG_Verwaltungssoftware.Fenster
{      
    public partial class winKursUebersicht : Form
    {   
        private c_Kurse gmyKurs;
        private c_DBConnect c = new c_DBConnect();
        private DataGridView g;

        public winKursUebersicht(c_Kurse myKurs, DataGridView gridKursUebersicht)
        {
            InitializeComponent();

            gmyKurs = myKurs;
            g = gridKursUebersicht;
            tbBezeichnung.Text = myKurs.getBezeichnung();

            int connected = c.openConnection();  // Datenbank oeffnen
            if (connected == 0)
            {
                c.displayData(
                          "SELECT m.mitglieder_id, vorname, nachname, geburtsdatum FROM mitglieder m, kursuebersicht k WHERE m.mitglieder_id = k.mitglieder_id AND k.kurs_id = " + myKurs.getKursId().ToString() + ";", gridKursUebersichtTeilnehmer);
                c.closeConnection(); // Datenbank schliessen

                // Headertexte anpassen
                DataTable gridMitgliederTable = (DataTable)(gridKursUebersichtTeilnehmer.DataSource);
                gridMitgliederTable.Columns["mitglieder_id"].ColumnName = "Mitglieder-ID";
                gridMitgliederTable.Columns["vorname"].ColumnName = "Vorname";
                gridMitgliederTable.Columns["nachname"].ColumnName = "Nachname";
                gridMitgliederTable.Columns["geburtsdatum"].ColumnName = "Geburtsdatum";

                //Aktuelle Teilnehmerzahl aktualisieren
                int aktuelleTeilnehmer = gridKursUebersichtTeilnehmer.Rows.Count;
                int aktTeilnehmer = myKurs.getAktTeilnehmer();
                if (aktTeilnehmer != aktuelleTeilnehmer)
                {
                    c.openConnection();
                    string sql = "UPDATE kurse SET akt_teilnehmer = '" + aktuelleTeilnehmer + "' WHERE kurs_id = '" + myKurs.getKursId() + "';";
                    c.update(sql, "");
                    c.closeConnection();
                }

                int maxTeilnehmer = myKurs.getMaxTeilnehmer();
                if (aktuelleTeilnehmer >= maxTeilnehmer)
                {
                    btKursUebersichtNeu.Enabled = false;
                }
                else
                {
                    btKursUebersichtNeu.Enabled = true;
                }
            }
        }

        public void aktualisieren(DataGridView gridKursUebersichtTeilnehmer)
        {
            int connected = c.openConnection();  // Datenbank oeffnen
            if (connected == 0)
            {
                c.displayData(
                          "SELECT m.mitglieder_id, vorname, nachname, geburtsdatum FROM mitglieder m, kursuebersicht k WHERE m.mitglieder_id = k.mitglieder_id AND k.kurs_id = " + gmyKurs.getKursId() + ";", gridKursUebersichtTeilnehmer);
                c.closeConnection(); // Datenbank schliessen

                // Headertexte anpassen
                DataTable gridMitgliederTable = (DataTable)(gridKursUebersichtTeilnehmer.DataSource);
                gridMitgliederTable.Columns["mitglieder_id"].ColumnName = "Mitglieder-ID";
                gridMitgliederTable.Columns["vorname"].ColumnName = "Vorname";
                gridMitgliederTable.Columns["nachname"].ColumnName = "Nachname";
                gridMitgliederTable.Columns["geburtsdatum"].ColumnName = "Geburtsdatum";

                //Aktuelle Teilnehmerzahl aktualisieren
                int aktuelleTeilnehmer = gridKursUebersichtTeilnehmer.Rows.Count;
                int aktTeilnehmer = gmyKurs.getAktTeilnehmer();
                if (aktTeilnehmer != aktuelleTeilnehmer)
                {
                    c.openConnection();
                    string sql = "UPDATE kurse SET akt_teilnehmer = '" + aktuelleTeilnehmer + "' WHERE kurs_id = '" + gmyKurs.getKursId() + "';";
                    c.update(sql, "");
                    c.closeConnection();
                }

                int maxTeilnehmer = gmyKurs.getMaxTeilnehmer();
                if (aktuelleTeilnehmer >= maxTeilnehmer)
                {
                    btKursUebersichtNeu.Enabled = false;
                }
                else
                {
                    btKursUebersichtNeu.Enabled = true;
                }
            }
        }

        private void btSchliessen_Click(object sender, EventArgs e)
        {
            kursUebersichtaktualisieren();
            this.Close();

        }

        private void btKursUebersichtLoeschen_Click(object sender, EventArgs e)
        {
            if (gridKursUebersichtTeilnehmer.CurrentCell != null) // Wenn eine Zelle ausgewählt
            {
                foreach (DataGridViewRow row in gridKursUebersichtTeilnehmer.SelectedRows) // Wegen Multiselect
                {
                    // int id = gmyKurs.getKursId();
                    DialogResult dialogResult = MessageBox.Show("Wollen Sie den ausgewählten Teilnehmer wirklich löschen?", "Information", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        c.openConnection();
                        int teilnehmer_id = Convert.ToInt32(gridKursUebersichtTeilnehmer.Rows[row.Index].Cells["Mitglieder-ID"].Value);
                        gridKursUebersichtTeilnehmer.Rows.RemoveAt(row.Index); // Row löschen
                        c.delete("DELETE FROM kursuebersicht WHERE mitglieder_id = '" + teilnehmer_id + "';", "Mitglied");
                        c.closeConnection();
                    }
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Sie müssen zuvor eine Zeile oder mehrere Zeilen auswählen.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            aktualisieren(gridKursUebersichtTeilnehmer);
        }

        private void btKursUebersichtNeu_Click(object sender, EventArgs e)
        {
            aktualisieren(gridKursUebersichtTeilnehmer);

            winTeilnehmer window = new winTeilnehmer(gmyKurs, gridKursUebersichtTeilnehmer);
            window.Show();
        }

        private void kursUebersichtaktualisieren()
        {
            int connected = c.openConnection();  // Datenbank oeffnen
            if (connected == 0)
            {
                c.displayData(
                          "SELECT kurs_id, bezeichnung, akt_teilnehmer, max_teilnehmer, CONCAT('(', mitarbeiter_id,') ', vorname, ', ', nachname) AS Kursleiter, wochentag,  uhrzeit_von, uhrzeit_bis, datum_von, datum_bis, preis " +
                          "FROM kurse k, mitarbeiter m WHERE k.kursleiter_id = m.mitarbeiter_id; ", g);
                c.closeConnection(); // Datenbank schliessen

                // Headertexte anpassen
                DataTable gridKursUebersichtTable = (DataTable)(g.DataSource);
                gridKursUebersichtTable.Columns["kurs_id"].ColumnName = "Kurs-ID";
                gridKursUebersichtTable.Columns["bezeichnung"].ColumnName = "Kurs-Name";
                gridKursUebersichtTable.Columns["preis"].ColumnName = "Preis in Euro";
                gridKursUebersichtTable.Columns["akt_teilnehmer"].ColumnName = "Akt. Teilnehmer";
                gridKursUebersichtTable.Columns["max_teilnehmer"].ColumnName = "Max. Teilnehmer";
                gridKursUebersichtTable.Columns["datum_von"].ColumnName = "Datum Von";
                gridKursUebersichtTable.Columns["datum_bis"].ColumnName = "Datum Bis";
                gridKursUebersichtTable.Columns["wochentag"].ColumnName = "Wochentag";
                gridKursUebersichtTable.Columns["uhrzeit_von"].ColumnName = "Uhrzeit Von";
                gridKursUebersichtTable.Columns["uhrzeit_bis"].ColumnName = "Uhrzeit Bis";

                c_Helper.changeColumnDataType(gridKursUebersichtTable, "Wochentag", typeof(String));// Wochentag muss in Spalte 6!
                g.Columns["Wochentag"].DisplayIndex = 6;

                for (int i = 0; i < gridKursUebersichtTable.Rows.Count; i++)
                {
                    String wert = c_Helper.umwandlungIntInWochentag(Convert.ToInt32(gridKursUebersichtTable.Rows[i]["Wochentag"]));
                    gridKursUebersichtTable.Rows[i]["Wochentag"] = wert;
                }
                g.Refresh();
            }
        }
    }
}
