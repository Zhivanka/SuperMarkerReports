using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSuperMarket_API
{
    internal static class TextTruncator
    {
        public static string TruncateWithSpace(string value, int maxLength)
        {
            if (value.Length > maxLength)
            {
                return value.Substring(0, maxLength + 3) + "...";
            }
            return value;
        }
    }
}
