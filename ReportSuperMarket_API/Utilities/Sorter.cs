using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSuperMarket_API
{
    internal class Sorter<T>
    {
        public static List<T> SortByName(List<T> items)
        { 
            return items.OrderBy(item => item.GetType().GetProperty("Name").GetValue(item)).ToList(); 
        }
    }
}
