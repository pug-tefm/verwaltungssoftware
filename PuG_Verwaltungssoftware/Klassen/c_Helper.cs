using System;
using System.Collections.Generic;
using System.Data;
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
        // Klassenvariablen deklarieren und initialisieren
        static readonly string PasswordHash = "P@@Sw0rd";
        static readonly string SaltKey = "S@LT&KEY";
        static readonly string VIKey = "@1B2c3D4e5F6g7H8";

        // Florian, Erik, Maxi und Tim
        /**********************************************/
        /* public static String encrypt(String query) */
        /**********************************************/
        /* Verschlüssel eines Strings                 */
        /**********************************************/
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

        // Florian, Erik, Maxi und Tim
        /**********************************************/
        /* public static String decrypt(String query) */
        /**********************************************/
        /* Entschlüssel eines Strings                 */
        /**********************************************/
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

        // Florian und Tim
        /************************************************************************/
        /* public static bool numFormatPunktKomma(String query, int laenge = 0) */
        /************************************************************************/
        /* Überprüfen ob nur Nummer, Komma oder Punkt im String enthalten sind. */
        /************************************************************************/
        public static bool numFormatPunktKomma(String query)
        {
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

        // Florian und Tim
        /**************************************************************/
        /* public static bool numFormat(String query, int laenge = 0) */
        /**************************************************************/
        /* Überprüfen ob nur Nummer im String enthalten sind.         */
        /**************************************************************/
        public static bool numFormat(String query)
        {
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

        // Florian und Tim
        /********************************************************************/
        /* public static bool wrongCharacters(String query, int laenge = 0) */
        /********************************************************************/
        /* Überprüfen ob nur Buchstaben im String enthalten sind.           */
        /********************************************************************/
        public static bool wrongCharacters(String query)
        {
            for (int i = 0; i < query.Length; i++)
            {
                int character = query[i];
                if ((character < 65 || character > 90) && (character < 97 || character > 122)) // Großbuchstaben && Kleinbuchstaben // TODO eventeull ä,ö,ü
                {
                    return true;
                }
            }
            return false;
        }

        // Florian und Tim
        /*************************************************************************/
        /* public static bool wrongCharNumberExtra(String query, int laenge = 0) */
        /*************************************************************************/
        /* Überprüfen ob nur Buchstaben, Zahlen und einige extra Zeichen         */
        /* im String enthalten sind.                                             */
        /*************************************************************************/
        public static bool wrongCharNumberExtra(String query)
        {
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

        // Tim
        /****************************************************************/
        /* public static String umwandlungIntInWochentag(int wochentag) */
        /****************************************************************/
        /* Der Wochentag wurd von einem int Wert (0-6) in Wochentage    */
        /* (Strings umgewandelt)                                        */
        /****************************************************************/
        public static String umwandlungIntInWochentag(int wochentag)
        {
            if      (wochentag == 0) return "Montag";
            else if (wochentag == 1) return "Dienstag";
            else if (wochentag == 2) return "Mittwoch";
            else if (wochentag == 3) return "Donnerstag";
            else if (wochentag == 4) return "Freitag";
            else if (wochentag == 5) return "Samstag";
            else if (wochentag == 6) return "Sonntag";
            else return "-1";
        }

        // Tim
        /****************************************************************/
        /* public static int umwandlungWochentagInInt(String wochentag) */
        /****************************************************************/
        /* Der Wochentag wurd von einem String in einen int Wert (0-6)  */
        /* umgewandelt                                                  */
        /****************************************************************/
        public static int umwandlungWochentagInInt(String wochentag)
        {
            if      (wochentag == "Montag")     return 0;
            else if (wochentag == "Dienstag")   return 1;
            else if (wochentag == "Mittwoch")   return 2;
            else if (wochentag == "Donnerstag") return 3;
            else if (wochentag == "Freitag")    return 4;
            else if (wochentag == "Samstag")    return 5;
            else if (wochentag == "Sonntag")    return 6;
            else return -1;
        }

        // Tim
        /**********************************************************************/
        /* public static String umwandlungWochentagEngToGer(String wochentag) */
        /**********************************************************************/
        /* Der Wochentag wird von Englisch nach Deutsch übersetzt.            */
        /**********************************************************************/
        public static String umwandlungWochentagEngToGer(String wochentag)
        {
            if      (wochentag == "Monday")    return "Montag";
            else if (wochentag == "Tuesday")   return "Dienstag";
            else if (wochentag == "Wednesday") return "Mittwoch";
            else if (wochentag == "Thursday")  return "Donnerstag";
            else if (wochentag == "Friday")    return "Freitag";
            else if (wochentag == "Saturday")  return "Samstag";
            else if (wochentag == "Sunday")    return "Sonntag";
            else return "-1";
        }

        // Tim
        /**********************************************************************/
        /* public static String umwandlungWochentagGerToEng(String wochentag) */
        /**********************************************************************/
        /* Der Wochentag wird von Deutsch nach Englisch übersetzt.            */
        /**********************************************************************/
        public static String umwandlungWochentagGerToEng(String wochentag)
        {
            if       (wochentag == "Montag")    return "Monday";
            else if (wochentag == "Dienstag")   return "Tuesday";
            else if (wochentag == "Mittwoch")   return "Wednesday";
            else if (wochentag == "Donnerstag") return "Thursday";
            else if (wochentag == "Freitag")    return "Friday";
            else if (wochentag == "Samstag")    return "Saturday";
            else if (wochentag == "Sonntag")    return "Sunday";
            else return "-1";
        }

        // Tim
        /************************************************************************************************************************************/
        /* public void textBoxSuchenTextChanged(DataGridView dataGridView, ComboBox comboBox, TextBox textBox, BindingSource bindingSource) */
        /************************************************************************************************************************************/
        /* Wenn sich er TextBox Text geändert haben sollte, wird der Filter angepasst                                                        */
        /************************************************************************************************************************************/
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

        // Tim
        /**********************************************************************************************************************************************/
        /* public void comboBoxSuchenSelectedIndexChanged(DataGridView dataGridView, ComboBox comboBox, TextBox textBox, BindingSource bindingSource) */
        /**********************************************************************************************************************************************/
        /* Wenn sich der ComboBox Index geändert haben sollte, wird der Filter angepasst.                                                             */
        /**********************************************************************************************************************************************/
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

        // Tim
        /***********************************************************************************************************/
        /* public static bool changeColumnDataType(DataTable table, string columnname, Type newtype, int position) */
        /***********************************************************************************************************/
        /*  Der Datentyp von einer Spalte wird zur Laufzeit verändert                                              */
        /***********************************************************************************************************/
        public static bool changeColumnDataType(DataTable table, string columnname, Type newtype)
        {
            if (table.Columns.Contains(columnname) == false)
                return false;

            DataColumn column = table.Columns[columnname];
            if (column.DataType == newtype)
                return true;

            try
            {
                DataColumn newcolumn = new DataColumn("temp", newtype);
                table.Columns.Add(newcolumn);
                foreach (DataRow row in table.Rows)
                {
                    row["temp"] = Convert.ChangeType(row[columnname], newtype);
                }
                table.Columns.Remove(columnname);
                newcolumn.ColumnName = columnname;
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        // Tim
        /**************************************************************/
        /*public static void setToolTip(Button myButton, String text) */
        /**************************************************************/
        /*  Tooltipitems einem Button zuweisen                        */
        /**************************************************************/
        public static void setToolTip(Button myButton, String text)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay  = 500;

            toolTip.ShowAlways = true;

            toolTip.SetToolTip(myButton, text);
        }
    }
}
