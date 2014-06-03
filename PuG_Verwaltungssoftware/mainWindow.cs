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
                        loginPanel.Hide();
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

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Passwort") {
                tbPassword.Font = new Font(tbPassword.Font, FontStyle.Regular);
                tbPassword.Text = "";
                tbPassword.PasswordChar = char.Parse("*");
            }
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text == "") {
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
            c.openConnection();  // Datenbank oeffnen
            c.displayData("SELECT mitarbeiter_id, vorname, nachname, geburtsdatum FROM mitarbeiter;", gridMitarbeiter);
            c.closeConnection(); // Datenbank schliessen

            // Headertexte anpassen
            gridMitarbeiter.Columns["mitarbeiter_id"].HeaderText = "Mitarbeiter-Nr.";
            gridMitarbeiter.Columns["vorname"].HeaderText = "Vorname";
            gridMitarbeiter.Columns["nachname"].HeaderText = "Nachname";
            gridMitarbeiter.Columns["geburtsdatum"].HeaderText = "Geburtsdatum";



        }

        private void gridMitarbeiter_SelectionChanged(object sender, EventArgs e)
        {
            int row = gridMitarbeiter.CurrentCell.RowIndex;
            int id = Convert.ToInt32(gridMitarbeiter.Rows[row].Cells["mitarbeiter_id"].Value);
            //MessageBox.Show(id.ToString());
        }

        private void btMaOeffnen_Click(object sender, EventArgs e)
        {

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

        }
                
    }
}
