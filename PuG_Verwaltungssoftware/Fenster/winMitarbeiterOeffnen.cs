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
        /*
         * ******************************
         *     Variablendeklarationen
         * ******************************
         * */
        
        bool editMode = false;
        bool initOeffnen = true;
        int gId = 0;          // Mitarbeiter-Nr. des zu oeffnenden Users
        int gPosId = 0;       // Positions-ID des zu oeffnenden Users
        int gLoginMaId = 0;   // Mitarbeiter-Nr. des angemeldeten Users
        int gLoginPosId = 0;  // Positions-ID des angemeldeten Users

        c_DBConnect c = new c_DBConnect();
        
        DataGridView gGridView;
        private BindingSource bindingSourceMitarbeiter = new BindingSource();

        public winMitarbeiterOeffnen(int id, int loginId, int loginPosId, DataGridView grid)
        {
            InitializeComponent();
            
            // ID festlegen
            gId = id;
            gLoginMaId = loginId;
            gLoginPosId = loginPosId;

            // GridView zuweisen
            gGridView = grid;

        }


        /*
         * ******************************
         *         Control Events
         * ******************************
         * */

        private void winMitarbeiterOeffnen_Load(object sender, EventArgs e)
        {
            if (gLoginMaId != 1)
            {
                // Benutzer ist "normaler" Mitarbeiter
                gbGehalt.Visible = false;
                gbLoginDaten.Visible = false;
            }

            // Neues Mitarbeiter Objekt anlegen
            c_Mitarbeiter oeffneMitarbeiter = new c_Mitarbeiter();

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
            int dbConnectOk = c.openConnection();
            if (dbConnectOk == 0)
            {
                DataTable result = c.select("SELECT * FROM mitarbeiter WHERE mitarbeiter_id = '" + gId + "'");
                c.closeConnection();
                if (result != null)
                {
                    oeffneMitarbeiter.setVorname((String)result.Rows[0]["vorname"]);
                    oeffneMitarbeiter.setNachname((String)result.Rows[0]["nachname"]);
                    oeffneMitarbeiter.setGebDatum((result.Rows[0]["geburtsdatum"]).ToString());
                    oeffneMitarbeiter.setStrasse((String)result.Rows[0]["strasse"]);
                    oeffneMitarbeiter.setHausnummer((result.Rows[0]["hausnummer"]).ToString());
                    oeffneMitarbeiter.setPlz(Convert.ToInt32((result.Rows[0]["plz"])));
                    oeffneMitarbeiter.setOrt((String)result.Rows[0]["ort"]);
                    oeffneMitarbeiter.setGehalt(Convert.ToDouble((result.Rows[0]["gehalt"])));
                    oeffneMitarbeiter.setBenutzername((String)result.Rows[0]["benutzername"]);
                    oeffneMitarbeiter.setPositionId(Convert.ToInt32(result.Rows[0]["position_id"]));
                    gPosId = Convert.ToInt32(oeffneMitarbeiter.getPositionId());

                    dbConnectOk = c.openConnection();
                    DataTable result2 = c.select("SELECT * FROM positionen;");
                    c.closeConnection();

                    int[] arrPosId = new int[result2.Rows.Count];
                    string[] arrPosBez = new string[result2.Rows.Count];

                    if (dbConnectOk == 0)
                    {
                        
                        if (result2 != null)
                        {
                            for (int i = 0; i < result2.Rows.Count; i++)
                            {
                                arrPosId[i] = Convert.ToInt32(result2.Rows[i]["pos_id"]);
                                arrPosBez[i] = (result2.Rows[i]["bezeichnung"]).ToString();
                            }
                        }
                    }

                    for (int i = 0; i < arrPosId.Length; i++)
                    {
                        if (oeffneMitarbeiter.getPositionId() == (arrPosId[i]))
                        {
                            position = (arrPosBez[i]).ToString();
                        }
                    }
               

                    // Formatierungen
                    oeffneMitarbeiter.setGebDatum(oeffneMitarbeiter.getGebDatum().Substring(0, 10));

                    tbVorname.Text = oeffneMitarbeiter.getVorname();
                    tbNachname.Text = oeffneMitarbeiter.getNachname();
                    tbGebDatum.Text = oeffneMitarbeiter.getGebDatum();
                    dtpGebDatum.Text = oeffneMitarbeiter.getGebDatum();
                    tbStrasse.Text = oeffneMitarbeiter.getStrasse();
                    tbHausnummer.Text = oeffneMitarbeiter.getHausnummer();
                    tbPlz.Text = oeffneMitarbeiter.getPlz().ToString();
                    tbOrt.Text = oeffneMitarbeiter.getOrt();
                    tbGehalt.Text = oeffneMitarbeiter.getGehalt().ToString();
                    tbBenutzername.Text = oeffneMitarbeiter.getBenutzername();
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
                DialogResult dialogResult = MessageBox.Show("Wollen Sie das Fenster ohne zu Speichern schließen?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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

            if (gLoginPosId == 1)
            {
                // Textboxen readOnly --> false
                // Nur Chef darf Persoenliche Daten aendern
                foreach (Control control in gbDaten.Controls)
                {
                    if (control.GetType() == typeof(TextBox))
                    {
                        ((TextBox)control).ReadOnly = false;
                    }
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

            // Controls visible 
            tbPosition.Visible = false;
            ddlMitarbeiterPosition.Visible = true;

            if (gLoginPosId == 1)
            {
                tbGebDatum.Visible = false;
                dtpGebDatum.Visible = true;
            }
            

            // =====================================
            //     Combobox mit Werten befuellen
            // =====================================

            string bezeichnung = "";
            int id = 0;
            int pos = 0;

            if (initOeffnen == true)
            {
                int dBConnectOk = c.openConnection();
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
                                id = (int)result.Rows[i]["pos_id"];
                                ddlMitarbeiterPosition.Items.Add(bezeichnung);

                            }
                        }
                    }
                    c.closeConnection();
                }
                initOeffnen = false;
            }
            

            // Positionsbezeichnung abfragen
            string maPosBez = "";
            c.openConnection();  // Datenbank oeffnen
            DataTable result2 = c.select("SELECT pos_id, bezeichnung FROM positionen WHERE pos_id = '" + gPosId +"';");
            c.closeConnection(); // Datenbank schliessen
            if (result2 != null)
            {
                maPosBez = (result2.Rows[0]["bezeichnung"]).ToString();
            }

            // Combobox preselected Item
            for (int i = 0; i < ddlMitarbeiterPosition.Items.Count; i++)
            {
                if (ddlMitarbeiterPosition.Items[i].ToString() == maPosBez)
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

            if (editMode == true)
            {
                // Variablendeklaration
                String vorname = String.Empty;
                String nachname = String.Empty;
                String gebDatum = String.Empty;
                String strasse = String.Empty;
                String hausnummer = String.Empty;
                int plz = 0;
                String ort = String.Empty;
                double gehalt = 0.0;
                String benutzername = String.Empty;
                String position = String.Empty;

                String strSQL;
                int posId = 0;

                // Neues Mitarbeiter Objekt anlegen
                c_Mitarbeiter myMitarbeiter = new c_Mitarbeiter();


                // =====================================
                //   Ueberpruefung auf leere Textfelder
                // =====================================

                // Persoenliche Daten
                if (tbVorname.Text != "" && tbNachname.Text != "" && dtpGebDatum.Text != "")
                {
                    vorname = tbVorname.Text;
                    nachname = tbNachname.Text;
                    // GebDatum umformatieren
                    gebDatum = dtpGebDatum.Text;
                    DateTime date = Convert.ToDateTime(gebDatum);
                    gebDatum = date.ToString("yyyy-MM-dd");
                }
                else
                {
                    MessageBox.Show("Sie haben nicht alle Persönlichen Daten angegeben.", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    return;
                }

                // Anschrift
                if (tbStrasse.Text != "" && tbHausnummer.Text != "" && tbOrt.Text != "" && tbPlz.Text != "")
                {
                    strasse = tbStrasse.Text;
                    ort = tbOrt.Text;
                    if (c_Helper.wrongCharNumberExtra(tbHausnummer.Text) == false && c_Helper.numFormat(tbPlz.Text) == false)
                    {
                        hausnummer = tbHausnummer.Text;
                        plz = Convert.ToInt32(tbPlz.Text);
                    }
                    else
                    {
                        MessageBox.Show("Falsches Format für die Felder Hausnummer und Postleitzahl.\nIm Feld Postleitzahl dürfen nur Zahlen stehen.", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Sie haben nicht alle Anschrift-Daten angegeben.", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    return;
                }

                // Gehalt
                if (tbGehalt.Text != "")
                {
                    gehalt = Convert.ToDouble(tbGehalt.Text);
                    if (c_Helper.numFormatPunktKomma(gehalt.ToString()) == true)
                    {
                        MessageBox.Show("Falsches Format für das Feld Gehalt.", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Bitte Feld Gehalt ausfüllen.", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    return;
                }

                // Login - Daten
                if (tbBenutzername.Text != "" && ddlMitarbeiterPosition.Text != "")
                {
                    benutzername = tbBenutzername.Text;
                    position = ddlMitarbeiterPosition.SelectedItem.ToString();

                    // Ueberpruefen welche Position ausgewaehlt wurde
                    int dbConnectOk = c.openConnection();
                    DataTable result2 = c.select("SELECT * FROM positionen;");
                    c.closeConnection();

                    int[] arrPosId = new int[result2.Rows.Count];
                    string[] arrPosBez = new string[result2.Rows.Count];

                    if (dbConnectOk == 0)
                    {

                        if (result2 != null)
                        {
                            for (int i = 0; i < result2.Rows.Count; i++)
                            {
                                arrPosId[i] = Convert.ToInt32(result2.Rows[i]["pos_id"]);
                                arrPosBez[i] = (result2.Rows[i]["bezeichnung"]).ToString();
                            }
                        }
                    }

                    for (int i = 0; i < arrPosId.Length; i++)
                    {
                        if (position.Equals((arrPosBez[i]).ToString()))
                        {
                            posId = arrPosId[i];
                        }
                    }


                    //if (ddlMitarbeiterPosition.SelectedItem.ToString() == "Normal")
                    //{
                    //    posId = 2;
                    //}
                    //else if (ddlMitarbeiterPosition.SelectedItem.ToString() == "Chef")
                    //{
                    //    posId = 1;
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Keine Position ausgewählt.");
                    //    return;
                    //}
                }
                else
                {
                    MessageBox.Show("Login-Daten ausfüllen.", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    return;
                }

                myMitarbeiter.setVorname(vorname);
                myMitarbeiter.setNachname(nachname);
                myMitarbeiter.setGebDatum(gebDatum);
                myMitarbeiter.setStrasse(strasse);
                myMitarbeiter.setOrt(ort);
                myMitarbeiter.setHausnummer(hausnummer);
                myMitarbeiter.setPlz(plz);
                myMitarbeiter.setGehalt(gehalt);
                myMitarbeiter.setBenutzername(benutzername);
                myMitarbeiter.setPositionId(posId);


                int dBConnectOk = c.openConnection();
                if (dBConnectOk == 0)
                {
                    if (gLoginPosId == 1)
                    {
                        // String fuer Chef
                        strSQL = "UPDATE mitarbeiter SET position_id = '" + posId + "', benutzername = '" + benutzername + "', vorname = '" + vorname + "', nachname = '" + nachname + "', geburtsdatum = '" + gebDatum + "', strasse = '" + strasse + "', hausnummer = '" + hausnummer + "', plz = '" + plz + "', ort = '" + ort + "', gehalt = '" + (gehalt.ToString()).Replace(",", ".") + "' WHERE mitarbeiter_id = " + gId.ToString() + ";";
                    }
                    else
                    {
                        //String fuer Mitarbeiter
                        strSQL = "UPDATE mitarbeiter SET strasse = '" + strasse + "', hausnummer = '" + hausnummer + "', plz = '" + plz + "', ort = '" + ort + "' WHERE mitarbeiter_id = " + gId.ToString() + ";";
                    }
                    c.update(strSQL, "Mitarbeiter");
                    c.closeConnection();

                    gridMitarbeiterAktualisieren();
                    this.Close();  // Fenster schliessen
                }
            }

        }

        private void btPwAendern_Click(object sender, EventArgs e)
        {
            winMitarbeiterPasswort window = new winMitarbeiterPasswort(gLoginMaId, gId);
            window.Show();
        }


        /*
         * ******************************
         *        Eigene Methoden
         * ******************************
         * */

        private void gridMitarbeiterAktualisieren()
        {
            if (gLoginPosId == 1)
            {
                int dbConnect = c.openConnection();
                if (dbConnect == 0)
                {
                    c.displayData("SELECT mitarbeiter_id, vorname, nachname, geburtsdatum FROM mitarbeiter;", gGridView);
                    c.closeConnection();

                    // Headertexte anpassen
                    DataTable gridMitarbeiterTable = (DataTable)(gGridView.DataSource);
                    gridMitarbeiterTable.Columns["mitarbeiter_id"].ColumnName = "Mitarbeiter_ID";
                    gridMitarbeiterTable.Columns["vorname"].ColumnName = "Vorname";
                    gridMitarbeiterTable.Columns["nachname"].ColumnName = "Nachname";
                    gridMitarbeiterTable.Columns["geburtsdatum"].ColumnName = "Geburtsdatum";


                    // Binding Objekt zuweisen
                    bindingSourceMitarbeiter.DataSource = gGridView.DataSource;
                    gGridView.DataSource = bindingSourceMitarbeiter;
                }
                else
                {
                    MessageBox.Show("Verbindungsfehler!\nÜbersicht konnte nicht aktualisiert werden.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                int dbConnect = c.openConnection();
                if (dbConnect == 0)
                {
                    c.displayData("SELECT mitarbeiter_id, vorname, nachname, geburtsdatum FROM mitarbeiter WHERE mitarbeiter_id = '" + gLoginMaId + "';", gGridView);
                    c.closeConnection();

                    // Headertexte anpassen
                    DataTable gridMitarbeiterTable = (DataTable)(gGridView.DataSource);
                    gridMitarbeiterTable.Columns["mitarbeiter_id"].ColumnName = "Mitarbeiter_ID";
                    gridMitarbeiterTable.Columns["vorname"].ColumnName = "Vorname";
                    gridMitarbeiterTable.Columns["nachname"].ColumnName = "Nachname";
                    gridMitarbeiterTable.Columns["geburtsdatum"].ColumnName = "Geburtsdatum";


                    // Binding Objekt zuweisen
                    bindingSourceMitarbeiter.DataSource = gGridView.DataSource;
                    gGridView.DataSource = bindingSourceMitarbeiter;
                }
                else
                {
                    MessageBox.Show("Verbindungsfehler!\nÜbersicht konnte nicht aktualisiert werden.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

    }
}
