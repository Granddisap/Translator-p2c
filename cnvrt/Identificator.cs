using System;
using System.Collections.Generic;
using System.Text;

namespace cnvrt
{
    class Identificator
    {
        public static string idntf(char ch)
        {
            if (((int)ch) >= 48 && ((int)ch) <= 57)
            {
                return "numar";
            }
            else if ((((int)ch) >= 97 && ((int)ch) <= 122) || (((int)ch) >= 65 && ((int)ch) <= 90))
            {
                return "alfabetic";
            }
            else
            {
                return "caracter";
            }
        }
    }
}
