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

// Erik, Florian und Tim
namespace PuG_Verwaltungssoftware
{
    public partial class mainWindow : Form
    {
        private int s = 0;
        private int m = 0;
        private int h = 0;

        private void listViewsLaden(int reload = 0)
        {
            if (initHome == false || reload != 0)
            {
                // Listview initialisieren
                if (initHome == false)
                {
                    initializeListView();
                    initHome = true;
                }

                // Listview-Eintraege hinzufuegen
                loadListAktuell();
                loadListHeute();
                loadListKommend();
            } 
        }

        private void tabPageHome_Enter(object sender, EventArgs e)
        {
            listViewsLaden();
        }

        // Initialize ListView
        private void initializeListView()
        {
            // Set the view to show details.
            lvNewsAktuell.View = View.Details;
            lvNewsHeute.View = View.Details;
            lvNewsKommend.View = View.Details;

            // Allow the user to rearrange columns.
            lvNewsAktuell.AllowColumnReorder = true;
            lvNewsHeute.AllowColumnReorder = true;
            lvNewsKommend.AllowColumnReorder = true;

            // Select the item and subitems when selection is made.
            lvNewsAktuell.FullRowSelect = true;
            lvNewsHeute.FullRowSelect = true;
            lvNewsKommend.FullRowSelect = true;

            // Display grid lines.
            lvNewsAktuell.GridLines = false;
            lvNewsHeute.GridLines = false;
            lvNewsKommend.GridLines = false;

            // Sort the items in the list in ascending order.
            lvNewsAktuell.Sorting = SortOrder.Ascending;
            lvNewsHeute.Sorting = SortOrder.Ascending;
            lvNewsKommend.Sorting = SortOrder.Ascending;

            // Attach Subitems to the ListView
            lvNewsAktuell.Columns.Add("Bezeichnung", -1, HorizontalAlignment.Left);
            lvNewsAktuell.Columns.Add("Datum Von", -1, HorizontalAlignment.Left);
            lvNewsAktuell.Columns.Add("Datum Bis", -1, HorizontalAlignment.Left);
            lvNewsAktuell.Columns.Add("Uhrzeit Von", -1, HorizontalAlignment.Left);
            lvNewsAktuell.Columns.Add("Uhrzeit Bis", -1, HorizontalAlignment.Left);
            lvNewsAktuell.Columns.Add("Wochentag", -1, HorizontalAlignment.Left);

            lvNewsHeute.Columns.Add("Bezeichnung", -1, HorizontalAlignment.Left);
            lvNewsHeute.Columns.Add("Datum Von", -1, HorizontalAlignment.Left);
            lvNewsHeute.Columns.Add("Datum Bis", -1, HorizontalAlignment.Left);
            lvNewsHeute.Columns.Add("Uhrzeit Von", -1, HorizontalAlignment.Left);
            lvNewsHeute.Columns.Add("Uhrzeit Bis", -1, HorizontalAlignment.Left);
            lvNewsHeute.Columns.Add("Wochentag", -1, HorizontalAlignment.Left);

            lvNewsKommend.Columns.Add("Bezeichnung", -1, HorizontalAlignment.Left);
            lvNewsKommend.Columns.Add("Datum Von", -1, HorizontalAlignment.Left);
            lvNewsKommend.Columns.Add("Datum Bis", -1, HorizontalAlignment.Left);
            lvNewsKommend.Columns.Add("Uhrzeit Von", -1, HorizontalAlignment.Left);
            lvNewsKommend.Columns.Add("Uhrzeit Bis", -1, HorizontalAlignment.Left);
            lvNewsKommend.Columns.Add("Wochentag", -1, HorizontalAlignment.Left);

            lvNewsAktuell.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lvNewsHeute.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lvNewsKommend.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }


        private void loadListAktuell()
        {
            // Get the table
            int connected = c.openConnection();
            if (connected == 0)
            {
                // Clear the ListView control
                lvNewsAktuell.Items.Clear();

                DataTable dtable = c.select("SELECT bezeichnung, datum_von, datum_bis, uhrzeit_von, uhrzeit_bis, wochentag FROM kurse;");
                c.closeConnection();

                if(dtable != null)
                {
                    DateTime today = DateTime.Now;

                    for (int i = 0; i < dtable.Rows.Count; i++) // Alle Zeilen anschauen
                    {
                        DateTime beginnDate = DateTime.Parse(dtable.Rows[i]["datum_von"].ToString());
                        DateTime endDate = DateTime.Parse(dtable.Rows[i]["datum_bis"].ToString());
                        if (today >= beginnDate && today <= endDate || beginnDate == endDate) // Wenn ein laufender Kurs
                        {
                            String stringWochentag = c_Helper.umwandlungIntInWochentag(Convert.ToInt32(dtable.Rows[i]["Wochentag"]));
                            if (c_Helper.umwandlungWochentagEngToGer(today.DayOfWeek.ToString()) == stringWochentag) // Wenn Tag = Heute
                            {
                                DateTime beginnUhrzeit = DateTime.Parse(dtable.Rows[i]["uhrzeit_von"].ToString());
                                DateTime endUhrzeit = DateTime.Parse(dtable.Rows[i]["uhrzeit_bis"].ToString());
                                if (today.TimeOfDay > beginnUhrzeit.TimeOfDay && today.TimeOfDay < endUhrzeit.TimeOfDay) // Wenn Uhrzeit passt
                                {

                                    DataRow drow = dtable.Rows[i];

                                    // Only row that have not been deleted
                                    if (drow.RowState != DataRowState.Deleted)
                                    {
                                        // Define the list items
                                        ListViewItem lvi = new ListViewItem(drow["bezeichnung"].ToString());
                                        lvi.SubItems.Add(DateTime.Parse(drow["datum_von"].ToString()).ToString("dd.MM.yyyy"));
                                        lvi.SubItems.Add(DateTime.Parse(drow["datum_bis"].ToString()).ToString("dd.MM.yyyy"));
                                        lvi.SubItems.Add(DateTime.Parse(drow["uhrzeit_von"].ToString()).TimeOfDay.ToString("hh\\:mm"));
                                        lvi.SubItems.Add(DateTime.Parse(drow["uhrzeit_bis"].ToString()).TimeOfDay.ToString("hh\\:mm"));
                                        lvi.SubItems.Add(c_Helper.umwandlungIntInWochentag(Convert.ToInt32(drow["wochentag"])));
                                        lvi.BackColor = Color.Aqua;

                                        // Add the list items to the ListView
                                        lvNewsAktuell.Items.Add(lvi);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void loadListHeute()
        {
            // Get the table
            int connected = c.openConnection();
            if (connected == 0)
            {
                // Clear the ListView control
                lvNewsHeute.Items.Clear();

                DateTime today = DateTime.Now;
                int tag = (int)today.DayOfWeek -1;  // -1 weil Montag 0 ist, anstatt 1

                DataTable dtable = c.select("SELECT bezeichnung, datum_von, datum_bis, uhrzeit_von, uhrzeit_bis, wochentag FROM kurse WHERE wochentag = '" + tag + "';");
                c.closeConnection();

                if (dtable != null)
                {
                    for (int i = 0; i < dtable.Rows.Count; i++)
                    {
                        DataRow drow = dtable.Rows[i];

                        // Only row that have not been deleted
                        if (drow.RowState != DataRowState.Deleted)
                        {
                            // Define the list items
                            ListViewItem lvi = new ListViewItem(drow["bezeichnung"].ToString());
                            lvi.SubItems.Add(DateTime.Parse(drow["datum_von"].ToString()).ToString("dd.MM.yyyy"));
                            lvi.SubItems.Add(DateTime.Parse(drow["datum_bis"].ToString()).ToString("dd.MM.yyyy"));
                            lvi.SubItems.Add(DateTime.Parse(drow["uhrzeit_von"].ToString()).TimeOfDay.ToString("hh\\:mm"));
                            lvi.SubItems.Add(DateTime.Parse(drow["uhrzeit_bis"].ToString()).TimeOfDay.ToString("hh\\:mm"));
                            lvi.SubItems.Add(c_Helper.umwandlungIntInWochentag(Convert.ToInt32(drow["wochentag"])));
                            lvi.BackColor = Color.LimeGreen;


                            // Add the list items to the ListView
                            lvNewsHeute.Items.Add(lvi);
                        }
                    }
                }
            }
        }

        private void loadListKommend()
        {
            // Get the table
            int connected = c.openConnection();
            if (connected == 0)
            {
                // Clear the ListView control
                lvNewsKommend.Items.Clear();

                DateTime today = DateTime.Now;
                int tag = (int)today.DayOfWeek;
                int tag2 = 0;
                switch (tag) {
                    case 4:
                        tag2 = 6;
                        break;
                    case 5:
                        tag2 = 0;
                        break;
                    case 6:
                        tag2 = 1;
                        break;
                    default:
                        tag = tag + 2;
                        break;
                }

                DataTable dtable = c.select("SELECT bezeichnung, datum_von, datum_bis, uhrzeit_von, uhrzeit_bis, wochentag FROM kurse WHERE wochentag BETWEEN '" + tag + "' AND '" + tag2 + "';");
                c.closeConnection();

                if (dtable != null)
                {
                    for (int i = 0; i < dtable.Rows.Count; i++) // Alle Zeilen anschauen
                    {

                        DataRow drow = dtable.Rows[i];

                        // Only row that have not been deleted
                        if (drow.RowState != DataRowState.Deleted)
                        {
                            // Define the list items
                            ListViewItem lvi = new ListViewItem(drow["bezeichnung"].ToString());
                            lvi.SubItems.Add(DateTime.Parse(drow["datum_von"].ToString()).ToString("dd.MM.yyyy"));
                            lvi.SubItems.Add(DateTime.Parse(drow["datum_bis"].ToString()).ToString("dd.MM.yyyy"));
                            lvi.SubItems.Add(DateTime.Parse(drow["uhrzeit_von"].ToString()).TimeOfDay.ToString("hh\\:mm"));
                            lvi.SubItems.Add(DateTime.Parse(drow["uhrzeit_bis"].ToString()).TimeOfDay.ToString("hh\\:mm"));
                            lvi.SubItems.Add(c_Helper.umwandlungIntInWochentag(Convert.ToInt32(drow["wochentag"])));
                            lvi.BackColor = Color.HotPink;

                            // Add the list items to the ListView
                            lvNewsKommend.Items.Add(lvi);
                        }
                    }
                }
            }
        } 

        private void lvNewsAktuell_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) // Rechtsklick
            {
                // ContextMenuStrip mit ToolStipMenuItem erzeugen
                ContextMenuStrip myContextMenu = new ContextMenuStrip();
                ToolStripMenuItem toolStripItemAktualisieren = new ToolStripMenuItem("Aktualisieren (F5)");


                // Items hinzufügen
                myContextMenu.Items.Add(toolStripItemAktualisieren);

                // Und bei auswahl mit einem Bild versehen 
                toolStripItemAktualisieren.Image = PuG_Verwaltungssoftware.Properties.Resources.pug_refresh;

                // Handler der Items
                toolStripItemAktualisieren.Click += new EventHandler(toolStripItemAktualisiereNewsAktuell_Click);

                int currentMouseOverRow = gridKurse.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0) // In der Tabelle
                {
                    // Nix
                }

                myContextMenu.Show(lvNewsAktuell, new Point(e.X, e.Y));
            }
        }

        private void lvNewsHeute_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) // Rechtsklick
            {
                // ContextMenuStrip mit ToolStipMenuItem erzeugen
                ContextMenuStrip myContextMenu = new ContextMenuStrip();
                ToolStripMenuItem toolStripItemAktualisieren = new ToolStripMenuItem("Aktualisieren (F5)");


                // Items hinzufügen
                myContextMenu.Items.Add(toolStripItemAktualisieren);

                // Und bei auswahl mit einem Bild versehen 
                toolStripItemAktualisieren.Image = PuG_Verwaltungssoftware.Properties.Resources.pug_refresh;

                // Handler der Items
                toolStripItemAktualisieren.Click += new EventHandler(toolStripItemAktualisiereNewsHeute_Click);

                int currentMouseOverRow = gridKurse.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0) // In der Tabelle
                {
                    // Nix
                }

                myContextMenu.Show(lvNewsAktuell, new Point(e.X, e.Y));
            }
        }

        private void lvNewsKommend_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) // Rechtsklick
            {
                // ContextMenuStrip mit ToolStipMenuItem erzeugen
                ContextMenuStrip myContextMenu = new ContextMenuStrip();
                ToolStripMenuItem toolStripItemAktualisieren = new ToolStripMenuItem("Aktualisieren (F5)");


                // Items hinzufügen
                myContextMenu.Items.Add(toolStripItemAktualisieren);

                // Und bei auswahl mit einem Bild versehen 
                toolStripItemAktualisieren.Image = PuG_Verwaltungssoftware.Properties.Resources.pug_refresh;

                // Handler der Items
                toolStripItemAktualisieren.Click += new EventHandler(toolStripItemAktualisiereNewsKommend_Click);

                int currentMouseOverRow = gridKurse.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0) // In der Tabelle
                {
                    // Nix
                }

                myContextMenu.Show(lvNewsAktuell, new Point(e.X, e.Y));
            }
        }

        private void toolStripItemAktualisiereNewsAktuell_Click(object sender, EventArgs e)
        {
            listViewsLaden(1);
        }

        private void toolStripItemAktualisiereNewsHeute_Click(object sender, EventArgs e)
        {
            listViewsLaden(1);
        }

        private void toolStripItemAktualisiereNewsKommend_Click(object sender, EventArgs e)
        {
            listViewsLaden(1);
        }

        private void lvNewsAktuell_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F5) // Aktualisieren
            {
                listViewsLaden(1);
            }
        }

        private void lvNewsHeute_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F5) // Aktualisieren
            {
                listViewsLaden(1);
            }
        }

        private void lvNewsKommend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F5) // Aktualisieren
            {
                listViewsLaden(1);
            }
        }

    }
}
