using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSuperMarket_API
{
    internal class Calculator
    {
        public static decimal SumTotal<T, TProperty>(IEnumerable<T> items, string propertyName)
        {
            var property = typeof(T).GetProperty(propertyName);
            if (property == null || property.PropertyType != typeof(TProperty))
            {
                throw new ArgumentException("Invalid property name or type!");
            }
            return items.Sum(item => (decimal)property.GetValue(item));        
        }
    }
}
