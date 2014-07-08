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
    public partial class winMitgliedNeu : Form
    {
        c_DBConnect c = new c_DBConnect();
        DataGridView gridMitglieder;
        private BindingSource bindingSourceMitglieder = new BindingSource();

        public winMitgliedNeu(DataGridView grid)
        {
            InitializeComponent();
            gridMitglieder = grid;

        }

        private void winMitgliedNeu_Load(object sender, EventArgs e)
        {

            string vertragsart = "";
            int pos = 0;

            int dBConnectOk = c.openConnection();
            if (dBConnectOk == 0)
            {
                int rows = c.countRows("SELECT COUNT(*) FROM vertrag;");
                if (rows > 0)
                {
                    DataTable result = c.select("SELECT vertrags_id, bezeichnung FROM vertrag;");
                    if (result != null)
                    {
                        for (int i = 0; i < rows; i++)
                        {
                            vertragsart = (String)result.Rows[i]["bezeichnung"];
                            ddlVertragsart.Items.Add(vertragsart);
                        }
                    }
                }
                c.closeConnection();
            }

            // Combobox preselected Item
            for (int i = 0; i < ddlVertragsart.Items.Count; i++)
            {
                if (ddlVertragsart.Items[i].ToString() == "Normal")
                {
                    pos = i;
                }
            }
            ddlVertragsart.SelectedIndex = pos;
        }

        private void btSchliessen_Click(object sender, EventArgs e)
        {
            // Fenster schliessen
            if (tbVorname.Text.Trim().Length != 0 || tbNachname.Text.Trim().Length != 0 || tbStrasse.Text.Trim().Length != 0 || tbHausnummer.Text.Trim().Length != 0
                || tbOrt.Text.Trim().Length != 0 || tbPlz.Text.Trim().Length != 0 || tbKommentar.Text.Trim().Length != 0)
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

            // Neues Mitglieds Objekt anlegen
            c_Mitglieder newMitglied = new c_Mitglieder();
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
                newMitglied.setVorname(tbVorname.Text);
                newMitglied.setNachname(tbNachname.Text);

                // Daten umformatieren
                gebDatum = dtpDatum.Text;
                DateTime dateGeb = Convert.ToDateTime(gebDatum);
                newMitglied.setGebDatum(dateGeb.ToString("yyyy-MM-dd"));

                vertragsDatum = dtpVertragsDatum.Text;
                DateTime dateVert = Convert.ToDateTime(vertragsDatum);
                newMitglied.setVertragsDatum(dateVert.ToString("yyyy-MM-dd"));
            }
            else
            {
                MessageBox.Show("Sie haben nicht alle Mitglieds Daten angegeben.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Anschrift
            if (tbStrasse.Text != "" && tbHausnummer.Text != "" && tbOrt.Text != "" && tbPlz.Text != "")
            {
                newMitglied.setStrasse(tbStrasse.Text);
                newMitglied.setOrt(tbOrt.Text);

                if (c_Helper.wrongCharNumberExtra(tbHausnummer.Text) == false && c_Helper.numFormat(tbPlz.Text) == false)
                {
                    newMitglied.setHausnummer(tbHausnummer.Text);
                    newMitglied.setPlz(Convert.ToInt32(tbPlz.Text));
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
                newMitglied.setKommentar(tbKommentar.Text);
            }

            // ob gesperrt
            if(cbGesperrt.CheckState == CheckState.Checked)
            {
                newMitglied.setGesperrt(1);
            }
            else
            {
                newMitglied.setGesperrt(0);
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
                    newMitglied.setVertragsId(arrVertragsId[i]);
                }
            }


            // =====================================
            //     Daten in Datenbank schreiben
            // ===================================== 

            int dBConnectOk = c.openConnection();
            if (dBConnectOk == 0)
            {
                strSQL = "INSERT INTO mitglieder (vertrags_id, vorname, nachname, geburtsdatum, strasse, hausnummer, plz, ort, vertragsdatum, gesperrt, kommentar)" +
                    "VALUES ('" + newMitglied.getVertragsId() + "', '" + newMitglied.getVorname() + "', '" + newMitglied.getNachname() + "' , '" + newMitglied.getGebDatum() + "', '" + newMitglied.getStrasse() + "', '" + newMitglied.getHausnummer() + "', '" + newMitglied.getPlz() + "', '" + newMitglied.getOrt() + "', '" + newMitglied.getVertragsDatum() + "', '" + newMitglied.getGesperrt() + "', '" + newMitglied.getKommentar() + "');";
                c.insert(strSQL, "Mitglied");
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
