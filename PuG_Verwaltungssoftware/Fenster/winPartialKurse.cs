using PuG_Verwaltungssoftware.Klassen;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuG_Verwaltungssoftware
{
    public partial class mainWindow : Form
    {
        private bool kommendeKurse   = false; // Initialiesierung
        private bool laufendeKurse   = false; // der die drei Zustände
        private bool vergangeneKurse = false; // des Filters

        private void tabPageKurse_Enter(object sender, EventArgs e)
        {
            int dBConnectOk = c.openConnection();  // Datenbank oeffnen
            c.displayData("SELECT * FROM kurse;", gridKurse);
            c.closeConnection(); // Datenbank schliessen

            if (dBConnectOk == 0)
            {
                // Headertexte anpassen
                //gridMitarbeiter.Columns["kurs_id"].HeaderText = "Kurs-ID";
                //gridMitarbeiter.Columns["kursleiter"].HeaderText = "Kursleiter";
                //gridMitarbeiter.Columns["bezeichnung"].HeaderText = "Bezeichnung";
                //gridMitarbeiter.Columns["akt_teilnehmer"].HeaderText = "Akt. Teilnehmer";
                //gridMitarbeiter.Columns["max_teilnehmer"].HeaderText = "Max. Teilnehmer";
                //gridMitarbeiter.Columns["datuum_von"].HeaderText = "Datum Von";
                //gridMitarbeiter.Columns["datum_bis"].HeaderText = "Datum Bis";
                //gridMitarbeiter.Columns["wochentag"].HeaderText = "Wochentag";
                //gridMitarbeiter.Columns["uhrzeit_von"].HeaderText = "Uhrzeit Von";
                //gridMitarbeiter.Columns["uhrzeit_bis"].HeaderText = "Uhrzeit Bis";
            }

            if (gridKurse.ColumnCount > 0)
            {
                for (int i = 0; i < gridKurse.ColumnCount; i++)
                {
                    ddlKursSuchen.Items.Add(gridKurse.Columns[i].HeaderText);
                }
                ddlKursSuchen.SelectedIndex = 0;
            }
            
        }

        private void rowsLoeschenKurse(DataGridView dataGridView)
        {
            if (dataGridView.CurrentCell != null) // Wenn eine Zelle ausgewählt
            {
                foreach (DataGridViewRow row in dataGridView.SelectedRows) // Wegen Multiselect
                {
                    int id = Convert.ToInt32(gridKurse.Rows[row.Index].Cells["Kurs-ID"].Value);
                    DialogResult dialogResult = MessageBox.Show("Wollen Sie den ausgewählten Kurs mit der Kurs-Nr. '" + id + "' wirklich löschen?", "Information", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        c.openConnection();
                        dataGridView.Rows.RemoveAt(row.Index); // Row löschen
                        c.delete("DELETE FROM kurse WHERE kurs_id = '" + id + "';", "Kurs");
                        c.closeConnection();
                    }
                }

                if (kommendeKurse   == true) { kommendeKurseFilter(true);   }
                if (laufendeKurse   == true) { laufendeKurseFilter(true);   }
                if (vergangeneKurse == true) { vergangeneKurseFilter(true); }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Sie müssen zuvor eine Zeile oder mehrere Zeilen auswählen.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void kurseOeffnen()
        {
            if (gridKurse.CurrentCell != null) // Wenn eine Zelle ausgewählt
            {
                foreach (DataGridViewRow row in gridKurse.SelectedRows) // Damit mehrere Zeilen per Multiselect geöffnet werden können
                {
                    if (gridKurse.RowCount > 0) // Wenn Zeilenanzahl größer 0
                    {
                        c_Kurse myKurse = new c_Kurse();

                        // Parameter von Kurs setzen
                        myKurse.setKursId(int.Parse(gridKurse.Rows[row.Index].Cells["Kurs-ID"].Value.ToString()));
                        myKurse.setKursleiter(gridKurse.Rows[row.Index].Cells["Kursleiter"].Value.ToString());
                        myKurse.setBezeichnung(gridKurse.Rows[row.Index].Cells["Bezeichnung"].Value.ToString());
                        myKurse.setPreis(double.Parse(gridKurse.Rows[row.Index].Cells["Preis"].Value.ToString()));
                        myKurse.setAktTeilnehmer(int.Parse(gridKurse.Rows[row.Index].Cells["Akt. Teilnehmer"].Value.ToString()));
                        myKurse.setMaxTeilnehmer(int.Parse(gridKurse.Rows[row.Index].Cells["Max. Teilnehmer"].Value.ToString()));
                        myKurse.setDatumVon(DateTime.Parse(gridKurse.Rows[row.Index].Cells["Datum Von"].Value.ToString()));
                        myKurse.setDatumBis(DateTime.Parse(gridKurse.Rows[row.Index].Cells["Datum Bis"].Value.ToString()));
                        myKurse.setWochentag(c_Helper.umwandlungWochentagInInt(gridKurse.Rows[row.Index].Cells["Wochentag"].Value.ToString()));
                        myKurse.setUhrzeitVon(DateTime.Parse(gridKurse.Rows[row.Index].Cells["Uhrzeit Von"].Value.ToString()));
                        myKurse.setUhrzeitBis(DateTime.Parse(gridKurse.Rows[row.Index].Cells["Uhrzeit Bis"].Value.ToString()));

                        winKursOeffnen myKurseOeffnen = new winKursOeffnen(ref myKurse, ref gridKurse); // und an neues Fenster übergeben
                        myKurseOeffnen.Visible = true;
                    }
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Sie müssen zuvor eine Zeile oder mehrere Zeilen auswählen.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBoxSuchen_SelectedIndexChanged(object sender, EventArgs e)
        {
            c_Helper myHelper = new c_Helper();
            myHelper.comboBoxSuchenSelectedIndexChanged(gridKurse, ddlKursSuchen, tbKursSuchen, bindingSource);

            // Sort blendet automatisch alle Zeilen wieder ein, daher müssen 
            // diese wieder ausgeblendet werden, wenn ein Filter vorliget
            kurseSortieren();
        }

        private void textBoxSuchen_TextChanged(object sender, EventArgs e)
        {
            c_Helper myHelper = new c_Helper();
            myHelper.textBoxSuchenTextChanged(gridKurse, ddlKursSuchen, tbKursSuchen, bindingSource);

            // Sort blendet automatisch alle Zeilen wieder ein, daher müssen 
            // diese wieder ausgeblendet werden, wenn ein Filter vorliget
            kurseSortieren();
        }

        private void btKursLoeschen_Click(object sender, EventArgs e)
        {
            rowsLoeschenKurse(gridKurse);
        }

        private void btKursNeu_Click(object sender, EventArgs e)
        {
            winKursNeu window = new winKursNeu(gridKurse);
            window.Show();
        }

        private void btKursOeffnen_Click(object sender, EventArgs e)
        {
            kurseOeffnen();
        }


        private void gridKurse_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) // Rechtsklick
            {
                // ContextMenuStrip mit ToolStipMenuItem erzeugen
                ContextMenuStrip  myContextMenu      = new ContextMenuStrip();
                ToolStripMenuItem toolStripItemOne   = new ToolStripMenuItem("Kommende Kurse");
                ToolStripMenuItem toolStripItemTwo   = new ToolStripMenuItem("Laufende Kurse");
                ToolStripMenuItem toolStripItemThree = new ToolStripMenuItem("Vergangene Kurse");
                ToolStripMenuItem toolStripItemFour  = new ToolStripMenuItem("Keine Einschränkung");
                ToolStripMenuItem toolStripItemFive  = new ToolStripMenuItem("-");
                ToolStripMenuItem toolStripItemSix   = new ToolStripMenuItem("Aktualisieren");


                // Items hinzufügen
                myContextMenu.Items.Add(toolStripItemOne);
                myContextMenu.Items.Add(toolStripItemTwo);
                myContextMenu.Items.Add(toolStripItemThree);
                myContextMenu.Items.Add(toolStripItemFour);
                myContextMenu.Items.Add(toolStripItemSix);

                // Und bei auswahl mit einem Bild versehen 
                if (kommendeKurse   == true)   toolStripItemOne.Image = Bitmap.FromFile("C:\\Users\\User\\Source\\Repos\\Verwaltungssoftware\verwaltungssoftware_\\PuG_Verwaltungssoftware\\Ressources\\Images\\haken_gruen.png");
                if (laufendeKurse   == true)   toolStripItemTwo.Image = Bitmap.FromFile("C:\\Users\\User\\Source\\Repos\\Verwaltungssoftware\verwaltungssoftware_\\PuG_Verwaltungssoftware\\Ressources\\Images\\haken_gruen.png");
                if (vergangeneKurse == true) toolStripItemThree.Image = Bitmap.FromFile("C:\\Users\\User\\Source\\Repos\\Verwaltungssoftware\verwaltungssoftware_\\PuG_Verwaltungssoftware\\Ressources\\Images\\haken_gruen.png");

                // Handler der Items
                toolStripItemOne.Click   += new EventHandler(toolStripItemOneKurse_Click);
                toolStripItemTwo.Click   += new EventHandler(toolStripItemTwoKurse_Click);
                toolStripItemThree.Click += new EventHandler(toolStripItemThreeKurse_Click);
                toolStripItemFour.Click  += new EventHandler(toolStripItemFourKurse_Click);
                toolStripItemSix.Click   += new EventHandler(toolStripItemSixKurse_Click);

                int currentMouseOverRow = gridKurse.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0) // In der Tabelle
                {
                    // Nix
                }

                myContextMenu.Show(gridKurse, new Point(e.X, e.Y));
            }
        }

        private void gridKurse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete) // Entfernen Taste = Kurs löschen
            {
                rowsLoeschenKurse(gridKurse);
            }

            if (e.KeyData == (Keys.Control | Keys.N)) // Steuerung + N = Neuer Kurs
            {
                winKursNeu myKurseNeu = new winKursNeu(gridKurse);
                myKurseNeu.Visible = true;
            }
        }

        private void gridKurse_Resize(object sender, EventArgs e)
        {
            HScrollBar horizontalScrollBar = null;

            foreach (Control c in gridKurse.Controls)
            {
                if (c is HScrollBar)
                {
                    horizontalScrollBar = c as HScrollBar;
                    break;
                }
            }

            int horizontalScrollbarBreite = horizontalScrollBar.Width;
            int differenz = gridKurse.Size.Width - horizontalScrollbarBreite;

            if (gridKurse.Size.Width <= horizontalScrollbarBreite + differenz)
            {
                for (int i = 0; i < gridKurse.RowCount; i++)
                {
                    DataGridViewColumn column = gridKurse.Columns[i];
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
            }

            if (horizontalScrollBar.Visible == false)
            {
                for (int i = 0; i < gridKurse.RowCount; i++)
                {
                    DataGridViewColumn column = gridKurse.Columns[i];
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }

        private void gridKurse_Sorted(object sender, EventArgs e)
        {
            // Sort blendet automatisch alle Zeilen wieder ein, daher müssen 
            // diese wieder ausgeblendet werden, wenn ein Filter vorliget
            kurseSortieren();
        }

        private void gridKurse_Paint(object sender, PaintEventArgs e)
        {
            DateTime today = DateTime.Now;

            for (int i = 0; i < gridKurse.RowCount; i++) // Alle Zeilen anschauen
            {
                DateTime beginnDate = DateTime.Parse(gridKurse.Rows[i].Cells["Datum Von"].Value.ToString());
                DateTime endDate = DateTime.Parse(gridKurse.Rows[i].Cells["Datum Bis"].Value.ToString());
                if (today >= beginnDate && today <= endDate) // Wenn ein laufender Kurs
                {
                    String wochentag = gridKurse.Rows[i].Cells["Wochentag"].Value.ToString();
                    if (c_Helper.umwandlungWochentagEngToGer(today.DayOfWeek.ToString()) == wochentag) // Wenn Tag = Heute
                    {
                        DateTime beginnUhrzeit = DateTime.Parse(gridKurse.Rows[i].Cells["Uhrzeit Von"].Value.ToString());
                        DateTime endUhrzeit = DateTime.Parse(gridKurse.Rows[i].Cells["Uhrzeit Bis"].Value.ToString());
                        if (today.TimeOfDay > beginnUhrzeit.TimeOfDay && today.TimeOfDay < endUhrzeit.TimeOfDay) // Wenn Uhrzeit passt
                        {
                            gridKurse.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen; // Kurs als gerade laufend kennzeichnen
                        }
                        else
                        {
                            gridKurse.Rows[i].DefaultCellStyle.BackColor = Color.White; // Default Farbe zuweisen
                        }
                    }
                }
            }
        }

        private void toolStripItemOneKurse_Click(object sender, EventArgs args)
        {
            if (kommendeKurse == false)
            {
                if (laufendeKurse   == true) laufendeKurseFilter();
                if (vergangeneKurse == true) vergangeneKurseFilter();
                kommendeKurseFilter();
            }
        }

        private void toolStripItemTwoKurse_Click(object sender, EventArgs args)
        {
            if (laufendeKurse == false)
            {
                if (kommendeKurse   == true) kommendeKurseFilter();
                if (vergangeneKurse == true) vergangeneKurseFilter();
                laufendeKurseFilter();
            }
        }

        private void toolStripItemThreeKurse_Click(object sender, EventArgs args)
        {
            if (vergangeneKurse == false)
            {
                if (kommendeKurse == true) kommendeKurseFilter();
                if (laufendeKurse == true) laufendeKurseFilter();
                vergangeneKurseFilter();
            }
        }

        private void toolStripItemFourKurse_Click(object sender, EventArgs args)
        {
            keineEinschraenkungen();
        }

        private void toolStripItemSixKurse_Click(object sender, EventArgs args)
        {
            int connected = c.openConnection();
            if (connected == 0)
            {
                c.displayData("SELECT * FROM kurse;", gridKurse);
                c.closeConnection();
            }
            else
            {
                MessageBox.Show("Verbindungsfehler!\nÜbersicht konnte nicht aktualisiert werden.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void kommendeKurseFilter(bool kommendeKurseExtra = false)
        {
            DateTime today = DateTime.Now;

            if (kommendeKurseExtra == true)
            {
                kommendeKurse = kommendeKurseExtra;
            }
            else
            {
                kommendeKurse = !kommendeKurse;
            }

            for (int i = 0; i < gridKurse.RowCount; i++)
            {
                DateTime beginnDate = DateTime.Parse(gridKurse.Rows[i].Cells["Datum Von"].Value.ToString());
                if (today >= beginnDate)
                {
                    CurrencyManager currencyManager = (CurrencyManager)BindingContext[gridKurse.DataSource];
                    currencyManager.SuspendBinding();
                    if (kommendeKurse == true)
                    {
                        gridKurse.Rows[i].Visible = false;
                    }
                    else
                    {
                        gridKurse.Rows[i].Visible = true;
                    }
                    currencyManager.ResumeBinding();
                }
            }
            gridKurse.ClearSelection();
        }

        public void laufendeKurseFilter(bool laufendeKurseExtra = false)
        {
            DateTime today = DateTime.Today;

            if (laufendeKurseExtra == true)
            {
                laufendeKurse = laufendeKurseExtra;
            }
            else
            {
                laufendeKurse = !laufendeKurse;
            }

            for (int i = 0; i < gridKurse.RowCount; i++)
            {
                DateTime beginnDate = DateTime.Parse(gridKurse.Rows[i].Cells["Datum Von"].Value.ToString());
                DateTime endDate = DateTime.Parse(gridKurse.Rows[i].Cells["Datum Bis"].Value.ToString());
                if (today <= beginnDate || today >= endDate)
                {
                    CurrencyManager currencyManager = (CurrencyManager)BindingContext[gridKurse.DataSource];
                    currencyManager.SuspendBinding();
                    if (laufendeKurse == true)
                    {
                        gridKurse.Rows[i].Visible = false;
                    }
                    else
                    {
                        gridKurse.Rows[i].Visible = true;
                    }
                    currencyManager.ResumeBinding();
                }
            }
            gridKurse.ClearSelection();
        }

        public void vergangeneKurseFilter(bool vergangeneKurseExtra = false)
        {
            DateTime today = DateTime.Today;

            if (vergangeneKurseExtra == true)
            {
                vergangeneKurse = vergangeneKurseExtra;
            }
            else
            {
                vergangeneKurse = !vergangeneKurse;
            }

            for (int i = 0; i < gridKurse.RowCount; i++)
            {
                DateTime endDate = DateTime.Parse(gridKurse.Rows[i].Cells["Datum Bis"].Value.ToString());
                if (today <= endDate)
                {
                    CurrencyManager currencyManager = (CurrencyManager)BindingContext[gridKurse.DataSource];
                    currencyManager.SuspendBinding();
                    if (vergangeneKurse == true)
                    {
                        gridKurse.Rows[i].Visible = false;
                    }
                    else
                    {
                        gridKurse.Rows[i].Visible = true;
                    }
                    currencyManager.ResumeBinding();
                }
            }
            gridKurse.ClearSelection();
        }

        public void keineEinschraenkungen()
        {
            if (kommendeKurse   == true) kommendeKurseFilter();
            if (laufendeKurse   == true) laufendeKurseFilter();
            if (vergangeneKurse == true) vergangeneKurseFilter();
        }

        private void kurseSortieren()
        {
            if (kommendeKurse == true)
            {
                kommendeKurse = false;
                kommendeKurseFilter();
            }

            if (laufendeKurse == true)
            {
                laufendeKurse = false;
                laufendeKurseFilter();
            }

            if (vergangeneKurse == true)
            {
                vergangeneKurse = false;
                vergangeneKurseFilter();
            }
            gridKurse.ClearSelection();
        }
    }
}
