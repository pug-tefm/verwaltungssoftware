using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuG_Verwaltungssoftware.Klassen
{
    class c_Kurse
    {
        private int kursID;
        private String bezeichnung;
        private double preis;
        private int aktTeilnehmer;
        private int maxTeilnehmer;
        private String von;
        private String bis;
        private String wochentag;
        private String uhrzeit;
        private String kursleiter;

        public c_Kurse()
        {
            
        }

        // set-Methoden
        public void setBezeichnung(String pBezeichnung)
        {
            bezeichnung = pBezeichnung;
        }

        public void setPreis(double pPreis)
        {
            preis = pPreis;
        }

        public void setAktTeilnehmer(int pAktTeilnehmer)
        {
            aktTeilnehmer = pAktTeilnehmer;
        }

        public void setMaxTeilnehmer(int pMaxTeilnehmer)
        {
            int maxTeilnehmer = pMaxTeilnehmer;
        }

        public void setVon(String pVon)
        {
            von = pVon;
        }

        public void setBis(String pBis)
        {
            bis = pBis;
        }

        public void setUhrzeit(String pUhrzeit)
        {
            uhrzeit = pUhrzeit;
        }

        public void setWochentag(String pWochentag)
        {
            wochentag = pWochentag;
        }

        public void setKursleiter(String pKursleiter)
        {
            kursleiter = pKursleiter;
        }

        // get-Methoden
        public int getKursId()
        {
            return kursID;
        }

        public String getBezeichnung()
        {
            return bezeichnung;
        }

        public double getPreis()
        {
            return preis;
        }

        public int getAktTeilnehmer()
        {
            return aktTeilnehmer;
        }

        public int getMaxTeilnehmer()
        {
            return maxTeilnehmer;
        }

        public String getVon()
        {
            return von;
        }

        public String getBis()
        {
            return bis;
        }

        public String getUhrzeit()
        {
            return uhrzeit;
        }

        public String getWochentag()
        {
            return wochentag;
        }

        public String getKursleiter()
        {
            return kursleiter;
        }
    }
}
