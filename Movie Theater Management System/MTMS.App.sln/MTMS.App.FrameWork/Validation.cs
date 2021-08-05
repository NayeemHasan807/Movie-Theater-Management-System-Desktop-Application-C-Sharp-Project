using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTMS.App.FrameWork
{
    public static class Validation
    {
        public static bool IsStringValid(string value)
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                return false;

            return true;
        }

        public static bool IsIntValid(string value)
        {
            int i;
            return Int32.TryParse(value, out i);
        }

        public static bool IsDoubleValid(string value)
        {
            double d;
            return Double.TryParse(value, out d);
        }

        public static bool IsDateTimeValid(string value)
        {
            try
            {
                DateTime.Parse(value);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
