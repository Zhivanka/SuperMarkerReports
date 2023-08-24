using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSuperMarket_API
{
    internal class Formater
    {
        public static string FormatWithSuffix(string format, object value, String suffix, string name)
        {
            if (value != null)
            {
                var formattedValue = string.Format(format, value);
                if (!string.IsNullOrEmpty(suffix))
                { 
                    formattedValue += suffix;
                }
                return formattedValue;
            }
            else
            {
                return "   " + name + ": N/A";
            }
        }


    }
}
