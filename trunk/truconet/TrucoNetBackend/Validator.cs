using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrucoNetBackend
{
    class Validator
    {

        public static Boolean SelComando(String val)
        {
            if (val.Equals("1") || val.Equals("2") || val.Equals("3") || val.Equals("4") || val.Equals("5"))
            {
                return true;
            }else{
                return false;
            }
        }

        public static Boolean ConsultaComando(String val)
        {
            if (val.Equals("Si") || val.Equals("S") || val.Equals("No") || val.Equals("N"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static Boolean NumComando(String val)
        {

            try
            {
                int numVal = Convert.ToInt32(val);
            }
            catch (FormatException e)
            {
                return false;
            }

            return true;
        }

    }
}
