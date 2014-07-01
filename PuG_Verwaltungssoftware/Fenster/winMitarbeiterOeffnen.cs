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
    public partial class winMitarbeiterOeffnen : Form
    {
        bool editMode = false;
        bool save = false;
        int gId = 0;
        int gPosId = 0;
        int gLoginMaId = 0;
        DataGridView gGridView;

        public winMitarbeiterOeffnen(int id, int loginId, DataGridView grid)
        {
            InitializeComponent();
            
            // ID festlegen
            gId = id;
            gLoginMaId = loginId;

            // GridView zuweisen
            gGridView = grid;

        }

        private void winMitarbeiterOeffnen_Load(object sender, EventArgs e)
        {
            if (gLoginMaId != 1)
            {
                // Benutzer ist "normaler" Mitarbeiter
                gbGehalt.Visible = false;
                gbLoginDaten.Visible = false;
            }

            // Variablendeklaration
            String vorname = String.Empty;
            String nachname = String.Empty;
            String gebDatum = String.Empty;
            String strasse = String.Empty;
            String hausnummer = String.Empty;
            String plz = String.Empty;
            String ort = String.Empty;
            String gehalt = String.Empty;
            String benutzername = String.Empty;
            String position = String.Empty;

            // Mitarbeiter-Daten abrufen
            c_DBConnect c = new c_DBConnect();
            int dbConnectOk = c.openConnection();
            if (dbConnectOk == 0)
            {
                DataTable result = c.select("SELECT * FROM mitarbeiter WHERE mitarbeiter_id = '" + gId + "'");
                if (result != null)
                {
                    vorname = (String)result.Rows[0]["vorname"];
                    nachname = (String)result.Rows[0]["nachname"];
                    gebDatum = (result.Rows[0]["geburtsdatum"]).ToString();
                    strasse = (String)result.Rows[0]["strasse"];
                    hausnummer = (result.Rows[0]["hausnummer"]).ToString();
                    plz = (result.Rows[0]["plz"]).ToString();
                    ort = (String)result.Rows[0]["ort"];
                    gehalt = (result.Rows[0]["gehalt"]).ToString();
                    benutzername = (String)result.Rows[0]["benutzername"];
                    position = (result.Rows[0]["position_id"]).ToString();
                    gPosId = Convert.ToInt32(position);
                    if (position == "1")
                    {
                        position = "Chef";
                    }
                    else
                    {
                        position = "Normal";
                    }

                    // Formatierungen
                    gebDatum = gebDatum.Substring(0, 10);

                    tbVorname.Text = vorname;
                    tbNachname.Text = nachname;
                    tbGebDatum.Text = gebDatum;
                    tbStrasse.Text = strasse;
                    tbHausnummer.Text = hausnummer;
                    tbPlz.Text = plz;
                    tbOrt.Text = ort;
                    tbGehalt.Text = gehalt;
                    tbBenutzername.Text = benutzername;
                    tbPosition.Text = position;
                    
                }

                // Datenbankverbindung schliessen
                c.closeConnection();
            }
        }

        private void btSchliessen_Click(object sender, EventArgs e)
        {
            // Fenster schliessen
            if (editMode == true)
            {
                // MessageBox schliessen ohne speichern
                // ######## unvollständig ##########
                DialogResult dialogResult = MessageBox.Show("Wollen Sie das Fenster ohne zu Speichern schließen?", "Information", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {

                }
            }
            else
            {
                this.Close();
            }
            
        }

        private void btBearbeiten_Click(object sender, EventArgs e)
        {
            // Globale Variable true setzen
            editMode = true;
            
            // Textboxen readOnly --> false
            foreach (Control control in gbDaten.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    ((TextBox)control).ReadOnly = false;
                }
            }
            foreach (Control control in gbAnschrift.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    ((TextBox)control).ReadOnly = false;
                }
            }
            foreach (Control control in gbGehalt.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    ((TextBox)control).ReadOnly = false;
                }
            }
            foreach (Control control in gbLoginDaten.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    ((TextBox)control).ReadOnly = false;
                }
            }

            tbPosition.Visible = false;
            ddlMitarbeiterPosition.Visible = true;

            // =====================================
            //     Combobox mit Werten befuellen
            // =====================================

            string bezeichnung = "";
            int pos = 0;

            c_DBConnect c = new c_DBConnect();
            int dBConnectOk = c.openConnection();
            //int dBConnectOk = 0;
            if (dBConnectOk == 0)
            {
                int rows = c.countRows("SELECT COUNT(*) FROM positionen;");
                if (rows > 0)
                {
                    DataTable result = c.select("SELECT pos_id, bezeichnung FROM positionen;");
                    if (result != null)
                    {
                        for (int i = 0; i < rows; i++)
                        {
                            bezeichnung = (String)result.Rows[i]["bezeichnung"];
                            ddlMitarbeiterPosition.Items.Add(bezeichnung);
                        }
                    }
                }
                c.closeConnection();
            }

            // Combobox preselected Item
            for (int i = 0; i < ddlMitarbeiterPosition.Items.Count; i++)
            {
                if (ddlMitarbeiterPosition.Items[i].ToString() == "Normal")
                {
                    pos = i;
                }
            }
            if (gPosId == 1)
            {
                ddlMitarbeiterPosition.SelectedIndex = 0;
            }
            else
            {
                ddlMitarbeiterPosition.SelectedIndex = pos; 
            }
                  
        }

        private void btSpeichern_Click(object sender, EventArgs e)
        {
            // Globale Variable true setzen
            save = true;

            if (editMode == true)
            {
                // Variablendeklaration
                String vorname = String.Empty;
                String nachname = String.Empty;
                String gebDatum = String.Empty;
                String strasse = String.Empty;
                String hausnummer = String.Empty;
                String plz = String.Empty;
                String ort = String.Empty;
                String gehalt = String.Empty;
                String benutzername = String.Empty;
                String position = String.Empty;

                String strSQL;
                int posId;

                // Neues Mitarbeiter Objekt anlegen
                c_Mitarbeiter myMitarbeiter = new c_Mitarbeiter();

                // Wertzuweisungen
                vorname = tbVorname.Text;
                nachname = tbNachname.Text;
                gebDatum = tbGebDatum.Text;
                strasse = tbStrasse.Text;
                hausnummer = tbHausnummer.Text;
                plz = tbPlz.Text;
                ort = tbOrt.Text;
                gehalt = tbGehalt.Text;
                benutzername = tbBenutzername.Text;
                position = ddlMitarbeiterPosition.SelectedItem.ToString();
                if (position == "Chef")
                {
                    position = "1";
                }
                else
                {
                    position = "2";
                }

                strSQL = String.Empty;
                posId = 0;

                // Formatierungen und Konvertierungen
                DateTime date = Convert.ToDateTime(gebDatum);
                gebDatum = date.ToString("yyyy-MM-dd");

                if (tbPosition.Text == "Normal")
                {
                    posId = 2;
                }
                else if (tbPosition.Text == "Chef")
                {
                    posId = 1;
                }

                myMitarbeiter.setVorname(vorname);
                myMitarbeiter.setNachname(nachname);
                myMitarbeiter.setGebDatum(gebDatum);
                myMitarbeiter.setStrasse(strasse);
                myMitarbeiter.setOrt(ort);
                myMitarbeiter.setHausnummer(hausnummer);
                myMitarbeiter.setPlz(Convert.ToInt32(plz));
                myMitarbeiter.setGehalt(Convert.ToDouble(gehalt));
                myMitarbeiter.setBenutzername(benutzername);
                myMitarbeiter.setPositionId(posId);

                c_DBConnect c = new c_DBConnect();
                int dBConnectOk = c.openConnection();
                if (dBConnectOk == 0)
                {
                    strSQL = "UPDATE mitarbeiter SET benutzername = '" + benutzername + "', vorname = '" + vorname + "', nachname = '" + nachname + "', geburtsdatum = '" + gebDatum + "', strasse = '" + strasse + "', hausnummer = " + hausnummer + ", plz = " + plz + ", ort = '" + ort + "', gehalt = '" + gehalt + "' WHERE mitarbeiter_id = " + gId.ToString() +";";
                    c.update(strSQL, "Mitarbeiter");
                    c.closeConnection();
                    c.displayData("SELECT mitarbeiter_id, vorname, nachname, geburtsdatum FROM mitarbeiter;", gGridView);

                    this.Close();  // Fenster schliessen
                }
            }

        }

        private void btPwAendern_Click(object sender, EventArgs e)
        {
            winMitarbeiterPasswort window = new winMitarbeiterPasswort(gLoginMaId, gId);
            window.Show();
        }

    }
}
