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

// Florian
namespace PuG_Verwaltungssoftware
{
    public partial class winMitarbeiterPasswort : Form
    {
        /*
         * ******************************
         *     Variablendeklarationen
         * ******************************
         * */     
        
        c_DBConnect c = new c_DBConnect();
        int gLoginId = 0;
        int gId = 0;
        
        public winMitarbeiterPasswort(int loginId, int id)
        {
            InitializeComponent();

            gLoginId = loginId;
            gId = id;
        }


        /*
         * ******************************
         *         Control Events
         * ******************************
         * */

        private void winMitarbeiterPasswort_Load(object sender, EventArgs e)
        {
            if (gLoginId == 1)
            {
                panelChef.BringToFront();
                panelChef.Visible = true;
                panelMitarbeiter.SendToBack();
                panelMitarbeiter.Visible = false;
            }
            else
            {                
                panelMitarbeiter.BringToFront();
                panelMitarbeiter.Visible = true;
                panelChef.SendToBack();
                panelChef.Visible = false;
            }
        }

        private void btSchliessen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAendern_Click(object sender, EventArgs e)
        {
            String passwortAlt = String.Empty;
            String passwort1 = String.Empty;
            String passwort2 = String.Empty;
            String strSQL = String.Empty;
            int dbConnectOk = 0;
            
            if (gLoginId == 1)
            {
                passwort1 = tbInitPw.Text;
                if (passwort1 != "")
                {
                    dbConnectOk = c.openConnection();
                    if (dbConnectOk == 0)
                    {
                        strSQL = "UPDATE mitarbeiter SET passwort = '" + c_Helper.encrypt(passwort1) + "' WHERE mitarbeiter_id = '" + gId +"';";
                        c.update(strSQL, "Passwort");
                        c.closeConnection();
                        this.Close();
                    }                   
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Kein Initialpasswort eingegeben.", "Information", MessageBoxButtons.OK);
                }
            }
            else
            {
                passwortAlt = tbAltesPw.Text;
                passwort1 = tbNeuesPw1.Text;
                passwort2 = tbNeuesPw2.Text;
                if (passwortAlt != "" && passwort1 != "" && passwort2 != "")
                {
                    dbConnectOk = c.openConnection();
                    if (dbConnectOk == 0)
                    {
                        passwortAlt = c_Helper.encrypt(passwortAlt);
                        bool hasRows = c.count("SELECT * FROM mitarbeiter WHERE mitarbeiter_id = '" + gId + "' AND passwort = '" + passwortAlt + "';");
                        c.closeConnection();
                        if (hasRows == true)
                        {
                            if (passwort1.Equals(passwort2))
                            {
                                c.openConnection();
                                strSQL = "UPDATE mitarbeiter SET passwort = '" + c_Helper.encrypt(passwort1) + "' WHERE mitarbeiter_id = '" + gId + "';";
                                c.update(strSQL, "Passwort");
                                c.closeConnection();
                                this.Close();
                            }
                        }
                        else
                        {
                            DialogResult dialogResult = MessageBox.Show("Altes Passwort falsch.", "Information", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Bitte alle Textfelder ausfüllen.", "Information", MessageBoxButtons.OK);
                }

            }
        }
    }
}
