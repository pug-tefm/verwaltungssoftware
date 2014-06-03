using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuG_Verwaltungssoftware.Klassen
{
    class c_Helper
    {
        public static void encrypt(String query)
        {

        }

        public static void decrypt(String query)
        {

        }

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

        public static bool wrongCharacters(String query)
        {
            for (int i = 0; i < query.Length; i++)
            {
                int character = query[i];
                if( (character < 65 || character > 90) && (character < 97 || character > 122 ) )
                {
                    return true;
                }
            }

            return false;
        }

    }
}
