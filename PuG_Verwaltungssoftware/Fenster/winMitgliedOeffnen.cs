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
                            tbVertragsart.Text = (arrVertragBez[i]).ToString();
                        }
                    }


                    // Füllen der Textboxen
                    tbVorname.Text = openMitglied.getVorname();
                    tbNachname.Text = openMitglied.getNachname();
                    dtpDatum.Text = openMitglied.getGebDatum();
                    tbStrasse.Text = openMitglied.getStrasse();
                    tbHausnummer.Text = openMitglied.getHausnummer();
                    tbPlz.Text = Convert.ToString(openMitglied.getPlz());
                    tbOrt.Text = openMitglied.getOrt();
                    tbKommentar.Text = openMitglied.getKommentar();

                    // Füllen der Textboxen (overlay)
                    tbVertragsDatum.Text = openMitglied.getVertragsDatum().Substring(0, 10);
                    tbDatum.Text = openMitglied.getGebDatum().Substring(0, 10);

                }

                // Datenbankverbindung schliessen
                c.closeConnection();
            }
        }

    }
}
