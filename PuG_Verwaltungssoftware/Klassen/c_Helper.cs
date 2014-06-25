using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuG_Verwaltungssoftware.Klassen
{
    public class c_Helper
    {

        static readonly string PasswordHash = "P@@Sw0rd";
        static readonly string SaltKey = "S@LT&KEY";
        static readonly string VIKey = "@1B2c3D4e5F6g7H8";

        // Methode zum Verschluesseln von Strings
        public static String encrypt(String query)
        {
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(query);

            byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.Zeros };
            var encryptor = symmetricKey.CreateEncryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));

            byte[] cipherTextBytes;

            using (var memoryStream = new MemoryStream())
            {
                using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                {
                    cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                    cryptoStream.FlushFinalBlock();
                    cipherTextBytes = memoryStream.ToArray();
                    cryptoStream.Close();
                }
                memoryStream.Close();
            }
            return Convert.ToBase64String(cipherTextBytes);
        }

        // Methode zum Entschluesseln von Strings
        public static String decrypt(String query)
        {
            byte[] cipherTextBytes = Convert.FromBase64String(query);
            byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.None };

            var decryptor = symmetricKey.CreateDecryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));
            var memoryStream = new MemoryStream(cipherTextBytes);
            var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            byte[] plainTextBytes = new byte[cipherTextBytes.Length];

            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            memoryStream.Close();
            cryptoStream.Close();
            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount).TrimEnd("\0".ToCharArray());
        }

        // Methode zum Ueberpruefen, ob nur Nummern, Komma oder Punkt im String enthalten sind
        public static bool numFormatPunktKomma(String query, int laenge = 0)
        {
            if (query.Trim().Length <= 0 || query.Length > laenge) return true; // Länge falsch

            int zaehler = 0;
            for (int i = 0; i < query.Length; i++)
            {
                int character = query[i];
                if ((character < 48 || character > 57) && character != 44 && character != 46) // 0 bis 9 und . ,
                {
                    return true;
                }
                if (character == 44 || character == 46) // . ,
                {
                    zaehler += 1;
                }
            }

            if (zaehler > 1) return true;
            return false;
        }

        // Methode zum Ueberpruefen, ob nur Nummern im String enthalten sind
        public static bool numFormat(String query, int laenge = 0)
        {
            if (query.Trim().Length <= 0 || query.Length > laenge) return true; // Länge falsch

            for (int i = 0; i < query.Length; i++)
            {
                int character = query[i];
                if ((character < 48 || character > 57))
                {
                    return true;
                }
            }
            return false;
        }

        // Methode zum Ueberpruefen ob nur Buchstaben im String enthalten sind
        public static bool wrongCharacters(String query, int laenge = 0)
        {
            if (query.Trim().Length <= 0 || query.Length > laenge) return true; // Länge falsch

            for (int i = 0; i < query.Length; i++)
            {
                int character = query[i];
                if ((character < 65 || character > 90) && (character < 97 || character > 122)) // Großbuchstaben && Kleinbuchstaben
                {
                    return true;
                }
            }
            return false;
        }

        // Methode zum Ueberpruefen ob nur Buchstaben Zahlen und einige extra Zeichen im String enthalten sind
        public static bool wrongCharNumberExtra(String query, int laenge = 0)
        {
            if (query.Trim().Length <= 0 || query.Length > laenge) return true; // Länge falsch

            for (int i = 0; i < query.Length; i++)
            {
                int character = query[i];
                if ((character < 65 || character > 90) && (character < 97 || character > 122) && (character < 32 || character > 57) // Großbuchstaben && Kleinbuchstaben && 0 bis 9
                  && character != 45) // - + & / #
                {
                    return true;
                }
            }
            return false;
        }

        public static String umwandlungIntInWochentag(int wochentag)
        {
            if (wochentag == 0) return "Montag";
            else if (wochentag == 1) return "Dienstag";
            else if (wochentag == 2) return "Mittwoch";
            else if (wochentag == 3) return "Donnerstag";
            else if (wochentag == 4) return "Freitag";
            else if (wochentag == 5) return "Samstag";
            else if (wochentag == 6) return "Sonntag";
            else return "-1";
        }

        public static int umwandlungWochentagInInt(String wochentag)
        {
            if (wochentag == "Montag") return 0;
            else if (wochentag == "Dienstag") return 1;
            else if (wochentag == "Mittwoch") return 2;
            else if (wochentag == "Donnerstag") return 3;
            else if (wochentag == "Freitag") return 4;
            else if (wochentag == "Samstag") return 5;
            else if (wochentag == "Sonntag") return 6;
            else return -1;
        }

        public static String umwandlungWochentagEngToGer(String wochentag)
        {
            if (wochentag == "Monday") return "Montag";
            else if (wochentag == "Tuesday") return "Dienstag";
            else if (wochentag == "Wednesday") return "Mittwoch";
            else if (wochentag == "Thursday") return "Donnerstag";
            else if (wochentag == "Friday") return "Freitag";
            else if (wochentag == "Saturday") return "Samstag";
            else if (wochentag == "Sunday") return "Sonntag";
            else return "-1";
        }

        public static String umwandlungWochentagGerToEng(String wochentag)
        {
            if (wochentag == "Montag") return "Monday";
            else if (wochentag == "Dienstag") return "Tuesday";
            else if (wochentag == "Mittwoch") return "Wednesday";
            else if (wochentag == "Donnerstag") return "Thursday";
            else if (wochentag == "Freitag") return "Friday";
            else if (wochentag == "Samstag") return "Saturday";
            else if (wochentag == "Sonntag") return "Sunday";
            else return "-1";
        }

        public void textBoxSuchenTextChanged(DataGridView dataGridView, ComboBox comboBox, TextBox textBox, BindingSource bindingSource)
        {
            string suchen = "";
            if (String.IsNullOrEmpty(textBox.Text)) // Wenn leer dann suchen Filter entfernen
            {
                bindingSource.RemoveFilter();
            }
            else // Nach irgendwas suchen
            {
                suchen += dataGridView.Columns[comboBox.SelectedIndex].HeaderText.ToString();
                suchen = "Convert([" + suchen + "], 'System.String') LIKE '*{0}*'";
            }
            bindingSource.Filter = string.Format(suchen, textBox.Text);
        }

        public void comboBoxSuchenSelectedIndexChanged(DataGridView dataGridView, ComboBox comboBox, TextBox textBox, BindingSource bindingSource)
        {
            if (!String.IsNullOrEmpty(textBox.Text))
            {
                string suchen = "";

                // Nach irgendwas suchen
                suchen += dataGridView.Columns[comboBox.SelectedIndex].HeaderText.ToString();
                suchen = "Convert([" + suchen + "], 'System.String') LIKE '*{0}*'";
                bindingSource.Filter = string.Format(suchen, textBox.Text);
            }
        }
    }
}
