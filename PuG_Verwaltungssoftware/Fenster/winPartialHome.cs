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
    public partial class mainWindow : Form
    {
        private int s = 0;
        private int m = 0;
        private int h = 0;


        private void tabPageHome_Enter(object sender, EventArgs e)
        {
            if (initHome == false)
            {
                // Listview initialisieren
                initializeListView();

                // Listview-Eintraege hinzufuegen
                loadListAktuell();
                loadListHeute();
                loadListKommend();

                initHome = true;
            }         
        }

        private void TimerEvent(object sender, EventArgs e)
        {
            if (s < 59)
            {
                s = s + 1;
            }
            else
            {
                s = 0;
                if (m < 59)
                {
                    m = m + 1;
                }
                else
                {
                    m = 0;
                    h = h + 1;
                }

            }

            // Timer ausgabe und String Format
            lbTimer.Text = String.Format("{0:00}", h) + ":" + String.Format("{0:00}", m) + ":" + String.Format("{0:00}", s);

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
                                    lvi.SubItems.Add(drow["datum_von"].ToString());
                                    lvi.SubItems.Add(drow["datum_bis"].ToString());
                                    lvi.SubItems.Add(drow["uhrzeit_von"].ToString());
                                    lvi.SubItems.Add(drow["uhrzeit_bis"].ToString());
                                    lvi.SubItems.Add(drow["wochentag"].ToString());
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

        private void loadListHeute()
        {
            // Get the table
            int connected = c.openConnection();
            if (connected == 0)
            {

                // Clear the ListView control
                lvNewsHeute.Items.Clear();

                DataTable dtable = c.select("SELECT bezeichnung, datum_von, datum_bis, uhrzeit_von, uhrzeit_bis, wochentag FROM kurse;");
                c.closeConnection();

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
                            if (!(today.TimeOfDay > beginnUhrzeit.TimeOfDay && today.TimeOfDay < endUhrzeit.TimeOfDay)) // Wenn Uhrzeit passt
                            {
                                DataRow drow = dtable.Rows[i];

                                // Only row that have not been deleted
                                if (drow.RowState != DataRowState.Deleted)
                                {
                                    // Define the list items
                                    ListViewItem lvi = new ListViewItem(drow["bezeichnung"].ToString());
                                    lvi.SubItems.Add(drow["datum_von"].ToString());
                                    lvi.SubItems.Add(drow["datum_bis"].ToString());
                                    lvi.SubItems.Add(drow["uhrzeit_von"].ToString());
                                    lvi.SubItems.Add(drow["uhrzeit_bis"].ToString());
                                    lvi.SubItems.Add(drow["wochentag"].ToString());
                                    lvi.BackColor = Color.Red;

                                    // Add the list items to the ListView
                                    lvNewsHeute.Items.Add(lvi);
                                }
                            }                               
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

                DataTable dtable = c.select("SELECT bezeichnung, datum_von, datum_bis, uhrzeit_von, uhrzeit_bis, wochentag FROM kurse;");
                c.closeConnection();

                DateTime today = DateTime.Now;

                for (int i = 0; i < dtable.Rows.Count; i++) // Alle Zeilen anschauen
                {
                    DateTime beginnDate = DateTime.Parse(dtable.Rows[i]["datum_von"].ToString());
                    DateTime endDate = DateTime.Parse(dtable.Rows[i]["datum_bis"].ToString());
                    if (!(today >= beginnDate && today <= endDate || beginnDate == endDate)) // Wenn ein laufender Kurs
                    {
                        DataRow drow = dtable.Rows[i];

                        // Only row that have not been deleted
                        if (drow.RowState != DataRowState.Deleted)
                        {
                            // Define the list items
                            ListViewItem lvi = new ListViewItem(drow["bezeichnung"].ToString());
                            lvi.SubItems.Add(drow["datum_von"].ToString());
                            lvi.SubItems.Add(drow["datum_bis"].ToString());
                            lvi.SubItems.Add(drow["uhrzeit_von"].ToString());
                            lvi.SubItems.Add(drow["uhrzeit_bis"].ToString());
                            lvi.SubItems.Add(drow["wochentag"].ToString());
                            lvi.BackColor = Color.Yellow;

                            // Add the list items to the ListView
                            lvNewsKommend.Items.Add(lvi);
                        }
                    }
                }
            }
        }
    }
}
