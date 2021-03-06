﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Erik
namespace PuG_Verwaltungssoftware.Klassen
{
    public class c_Mitglieder : c_Person
    {
        // Deklaration
        private int mitgliederId;
        private int vertragsId;
        private int gesperrt;
        private String kommentar;
        private String vertragsDatum;

        // Setter
        public void setMitgliederId(int pId)
        {
            this.mitgliederId = pId;
        }

        public void setVertragsId(int pVertragsId)
        {
            this.vertragsId = pVertragsId;
        }

        public void setGesperrt(int pGesperrt)
        {
            this.gesperrt = pGesperrt;
        }

        public void setKommentar(String pKommentar)
        {
            this.kommentar = pKommentar;
        }

        public void setVertragsDatum(String pVertragsDatum)
        {
            this.vertragsDatum = pVertragsDatum;
        }

        // Getter
        public int getMitgliederId()
        {
            return this.mitgliederId;
        }

        public int getVertragsId()
        {
            return this.vertragsId;
        }

        public int getGesperrt()
        {
            return this.gesperrt;
        }

        public String getKommentar()
        {
            return this.kommentar;
        }

        public String getVertragsDatum()
        {
            return this.vertragsDatum;
        }
    }
}