using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuG_Verwaltungssoftware.Klassen
{
    class c_Person
    {
        // Variablendeklaration
        private String vorname;
        private String nachname;
        private String gebDatum;
        private String[] adresse;

        // Standardkonstruktor
        public c_Person()
        {

        }

        public c_Person(String vor, String nach, String geb, String[] adr)
        {

        }

        // set-Methoden
        public void setVorname(String pVorname)
        {
            this.vorname = pVorname;
        }
        public void setNachname(String pNachname)
        {
            this.nachname = pNachname;
        }
        public void setGebDatum(String pDatum)
        {
            this.gebDatum = pDatum;
        }
        public void setAdresse(String[] pAdresse)
        {

        }

        // get-Methoden
        public String getVorname()
        {
            return this.vorname;
        }
        public String getNachname()
        {
            return this.nachname;
        }
        public String getGebDatum()
        {
            return this.gebDatum;
        }
        public String[] getAdresse()
        {
            return this.adresse;
        }
    }
}
