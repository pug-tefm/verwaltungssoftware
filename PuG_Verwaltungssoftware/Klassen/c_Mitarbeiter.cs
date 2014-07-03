using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuG_Verwaltungssoftware.Klassen
{
    public class c_Mitarbeiter : c_Person
    {
        // Deklaration
        private int mitarbeiterId;
        private double gehalt;
        private String benutzername;
        private String passwort;
        private int posId;

        // Konstruktor
        public c_Mitarbeiter()
        {}

        // Set-Methoden
        public void setMitarbeiterId(int pId)
        {
            this.mitarbeiterId = pId;
        }
        public void setGehalt(double pGehalt)
        {
            this.gehalt = pGehalt;
        }
        public void setBenutzername(String pBenutzer)
        {
            this.benutzername = pBenutzer;
        }
        public void setPasswort(String pPasswort)
        {
            this.passwort = pPasswort;
        }
        public void setPositionId(int pId)
        {
            this.posId = pId;
        }

        // Get-Methoden
        public int getMitarbeiterId()
        {
            return this.mitarbeiterId;
        }
        public double getGehalt()
        {
            return this.gehalt;
        }
        public String getBenutzername()
        {
            return this.benutzername;
        }
        public String getPasswort()
        {
            return this.passwort;
        }
        public int getPositionId()
        {
            return this.posId;
        }

        /*****************************************************************************/
        /* public static void comboBoxFill(ComboBox cbKursleiter, string kursleiter) */
        /*****************************************************************************/
        /* Befüllt die ComboBoxen mit den Mitarbeitern und selektiert den            */
        /* Kursleiter.                                                               */
        /*****************************************************************************/
        public static void comboBoxFill(ComboBox cbKursleiter, string kursleiter)
        {
            int id = 0;
            string vorname = "";
            string nachname = "";
            c_DBConnect c = new c_DBConnect();

            int dBConnectOk = c.openConnection();
            if (dBConnectOk == 0) // Kein Fehler Connect
            {
                int rows = c.countRows("SELECT COUNT(*) FROM mitarbeiter;"); // Zeilen zäheln
                if (rows > 0) // Daten vorhanden ?
                {
                    DataTable result = c.select("SELECT mitarbeiter_id, vorname, nachname FROM mitarbeiter;"); // Abfragestring abschicken
                    if (result != null)
                    {
                        for (int i = 0; i < rows; i++)
                        {
                            id       = (int)result.Rows[i]["mitarbeiter_id"];
                            vorname  = (String)result.Rows[i]["vorname"];
                            nachname = (String)result.Rows[i]["nachname"];
                            string vollerName = "(" + id.ToString() + ") " + vorname + ", " + nachname;
                            cbKursleiter.Items.Add(vollerName);

                            if (vollerName == kursleiter) // Kursleiter selektieren
                            {
                                cbKursleiter.SelectedIndex = i;
                            }
                        }
                    }
                }
                c.closeConnection();
            }
            else // Fehler Connect
            {
                MessageBox.Show("Datenbankverbindung konnte nicht hergestellt werden.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
