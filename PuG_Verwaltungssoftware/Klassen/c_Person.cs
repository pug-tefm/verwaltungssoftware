using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuG_Verwaltungssoftware.Klassen
{
    public class c_Person
    {
        // Variablendeklaration
        private String vorname;
        private String nachname;
        private String gebDatum;
        private String strasse;
        private String ort;
        private int hNummer;
        private int plz;

        // Standardkonstruktor
        public c_Person()
        {

        }

        public c_Person(String vor, String nach, String geb, String strasse, String ort, int hNummer, int plz)
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
        public void setStrasse(String pStrasse)
        {
            this.strasse = pStrasse;
        }
        public void setOrt(String pOrt)
        {
            this.ort = pOrt;
        }
        public void setHausnummer(int pNummer)
        {
            this.hNummer = pNummer;
        }
        public void setPlz(int pPlz)
        {
            this.plz = pPlz;
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
        public String getStrasse()
        {
            return this.strasse;
        }
        public String getOrt()
        {
            return this.ort;
        }
        public int getHausnummer()
        {
            return this.hNummer;
        }
        public int getPlz()
        {
            return this.plz;
        }
    }
}
