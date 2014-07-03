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
    public partial class winTeilnehmer : Form
    {
        private int kurs_ID;
        private c_DBConnect c = new c_DBConnect();
        private DataGridView g;
        private c_Kurse tmyKurs;

        public winTeilnehmer(c_Kurse kurs, DataGridView gridKursUebersichtTeilnehmer)
        {
            InitializeComponent();
            tmyKurs = kurs;
            kurs_ID = kurs.getKursId();
            g = gridKursUebersichtTeilnehmer;
            aktualisieren(g);
            int connected = c.openConnection();  // Datenbank oeffnen
            if (connected == 0)
            {
                c.displayData(
                          "SELECT mitglieder_id, vorname, nachname, geburtsdatum FROM mitglieder ;", gridTeilnehmerHinzufuegen);
                c.closeConnection(); // Datenbank schliessen

                // Headertexte anpassen
                DataTable gridMitgliederTable = (DataTable)(gridTeilnehmerHinzufuegen.DataSource);
                gridMitgliederTable.Columns["mitglieder_id"].ColumnName = "Mitglieder-ID";
                gridMitgliederTable.Columns["vorname"].ColumnName = "Vorname";
                gridMitgliederTable.Columns["nachname"].ColumnName = "Nachname";
                gridMitgliederTable.Columns["geburtsdatum"].ColumnName = "Geburtsdatum";
            }
        }

        private void btSchliessen_Click(object sender, EventArgs e)
        {
            this.Close();
            aktualisieren(g);
        }

        private void btHinzufuegen_Click(object sender, EventArgs e)
        {
            if (gridTeilnehmerHinzufuegen.CurrentCell != null) // Wenn eine Zelle ausgewählt
            {
                foreach (DataGridViewRow row in gridTeilnehmerHinzufuegen.SelectedRows) // Wegen Multiselect
                {
                    c.openConnection();
                    int teilnehmer_ID = Convert.ToInt32(gridTeilnehmerHinzufuegen.Rows[row.Index].Cells["Mitglieder-ID"].Value);
                    // Ueberpruefen ob Mitglied schon in Kurs vorhanden
                    bool vorhanden = c.count("SELECT * FROM kursuebersicht WHERE kurs_id = '" + kurs_ID + "' AND mitglieder_id = '" + teilnehmer_ID + "';");
                    c.closeConnection();
                    if (vorhanden != true)
                    {
                        c.openConnection();
                        c.insert("INSERT INTO kursuebersicht (kurs_id, mitglieder_id) VALUES (" + kurs_ID + ", " + teilnehmer_ID + ");", "Mitglied");
                        c.closeConnection();
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Einer der ausgewählten Teilnehmer ist bereits in dem gewünschten Kurs vorhanden.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        c.closeConnection();
                    }
                    
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Sie müssen zuvor eine Zeile oder mehrere Zeilen auswählen.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
            aktualisieren(g);
        }

        private void gridTeilnehmerHinzufuegen_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) // Rechtsklick
            {
                // ContextMenuStrip mit ToolStipMenuItem erzeugen
                ContextMenuStrip myContextMenu = new ContextMenuStrip();
                ToolStripMenuItem toolStripItemTeilnehmerAktualisieren = new ToolStripMenuItem("Aktualisieren (F5)");

                // Items hinzufügen
                myContextMenu.Items.Add(toolStripItemTeilnehmerAktualisieren);

                // Bild hinzufuegen
                toolStripItemTeilnehmerAktualisieren.Image = PuG_Verwaltungssoftware.Properties.Resources.pug_refresh;

                // Handler der Items
                toolStripItemTeilnehmerAktualisieren.Click += new EventHandler(toolStripItemTeilnehmerAktualisieren_Click);

                int currentMouseOverRow = gridTeilnehmerHinzufuegen.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0) // In der Tabelle
                {
                    // Nix
                }

                myContextMenu.Show(gridTeilnehmerHinzufuegen, new Point(e.X, e.Y));
            }
        }

        private void toolStripItemTeilnehmerAktualisieren_Click(object sender, EventArgs args)
        {
            gridTeilnehmerUebersichtAktualisieren();
        }

        private void gridTeilnehmerHinzufuegen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F5) // Aktualisieren
            {
                gridTeilnehmerUebersichtAktualisieren();
            }
        }

        private void aktualisieren(DataGridView gridKursUebersichtTeilnehmer)
        {
            int connected = c.openConnection();  // Datenbank oeffnen
            if (connected == 0)
            {
                c.displayData(
                          "SELECT m.mitglieder_id, vorname, nachname, geburtsdatum FROM mitglieder m, kursuebersicht k WHERE m.mitglieder_id = k.mitglieder_id AND k.kurs_id = " + kurs_ID + ";", gridKursUebersichtTeilnehmer);
                c.closeConnection(); // Datenbank schliessen

                // Headertexte anpassen
                DataTable gridMitgliederTable = (DataTable)(gridKursUebersichtTeilnehmer.DataSource);
                gridMitgliederTable.Columns["mitglieder_id"].ColumnName = "Mitglieder-ID";
                gridMitgliederTable.Columns["vorname"].ColumnName = "Vorname";
                gridMitgliederTable.Columns["nachname"].ColumnName = "Nachname";
                gridMitgliederTable.Columns["geburtsdatum"].ColumnName = "Geburtsdatum";

                //Aktuelle Teilnehmerzahl aktualisieren
                int aktuelleTeilnehmer = gridKursUebersichtTeilnehmer.Rows.Count;
                int aktTeilnehmer = tmyKurs.getAktTeilnehmer();
                if (aktTeilnehmer != aktuelleTeilnehmer)
                {
                    c.openConnection();
                    string sql = "UPDATE kurse SET akt_teilnehmer = '" + aktuelleTeilnehmer + "' WHERE kurs_id = '" + tmyKurs.getKursId() + "';";
                    c.update(sql, "");
                    c.closeConnection();
                }

                int maxTeilnehmer = tmyKurs.getMaxTeilnehmer();
                if (aktuelleTeilnehmer >= maxTeilnehmer)
                {
                    btHinzufuegen.Enabled = false;
                }
                else
                {
                    btHinzufuegen.Enabled = true;
                }
            }
        }

        private void gridTeilnehmerUebersichtAktualisieren()
        {
            int connected = c.openConnection();  // Datenbank oeffnen
            if (connected == 0)
            {
                c.displayData(
                          "SELECT mitglieder_id, vorname, nachname, geburtsdatum FROM mitglieder ;", gridTeilnehmerHinzufuegen);
                c.closeConnection(); // Datenbank schliessen

                // Headertexte anpassen
                DataTable gridMitgliederTable = (DataTable)(gridTeilnehmerHinzufuegen.DataSource);
                gridMitgliederTable.Columns["mitglieder_id"].ColumnName = "Mitglieder-ID";
                gridMitgliederTable.Columns["vorname"].ColumnName = "Vorname";
                gridMitgliederTable.Columns["nachname"].ColumnName = "Nachname";
                gridMitgliederTable.Columns["geburtsdatum"].ColumnName = "Geburtsdatum";
            }
            else
            {
                MessageBox.Show("Verbindungsfehler!\nÜbersicht konnte nicht aktualisiert werden.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
