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
    public partial class winKursNeu : Form
    {       
        public winKursNeu()
        {
            InitializeComponent();

            string vorname    = "";
            string nachname   = "";
            c_DBConnect c = new c_DBConnect();

            int dBConnectOk = c.openConnection();
            if (dBConnectOk == 0)
            {
                int rows = c.countRows("SELECT COUNT(*) FROM mitarbeiter;");
                if (rows > 0)
                {
                    DataTable result = c.select("SELECT vorname, nachname FROM mitarbeiter;");
                    if (result != null)
                    {
                        for (int i = 0; i < rows; i++)
                        {
                            vorname = (String)result.Rows[i]["vorname"];
                            nachname = (String)result.Rows[i]["nachname"];
                            string vollerName = vorname + " " + nachname;
                            cbKursleiter.Items.Add(vollerName);
                        }
                    }
                }
                c.closeConnection();
            }
        }

        private void btSchliessen_Click(object sender, EventArgs e)
        {
            // Fenster schliessen
            if (tbBezeichnung.Text.Trim().Length != 0 || cbKursleiter.SelectedIndex != -1 || tbPreis.Text.Trim().Length != 0 
                || tbMaxTeilnehmer.Text.Trim().Length != 0 || tbWochentag.Text.Trim().Length != 0 || tbWochentag.Text.Trim().Length != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Wollen Sie das Fenster ohne zu Speichern schließen?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
            
        }

        private void btSpeichern_Click(object sender, EventArgs e)
        {
            c_Kurse myKurse = new c_Kurse();
            bool wrongFormat = false;

            wrongFormat = c_Helper.wrongCharacters(tbBezeichnung.Text);
            if(wrongFormat == false)
            {
                myKurse.setBezeichnung(tbBezeichnung.Text);
            }  
            
            myKurse.setKursleiter(cbKursleiter.SelectedIndex);
            myKurse.setPreis(Convert.ToDouble(tbPreis.Text));
            
            myKurse.setMaxTeilnehmer(Convert.ToInt32(tbMaxTeilnehmer.Text));

            DateTime time = DateTime.Parse(dtpVon.Text);

            myKurse.setVon(dtpVon.Text);
            myKurse.setBis(dtpBis.Text);

            wrongFormat = c_Helper.wrongCharacters(tbWochentag.Text);
            if (wrongFormat == false)
            {
                myKurse.setWochentag(tbWochentag.Text);
            }

            wrongFormat = c_Helper.wrongCharacters(tbUhrzeit.Text);
            if (wrongFormat == false)
            {
                myKurse.setUhrzeit(tbUhrzeit.Text);
            }

            if (wrongFormat == true)
            {
                MessageBox.Show("Ungültige Zeichen gefunden. Überprüfen Sie bitte ihre Eingaben", "Information");
            }
            else
            {
                c_DBConnect c = new c_DBConnect();
                int dBConnectOk = c.openConnection();
                if (dBConnectOk == 0)
                {
                    c.insert("INSERT INTO kurse(kursleiter_id, bezeichnung, preis, akt_teilnehmer, max_teilnehmer, von, bis, wochentag, uhrzeit) " +
                             "VALUES (" + cbKursleiter.SelectedIndex.ToString() + ", " + tbBezeichnung.Text + ", " + tbPreis.Text + ", 0, " +
                             tbMaxTeilnehmer.Text + ", " + dtpVon.Text + "," + dtpBis.Text + "," + tbWochentag.Text + ", " + tbUhrzeit.Text  + ");", "Kurs");
                    c.closeConnection();
                }
            }
        }
    }
}
