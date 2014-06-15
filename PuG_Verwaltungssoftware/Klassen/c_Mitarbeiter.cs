using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuG_Verwaltungssoftware.Klassen
{
    class c_Mitarbeiter : c_Person
    {
        // Deklaration
        private double gehalt;
        private String benutzername;
        private String passwort;
        private int posId;

        // Konstruktor
        public c_Mitarbeiter()
        {
            
        }

        // Set-Methoden
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
        public int getPositionId(int pId)
        {
            return this.posId;
        }


    }
}
