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
    public partial class winMitgliedOeffnen : Form
    {
        // Variablen
        bool editMode = false;
        bool initOeffnen = true;
        int mId = 0;

        DataGridView mGridView;
        c_DBConnect c = new c_DBConnect();

        public winMitgliedOeffnen(int id, DataGridView grid)
        {
            InitializeComponent();
            mId = id;
            mGridView = grid;
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

                   


                    /*

                    dbConnectOk = c.openConnection();
                    DataTable result2 = c.select("SELECT * FROM vertrag;");
                    c.closeConnection();

                    int[] arrVertragId = new int[result2.Rows.Count];
                    string[] arrVertragBez = new string[result2.Rows.Count];

                    if (dbConnectOk == 0)
                    {

                        if (result2 != null)
                        {
                            for (int i = 0; i < result2.Rows.Count; i++)
                            {
                                arrVertragId[i] = Convert.ToInt32(result2.Rows[i]["vertrags_id"]);
                                arrVertragBez[i] = (result2.Rows[i]["bezeichnung"]).ToString();
                            }
                        }
                    }

                    for (int i = 0; i < arrVertragId.Length; i++)
                    {
                        if (openMitglied.getVertragsId().Equals((arrVertragId[i])))
                        {
                            //tbVertragsart.Text = (arrVertragBez[i]).ToString();
                        }
                    }

                     * */

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

        }

    }
}
