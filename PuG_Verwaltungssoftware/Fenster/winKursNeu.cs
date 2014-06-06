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
                int rows = c.countRows("SELECT vorname, nachname FROM mitarbeiter;");
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
            if (tbBezeichnung.Text != "" || cbKursleiter.SelectedIndex != -1 || tbPreis.Text != "" || tbMaxTeilnehmer.Text != "" || dtpVon.Text != ""
                || dtpBis.Text != "" || tbWochentag.Text != "" || tbWochentag.Text != "")
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
            string bezeichnung;
            bool wrongFormat = false;

            wrongFormat = c_Helper.wrongCharacters(tbBezeichnung.Text);
            if(wrongFormat == false)
            {
                myKurse.setBezeichnung(tbBezeichnung.Text);
            }

            myKurse.setKursleiter(cbKursleiter.SelectedIndex);
            myKurse.setPreis(Convert.ToDouble(lbPreis.Text));
            myKurse.setMaxTeilnehmer(Convert.ToInt32(tbMaxTeilnehmer.Text));
            myKurse.setVon(dtpVon.Text);
            myKurse.setBis(dtpBis.Text);
            myKurse.setWochentag(tbWochentag.Text);
            myKurse.setUhrzeit(tbUhrzeit.Text);

            if(wrongFormat == true)
            {
                MessageBox.Show("Ungültige Zeichen gefunden. Überprüfen Sie bitte ihre Eingaben", "Information");
            }

            c_DBConnect c = new c_DBConnect();
            int dBConnectOk = c.openConnection();
            if (dBConnectOk == 0)
            {
                c.insert("INSERT INTO kurse(,) VALUES (,);", "Kurs");
                c.closeConnection();
            }
        }
    }
}
