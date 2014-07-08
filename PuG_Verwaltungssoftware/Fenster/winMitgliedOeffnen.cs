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

// Erik
namespace PuG_Verwaltungssoftware
{
    public partial class winMitgliedOeffnen : Form
    {
        // Variablen
        bool editMode = false;
        bool initOeffnen = true;
        int mId = 0;

        DataGridView gridMitglieder;
        private BindingSource bindingSourceMitglieder = new BindingSource();
        c_DBConnect c = new c_DBConnect();

        public winMitgliedOeffnen(int id, DataGridView grid)
        {
            InitializeComponent();
            mId = id;
            gridMitglieder = grid;
        }

        private void winMitgliedOeffnen_Load(object sender, EventArgs e)
        {
            // Mitglieder Objekt erstellen
            c_Mitglieder openMitglied = new c_Mitglieder();

            // Mitarbeiter-Daten abrufen
            int dbConnectOk = c.openConnection();
            if (dbConnectOk == 0)
            {
                DataTable result = c.select("SELECT * FROM mitglieder WHERE mitglieder_id = '" + mId + "';");
                c.closeConnection();
                if (result != null)
                {
                    openMitglied.setMitgliederId(mId);
                    openMitglied.setVorname((String)result.Rows[0]["vorname"]);
                    openMitglied.setNachname((String)result.Rows[0]["nachname"]);
                    openMitglied.setGebDatum((result.Rows[0]["geburtsdatum"]).ToString());
                    openMitglied.setStrasse((String)result.Rows[0]["strasse"]);
                    openMitglied.setHausnummer((String)(result.Rows[0]["hausnummer"]));
                    openMitglied.setPlz(Convert.ToInt32((result.Rows[0]["plz"])));
                    openMitglied.setOrt((String)result.Rows[0]["ort"]);
                    openMitglied.setVertragsId(Convert.ToInt32((result.Rows[0]["vertrags_id"]).ToString()));
                    openMitglied.setVertragsDatum(result.Rows[0]["vertragsdatum"].ToString());
                    openMitglied.setGesperrt(Convert.ToInt32(result.Rows[0]["gesperrt"]));
                    openMitglied.setKommentar((String)result.Rows[0]["kommentar"]);
                    openMitglied.setGesperrt(Convert.ToInt32(result.Rows[0]["gesperrt"]));

                    String mgPosBez = "";

                    if (initOeffnen == true)
                    {
                        int dBConnectOk = c.openConnection();
                        if (dBConnectOk == 0)
                        {
                            int rows = c.countRows("SELECT COUNT(*) FROM vertrag;");
                            if (rows > 0)
                            {
                                DataTable result2 = c.select("SELECT vertrags_id, bezeichnung FROM vertrag;");
                                if (result2 != null)
                                {
                                    string tempBezeichnung = "";
                                    int tempId = 0;

                                    // ddl füllen
                                    for (int i = 0; i < rows; i++)
                                    {
                                        tempBezeichnung = (String)result2.Rows[i]["bezeichnung"];
                                        tempId = (int)result2.Rows[i]["vertrags_id"];
                                        ddlVertragsart.Items.Add(tempBezeichnung);
                                    }


                                }

                                DataTable result3 = c.select("SELECT vertrags_id, bezeichnung FROM vertrag WHERE vertrags_id = '" + openMitglied.getVertragsId() + "';");
                                if (result3 != null)
                                {
                                    // bezeichnung abfragen
                                    mgPosBez = (result3.Rows[0]["bezeichnung"]).ToString();
                                }
                            }
                            c.closeConnection();
                        }
                        initOeffnen = false;
                    }

                    int pos = 0;

                    // Combobox preselected Item
                    for (int i = 0; i < ddlVertragsart.Items.Count; i++)
                    {
                        if (ddlVertragsart.Items[i].ToString() == mgPosBez)
                        {
                            pos = i;
                        }
                    }

                    ddlVertragsart.SelectedIndex = pos;

                    // Füllen der Textboxen
                    tbVorname.Text = openMitglied.getVorname();
                    tbNachname.Text = openMitglied.getNachname();
                    dtpDatum.Text = openMitglied.getGebDatum();
                    tbStrasse.Text = openMitglied.getStrasse();
                    tbHausnummer.Text = openMitglied.getHausnummer();
                    tbPlz.Text = Convert.ToString(openMitglied.getPlz());
                    tbOrt.Text = openMitglied.getOrt();
                    tbKommentar.Text = openMitglied.getKommentar();

                    // Datum füllen
                    dtpDatum.Text = openMitglied.getGebDatum();
                    dtpVertragsDatum.Text = openMitglied.getVertragsDatum();

                    if (openMitglied.getGesperrt() == 1)
                    {
                        cbGesperrt.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        cbGesperrt.CheckState = CheckState.Unchecked;
                    }

                }

                // Datenbankverbindung schliessen
                c.closeConnection();
            }
        }

        private void btBearbeiten_Click(object sender, EventArgs e)
        {
            // Globale Variable true setzen
            editMode = true;

            // Sichtbarkeit setzen
            dtpDatum.Enabled = true;
            dtpVertragsDatum.Enabled = true;
            ddlVertragsart.Enabled = true;
            cbGesperrt.Enabled = true;

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
            foreach (Control control in gbVertrag.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    ((TextBox)control).ReadOnly = false;
                }
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
            }
            else
            {
                this.Close();
            }
        }

        private void btSpeichern_Click(object sender, EventArgs e)
        {

            // Neues Mitglieds Objekt anlegen
            c_Mitglieder openMitglied = new c_Mitglieder();
            String strSQL = String.Empty;

            // Variablendeklaration und Initialisierung
            String gebDatum;
            String vertragsDatum;

            // =====================================
            //   Ueberpruefung auf leere Textfelder
            // =====================================

            // Persoenliche Daten
            if (tbVorname.Text != "" && tbNachname.Text != "" && dtpDatum.Text != "" && dtpVertragsDatum.Text != "")
            {
                openMitglied.setVorname(tbVorname.Text);
                openMitglied.setNachname(tbNachname.Text);

                // Daten umformatieren
                gebDatum = dtpDatum.Text;
                DateTime dateGeb = Convert.ToDateTime(gebDatum);
                openMitglied.setGebDatum(dateGeb.ToString("yyyy-MM-dd"));

                vertragsDatum = dtpVertragsDatum.Text;
                DateTime dateVert = Convert.ToDateTime(vertragsDatum);
                openMitglied.setVertragsDatum(dateVert.ToString("yyyy-MM-dd"));
            }
            else
            {
                MessageBox.Show("Sie haben nicht alle Mitglieds Daten angegeben.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Anschrift
            if (tbStrasse.Text != "" && tbHausnummer.Text != "" && tbOrt.Text != "" && tbPlz.Text != "")
            {
                openMitglied.setStrasse(tbStrasse.Text);
                openMitglied.setOrt(tbOrt.Text);

                if (c_Helper.wrongCharNumberExtra(tbHausnummer.Text) == false && c_Helper.numFormat(tbPlz.Text) == false)
                {
                    openMitglied.setHausnummer(tbHausnummer.Text);
                    openMitglied.setPlz(Convert.ToInt32(tbPlz.Text));
                }
                else
                {
                    MessageBox.Show("Falsches Format für die Felder Hausnummer und Postleitzahl.\nIm Feld Postleitzahl dürfen nur Zahlen stehen.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Sie haben nicht alle Anschrift-Daten angegeben.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (tbKommentar.Text != "")
            {
                openMitglied.setKommentar(tbKommentar.Text);
            }

            // ob gesperrt
            if (cbGesperrt.CheckState == CheckState.Checked)
            {
                openMitglied.setGesperrt(1);
            }
            else
            {
                openMitglied.setGesperrt(0);
            }

            // Ueberpruefen welche Vertragsart ausgewaehlt wurde
            int dbConnectOk = c.openConnection();
            DataTable result2 = c.select("SELECT * FROM vertrag;");
            c.closeConnection();

            int[] arrVertragsId = new int[result2.Rows.Count];
            string[] arrVertragsBez = new string[result2.Rows.Count];

            if (dbConnectOk == 0)
            {

                if (result2 != null)
                {
                    for (int i = 0; i < result2.Rows.Count; i++)
                    {
                        arrVertragsId[i] = Convert.ToInt32(result2.Rows[i]["vertrags_id"]);
                        arrVertragsBez[i] = (result2.Rows[i]["bezeichnung"]).ToString();
                    }
                }
            }

            for (int i = 0; i < arrVertragsId.Length; i++)
            {
                if (ddlVertragsart.SelectedItem.ToString().Equals((arrVertragsBez[i]).ToString()))
                {
                    openMitglied.setVertragsId(arrVertragsId[i]);
                }
            }


            // =====================================
            //     Daten in Datenbank schreiben
            // ===================================== 

            int dBConnectOk = c.openConnection();
            if (dBConnectOk == 0)
            {
                strSQL = "UPDATE mitglieder SET vertrags_id = '" + openMitglied.getVertragsId() + "', vorname = '" + openMitglied.getVorname() + "', nachname = '" + openMitglied.getNachname() + "', geburtsdatum = '" + openMitglied.getGebDatum() + "', strasse = '" + openMitglied.getStrasse() + "', hausnummer = '" + openMitglied.getHausnummer() + "', plz = '" + openMitglied.getPlz() + "', ort = '" + openMitglied.getOrt() + "', vertragsdatum = '" + openMitglied.getVertragsDatum() + "', gesperrt = '" + openMitglied.getGesperrt() + "', kommentar = '" + openMitglied.getKommentar() + "' WHERE mitglieder_id = " + mId + ";";
                c.update(strSQL, "Mitglied");
                c.closeConnection();
                gridMitgliederAktualisieren();

                this.Close();
            }

        }

        private void gridMitgliederAktualisieren()
        {
            int dbConnect = c.openConnection();
            if (dbConnect == 0)
            {

                c.displayData("SELECT mitglieder_id, bezeichnung, vorname, nachname, geburtsdatum, gesperrt FROM mitglieder a, vertrag b WHERE a.vertrags_id = b.vertrags_id;", gridMitglieder);
                c.closeConnection();

                // Headertexte anpassen
                DataTable gridMitgliederTable = (DataTable)(gridMitglieder.DataSource);
                gridMitgliederTable.Columns["mitglieder_id"].ColumnName = "ID";
                gridMitgliederTable.Columns["bezeichnung"].ColumnName = "Bezeichnung";
                gridMitgliederTable.Columns["vorname"].ColumnName = "Vorname";
                gridMitgliederTable.Columns["nachname"].ColumnName = "Nachname";
                gridMitgliederTable.Columns["geburtsdatum"].ColumnName = "Geburtsdatum";
                gridMitgliederTable.Columns["gesperrt"].ColumnName = "Gesperrt";


                // Binding Objekt zuweisen
                bindingSourceMitglieder.DataSource = gridMitglieder.DataSource;
                gridMitglieder.DataSource = bindingSourceMitglieder;
            }
            else
            {
                MessageBox.Show("Verbindungsfehler!\nÜbersicht konnte nicht aktualisiert werden.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
