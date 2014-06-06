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
        int s = 0;
        int m = 0;
        int h = 0;
        int loginMaId = 0;
        String loginMaVorname = String.Empty;
        String loginMaNachname = String.Empty;


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
            mainTabControl.SizeMode = TabSizeMode.Fixed;

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
                    }

                }
            }
            else
            {
                lbLoginMessage.Text = "Verbindung zum Server fehlgeschlagen.";
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

        private void tabPageMitarbeiter_Enter(object sender, EventArgs e)
        {
            int dBConnectOk = c.openConnection();  // Datenbank oeffnen
            c.displayData("SELECT mitarbeiter_id, vorname, nachname, geburtsdatum FROM mitarbeiter;", gridMitarbeiter);
            c.closeConnection(); // Datenbank schliessen

            if (dBConnectOk == 0)
            {
                // Headertexte anpassen
                gridMitarbeiter.Columns["mitarbeiter_id"].HeaderText = "Mitarbeiter-Nr.";
                gridMitarbeiter.Columns["vorname"].HeaderText = "Vorname";
                gridMitarbeiter.Columns["nachname"].HeaderText = "Nachname";
                gridMitarbeiter.Columns["geburtsdatum"].HeaderText = "Geburtsdatum";
            }

        }

        private void gridMitarbeiter_SelectionChanged(object sender, EventArgs e)
        {
            int row = gridMitarbeiter.CurrentCell.RowIndex;
            int id = Convert.ToInt32(gridMitarbeiter.Rows[row].Cells["mitarbeiter_id"].Value);
            //MessageBox.Show(id.ToString());
        }

        private void btMaOeffnen_Click(object sender, EventArgs e)
        {
            winMitarbeiterOeffnen window = new winMitarbeiterOeffnen();
            window.Show();
        }

        private void btMaLoeschen_Click(object sender, EventArgs e)
        {
            int row = gridMitarbeiter.CurrentCell.RowIndex;
            int id = Convert.ToInt32(gridMitarbeiter.Rows[row].Cells["mitarbeiter_id"].Value);

            DialogResult dialogResult = MessageBox.Show("Wollen Sie den ausgewählten Mitarbeiter mit der Mitarbeiter-Nr. '" + id + "' wirklich löschen?", "Information", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                c.openConnection();
                c.delete("DELETE FROM mitarbeiter WHERE mitarbeiter_id = '" + id + "';", "Mitarbeiter");
                //c.displayData("SELECT mitarbeiter_id, vorname, nachname, geburtsdatum FROM mitarbeiter;", gridMitarbeiter);  // GridView aktualisieren
                c.closeConnection();
            }

        }

        private void btMaNeu_Click(object sender, EventArgs e)
        {
            winMitarbeiterNeu window = new winMitarbeiterNeu();
            window.Show();
        }

        private void tabPageHome_Enter(object sender, EventArgs e)
        {

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

        private void btKursLoeschen_Click(object sender, EventArgs e)
        {
            {
                if (gridKurse.RowCount >= 1)
                {

                    int row = gridKurse.CurrentCell.RowIndex;
                    int id = Convert.ToInt32(gridKurse.Rows[row].Cells["kurs_id"].Value);

                    DialogResult dialogResult = MessageBox.Show("Wollen Sie den ausgewählten Kurs mit der Kurs-Nr. '" + id + "' wirklich löschen?", "Information", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {

                        //do something
                        c.openConnection();
                        c.delete("DELETE FROM kurse WHERE kurs_id = '" + id + "';", "Kurs");
                        //c.displayData("SELECT mitarbeiter_id, vorname, nachname, geburtsdatum FROM mitarbeiter;", gridMitarbeiter);  // GridView aktualisieren
                        c.closeConnection();
                    }
                }

                else
                {
                    // Messagebox
                }
            }

        }

        private void btKursNeu_Click(object sender, EventArgs e)
        {
            winKursNeu window = new winKursNeu();
            window.Show();
        }

        private void btKursOeffnen_Click(object sender, EventArgs e)
        {
            winKursOeffnen window = new winKursOeffnen();
            window.Show();
        }

        private void tabPageKurse_Enter(object sender, EventArgs e)
        {
            int dBConnectOk = c.openConnection();  // Datenbank öffnen
            if (dBConnectOk == 0)
            {
                c.displayData("SELECT * FROM kurse;", gridKurse); // Kurse aus db in Grid View laden

                // Headertexte anpassen
                //gridKurse.Columns["mitarbeiter_id"].HeaderText = "Mitarbeiter-Nr.";
                //gridKurse.Columns["vorname"].HeaderText = "Vorname";
                //gridKurse.Columns["nachname"].HeaderText = "Nachname";
                //gridKurse.Columns["geburtsdatum"].HeaderText = "Geburtsdatum";
                
                c.closeConnection(); // Datenbank schliessen
            } 
        }
    }
}
