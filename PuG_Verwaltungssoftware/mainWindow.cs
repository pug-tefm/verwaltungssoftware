﻿using PuG_Verwaltungssoftware.Klassen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuG_Verwaltungssoftware
{
    public partial class mainWindow : Form
    {
        c_Helper myHelper = new c_Helper();
        c_DBConnect c = new c_DBConnect();

        private bool initHome = false;
        private bool initKursUebersicht = false;

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public mainWindow()
        {
            InitializeComponent();

            // ToolTips generieren
            c_Helper.setToolTip(btMaNeu, "Neu");
            c_Helper.setToolTip(btMgNeu, "Neu");
            c_Helper.setToolTip(btKursNeu, "Neu");

            c_Helper.setToolTip(btMaOeffnen, "Öffnen");
            c_Helper.setToolTip(btMgOeffnen, "Öffnen");
            c_Helper.setToolTip(btKursOeffnen, "Öffnen");
            c_Helper.setToolTip(btKursUebersichtOeffnen, "Öffnen");

            c_Helper.setToolTip(btMaLoeschen, "Löschen");
            c_Helper.setToolTip(btMgLoeschen, "Löschen");
            c_Helper.setToolTip(btKursLoeschen, "Löschen");

            // Versionsnummer einfügen
            lbVersion.Text = "Version " + this.ProductVersion;
        }

        private void miBeenden_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                        timer = new System.Windows.Forms.Timer();
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

        private void btAbmelden_Click(object sender, EventArgs e)
        {
            // Benutzer und Passwort Textbox anpassen
            tbUsername.Font = new Font(tbUsername.Font, FontStyle.Italic);
            tbUsername.Text = "Benutzername";

            tbPassword.Font = new Font(tbPassword.Font, FontStyle.Italic);
            tbPassword.PasswordChar = char.Parse("\0");
            tbPassword.Text = "Passwort";

            // Timer zuruecksetzen
            timer.Stop();
            lbTimer.Text = "00:00:00";
            s = 0;
            m = 0;
            h = 0;

            // TabPage auswaehlen
            newsTabControl.SelectedTab = tabPageAktuell;

            // Panel anzeigen
            loginPanel.Visible = true;
            loginPanel.BringToFront();
        }


        // Hintergrundfarbe Hauptfenster
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.Gray, Color.Black, 90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        // Hauptfenster aktualisieren bei Groessenveraenderung
        private void mainWindow_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }

    }
}