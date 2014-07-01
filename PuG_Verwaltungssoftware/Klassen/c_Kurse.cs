using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuG_Verwaltungssoftware.Klassen
{
    public class c_Kurse
    {
        // Klassenvarialen deklarieren
        private int      kursID;
        private String   bezeichnung;
        private double   preis;
        private int      aktTeilnehmer;
        private int      maxTeilnehmer;
        private DateTime datumVon;
        private DateTime datumBis;
        private DateTime uhrzeitVon;
        private DateTime uhrzeitBis;
        private int      wochentag;
        private String   kursleiter;

        // set-Methoden
        public void setKursId(int pKursID)
        {
            kursID = pKursID;
        }

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
            maxTeilnehmer = pMaxTeilnehmer;
        }

        public void setDatumVon(DateTime pDatumVon)
        {
            datumVon = pDatumVon;
        }

        public void setDatumBis(DateTime pDatumBis)
        {
            datumBis = pDatumBis;
        }

        public void setUhrzeitVon(DateTime pUhrzeitVon)
        {
            uhrzeitVon = pUhrzeitVon;
        }

        public void setUhrzeitBis(DateTime pUhrzeitBis)
        {
            uhrzeitBis = pUhrzeitBis;
        }

        public void setWochentag(int pWochentag)
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

        public DateTime getDatumVon()
        {
            return datumVon;
        }

        public DateTime getDatumBis()
        {
            return datumBis;
        }

        public DateTime getUhrzeitVon()
        {
            return uhrzeitVon;
        }

        public DateTime getUhrzeitBis()
        {
            return uhrzeitBis;
        }

        public int getWochentag()
        {
            return wochentag;
        }

        public String getKursleiter()
        {
            return kursleiter;
        }
    }
}
