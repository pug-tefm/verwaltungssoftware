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

// Maxi
namespace PuG_Verwaltungssoftware
{
    public partial class mainWindow : Form
    {
        private BindingSource bindingSourceKursUebersicht = new BindingSource();

        private void tabPageKursUebersicht_Enter(object sender, EventArgs e)
        {
            int connected = c.openConnection();  // Datenbank oeffnen
            if (connected == 0)
            {
                c.displayData(
                          "SELECT kurs_id, bezeichnung, akt_teilnehmer, max_teilnehmer, CONCAT('(', mitarbeiter_id,') ', vorname, ', ', nachname) AS Kursleiter, wochentag,  uhrzeit_von, uhrzeit_bis, datum_von, datum_bis, preis " +
                          "FROM kurse k, mitarbeiter m WHERE k.kursleiter_id = m.mitarbeiter_id; ", gridKursUebersicht);
                c.closeConnection(); // Datenbank schliessen

                // Headertexte anpassen
                DataTable gridKursUebersichtTable = (DataTable)(gridKursUebersicht.DataSource);
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

                c_Helper.changeColumnDataType(gridKursUebersichtTable, "Wochentag", typeof(String));
                gridKursUebersicht.Columns["Wochentag"].DisplayIndex = 6;

                for (int i = 0; i < gridKursUebersichtTable.Rows.Count; i++)
                {
                    String wert = c_Helper.umwandlungIntInWochentag(Convert.ToInt32(gridKursUebersichtTable.Rows[i]["Wochentag"]));
                    gridKursUebersichtTable.Rows[i]["Wochentag"] = wert;
                }

                gridKursUebersicht.Refresh();

            }

            if (initKursUebersicht == false)
            {
                if (gridKursUebersicht.ColumnCount > 0)
                {
                    for (int i = 0; i < gridKursUebersicht.ColumnCount; i++)
                    {
                        ddlKursUebersichtSuchen.Items.Add(gridKursUebersicht.Columns[i].HeaderText);
                    }
                    ddlKursUebersichtSuchen.SelectedIndex = 0;
                }
                initKursUebersicht = true;
            }

            bindingSourceKursUebersicht.DataSource = gridKursUebersicht.DataSource;
            gridKursUebersicht.DataSource = bindingSourceKursUebersicht;
        }

        private void btKursUebersichtOeffnen_Click(object sender, EventArgs e)
        {
            kursUebersichtOeffnen();
        }

        private void gridKursUebersicht_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) // Rechtsklick
            {
                // ContextMenuStrip mit ToolStipMenuItem erzeugen
                ContextMenuStrip myContextMenu = new ContextMenuStrip();
                ToolStripMenuItem toolStripItemUebersichtAktualisieren = new ToolStripMenuItem("Aktualisieren (F5)");

                // Items hinzufügen
                myContextMenu.Items.Add(toolStripItemUebersichtAktualisieren);

                // Bild hinzufuegen
                toolStripItemUebersichtAktualisieren.Image = PuG_Verwaltungssoftware.Properties.Resources.pug_refresh;

                // Handler der Items
                toolStripItemUebersichtAktualisieren.Click += new EventHandler(toolStripItemUebersichtAktualisieren_Click);

                int currentMouseOverRow = gridKursUebersicht.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0) // In der Tabelle
                {
                    // Nix
                }

                myContextMenu.Show(gridKursUebersicht, new Point(e.X, e.Y));
            }
        }

        private void toolStripItemUebersichtAktualisieren_Click(object sender, EventArgs args)
        {
            kursUebersichtaktualisieren();
        }

        private void gridKursUebersicht_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == (Keys.Control | Keys.O))  // Steuerung + O = Kurs-Uebersicht öffnen
            {
                kursUebersichtOeffnen();
            }

            if (e.KeyData == Keys.F5) // Aktualisieren
            {
                kursUebersichtaktualisieren();
            }  
        }

        private void gridKursUebersicht_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            kursUebersichtOeffnen();
        }

        private void ddlKursUebersichtSuchen_SelectedIndexChanged(object sender, EventArgs e)
        {
            myHelper.comboBoxSuchenSelectedIndexChanged(gridKursUebersicht, ddlKursUebersichtSuchen, tbKursUebersichtSuchen, bindingSourceKursUebersicht);
        }

        private void tbKursUebersichtSuchen_TextChanged(object sender, EventArgs e)
        {
            myHelper.textBoxSuchenTextChanged(gridKursUebersicht, ddlKursUebersichtSuchen, tbKursUebersichtSuchen, bindingSourceKursUebersicht);
        }


        /*
         * ******************************
         *        Eigene Methoden
         * ******************************
         * */

        private void kursUebersichtaktualisieren()
        {
            int connected = c.openConnection();  // Datenbank oeffnen
            if (connected == 0)
            {
                c.displayData(
                          "SELECT kurs_id, bezeichnung, akt_teilnehmer, max_teilnehmer, CONCAT('(', mitarbeiter_id,') ', vorname, ', ', nachname) AS Kursleiter, wochentag,  uhrzeit_von, uhrzeit_bis, datum_von, datum_bis, preis " +
                          "FROM kurse k, mitarbeiter m WHERE k.kursleiter_id = m.mitarbeiter_id; ", gridKursUebersicht);
                c.closeConnection(); // Datenbank schliessen

                // Headertexte anpassen
                DataTable gridKursUebersichtTable = (DataTable)(gridKursUebersicht.DataSource);
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

                c_Helper.changeColumnDataType(gridKursUebersichtTable, "Wochentag", typeof(String));
                gridKursUebersicht.Columns["Wochentag"].DisplayIndex = 6;

                for (int i = 0; i < gridKursUebersichtTable.Rows.Count; i++)
                {
                    String wert = c_Helper.umwandlungIntInWochentag(Convert.ToInt32(gridKursUebersichtTable.Rows[i]["Wochentag"]));
                    gridKursUebersichtTable.Rows[i]["Wochentag"] = wert;
                }

                bindingSourceKursUebersicht.DataSource = gridKursUebersicht.DataSource;
                gridKursUebersicht.DataSource = bindingSourceKursUebersicht;
            }
        }

        private void kursUebersichtOeffnen()
        {
            if (gridKursUebersicht.CurrentCell != null) // Wenn eine Zelle ausgewählt
            {
                foreach (DataGridViewRow row in gridKursUebersicht.SelectedRows) // Damit mehrere Zeilen per Multiselect geöffnet werden können
                {
                    if (gridKursUebersicht.RowCount > 0) // Wenn Zeilenanzahl größer 0
                    {
                        c_Kurse myKurs = new c_Kurse();
                        myKurs.setKursId(int.Parse(gridKursUebersicht.Rows[row.Index].Cells["Kurs-ID"].Value.ToString()));
                        myKurs.setBezeichnung(gridKursUebersicht.Rows[row.Index].Cells["Kurs-Name"].Value.ToString());
                        myKurs.setMaxTeilnehmer(int.Parse(gridKursUebersicht.Rows[row.Index].Cells["Max. Teilnehmer"].Value.ToString()));
                        myKurs.setAktTeilnehmer(int.Parse(gridKursUebersicht.Rows[row.Index].Cells["Akt. Teilnehmer"].Value.ToString()));
                        winKursUebersicht window = new winKursUebersicht(myKurs, gridKursUebersicht);
                        window.Show();
                    }
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Sie müssen zuvor eine Zeile oder mehrere Zeilen auswählen.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gridKursUebersicht_Resize(object sender, EventArgs e)
        {
            HScrollBar horizontalScrollBar = null;

            foreach (Control c in gridKursUebersicht.Controls)
            {
                if (c is HScrollBar)
                {
                    horizontalScrollBar = c as HScrollBar;
                    break;
                }
            }

            int horizontalScrollbarBreite = horizontalScrollBar.Width;
            int differenz = gridKursUebersicht.Size.Width - horizontalScrollbarBreite;

            if (gridKursUebersicht.Size.Width <= horizontalScrollbarBreite + differenz)
            {
                for (int i = 0; i < gridKursUebersicht.RowCount; i++)
                {
                    DataGridViewColumn column = gridKursUebersicht.Columns[i];
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
            }

            if (horizontalScrollBar.Visible == false)
            {
                for (int i = 0; i < gridKursUebersicht.RowCount; i++)
                {
                    DataGridViewColumn column = gridKursUebersicht.Columns[i];
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }
    }
}
