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
    public partial class mainWindow : Form
    {
        c_DBConnect c = new c_DBConnect();
        private int s = 0;
        private int m = 0;
        private int h = 0;

        private bool initHome = false;
        private bool initKursUebersicht = false;
        private BindingSource bindingSourceKursUebersicht = new BindingSource();

        public mainWindow()
        {
            InitializeComponent();
        }

        private void miBeenden_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mitarbeiterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mainTabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = mainTabControl.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = mainTabControl.GetTabRect(e.Index);

            // Set tab size 
            //mainTabControl.SizeMode = TabSizeMode.Fixed;

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.Black);
                g.FillRectangle(Brushes.LightSteelBlue, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Calibri", (float)16.0, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            // Verbindung ueberpruefen
            int dBConnectOk = c.openConnection();
            if (dBConnectOk == 0)
            {
                // Benutzername und Passwort ueberpruefen
                String benutzer = tbUsername.Text;
                String passwort = tbPassword.Text;

                passwort = c_Helper.encrypt(passwort);

                if (benutzer == "Benutzername" || passwort == "Passwort")
                {
                    lbLoginMessage.Text = "Bitte Benutzer und Passwort eingeben.";
                    c.closeConnection();
                }
                else
                {
                    // Ueberpruefen ob Select-Befehl Zeilen zurueck liefert
                    bool hasRows = c.count("SELECT * FROM mitarbeiter WHERE benutzername = '" + benutzer + "' AND passwort = '" + passwort + "';");
                    if (hasRows == true)
                    {
                        // Mitarbeiter-ID aus Datenbank holen
                        try
                        {
                            c.closeConnection();
                            c.openConnection();
                            DataTable result = c.select("SELECT * FROM mitarbeiter WHERE benutzername = '" + benutzer + "'");
                            if (result != null)
                            {
                                loginMaId = (int)result.Rows[0]["mitarbeiter_id"];
                                loginMaVorname = (String)result.Rows[0]["vorname"];
                                loginMaNachname = (String)result.Rows[0]["nachname"];
                                loginMaPosId = (int)result.Rows[0]["position_id"];
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }


                        // Timer anlegen
                        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                        timer.Interval = 999;
                        timer.Enabled = true;
                        // Timer starten
                        timer.Start();
                        // EventHandler
                        timer.Tick += new EventHandler(TimerEvent);

                        // Willkommenstext
                        lbMitarbeiterName.Text = loginMaVorname + " " + loginMaNachname;

                        // LoginPanel schliessen
                        loginPanel.Hide();
                        // Datenbankverbindung schliesen
                        c.closeConnection();

                    }
                    else
                    {
                        lbLoginMessage.Text = "Benutzername oder Passwort falsch.";
                        c.closeConnection();
                    }

                }
            }
            else
            {
                lbLoginMessage.Text = "Verbindung zum Server fehlgeschlagen.";
                c.closeConnection();
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

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Passwort")
            {
                tbPassword.Font = new Font(tbPassword.Font, FontStyle.Regular);
                tbPassword.Text = "";
                tbPassword.PasswordChar = char.Parse("*");
            }
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text == "")
            {
                tbPassword.Font = new Font(tbPassword.Font, FontStyle.Italic);
                tbPassword.PasswordChar = char.Parse("\0");
                tbPassword.Text = "Passwort";
            }
        }

        private void tbUsername_Enter(object sender, EventArgs e)
        {
            if (tbUsername.Text == "Benutzername")
            {
                tbUsername.Font = new Font(tbUsername.Font, FontStyle.Regular);
                tbUsername.Text = "";
            }
        }

        private void tbUsername_Leave(object sender, EventArgs e)
        {
            if (tbUsername.Text == "")
            {
                tbUsername.Font = new Font(tbUsername.Font, FontStyle.Italic);
                tbUsername.Text = "Benutzername";
            }
        }

        private void tabPageHome_Enter(object sender, EventArgs e)
        {
            // Listview-Eintraege hinzufuegen
            loadList();
        }

        private void btMgOeffnen_Click(object sender, EventArgs e)
        {
            winMitgliedOeffnen window = new winMitgliedOeffnen();
            window.Show();
        }

        private void btMgNeu_Click(object sender, EventArgs e)
        {
            winMitgliedNeu window = new winMitgliedNeu();
            window.Show();
        }

        private void btMgLoeschen_Click(object sender, EventArgs e)
        {
            if (gridMitglieder.RowCount >= 1)
            {
                int row = gridMitglieder.CurrentCell.RowIndex;
                int id = Convert.ToInt32(gridMitglieder.Rows[row].Cells["mitglieder_id"].Value);

                DialogResult dialogResult = MessageBox.Show("Wollen Sie das ausgewählte Mitglied mit der Mitglieds-Nr. '" + id + "' wirklich löschen?", "Information", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {

                    //do something
                    c.openConnection();
                    c.delete("DELETE FROM mitglieder WHERE mitglieder_id = '" + id + "';", "Mitglied");
                    //c.displayData("SELECT mitarbeiter_id, vorname, nachname, geburtsdatum FROM mitarbeiter;", gridMitarbeiter);  // GridView aktualisieren
                    c.closeConnection();
                }
            }

            else
            {
                // Meesagebox
            }
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {

        }
        //*************************Maxi**********************************
        // private BindingSource bindingSourceKursUebersicht = new BindingSource();
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

                c_Helper.changeColumnDataType(gridKursUebersichtTable, "Wochentag", typeof(String), 6);// Wochentag muss in Spalte 6!

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

        private void btKursUebersichtNeu_Click(object sender, EventArgs e)
        {

        }

        // Initialize ListView
        private void initializeListView()
        {
            // Set the view to show details.
            lvNachrichten.View = View.Details;

            // Allow the user to rearrange columns.
            lvNachrichten.AllowColumnReorder = true;

            // Select the item and subitems when selection is made.
            lvNachrichten.FullRowSelect = true;

            // Display grid lines.
            lvNachrichten.GridLines = false;

            // Sort the items in the list in ascending order.
            lvNachrichten.Sorting = SortOrder.Ascending;

            // Attach Subitems to the ListView
            lvNachrichten.Columns.Add("Bezeichnung", 150, HorizontalAlignment.Left);
            lvNachrichten.Columns.Add("Datum Von", 100, HorizontalAlignment.Left);
            lvNachrichten.Columns.Add("Datum Bis", 100, HorizontalAlignment.Left);
            lvNachrichten.Columns.Add("Uhrzeit Von", 100, HorizontalAlignment.Left);
            lvNachrichten.Columns.Add("Uhrzeit Bis", 100, HorizontalAlignment.Left);
            lvNachrichten.Columns.Add("Wochentag", 100, HorizontalAlignment.Left);
        }

        private void loadList()
        {
            // Get the table
            int connected = c.openConnection();
            if (connected == 0)
            {
                if (initHome == false)
                {
                    // Listview initialisieren
                    initializeListView();

                    // Clear the ListView control
                    lvNachrichten.Items.Clear();

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
                                        lvNachrichten.Items.Add(lvi);
                                    }
                                }
                                else
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
                                        lvNachrichten.Items.Add(lvi);
                                    }
                                }
                            }
                            else
                            {

                            }
                        }
                        else
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
                                lvNachrichten.Items.Add(lvi);
                            }
                        }
                    }
                    initHome = true;
                }
            }
        }
    }
}