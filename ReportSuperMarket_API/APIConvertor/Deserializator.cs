using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSuperMarket_API
{
    internal class Deserializator
    {
        internal static List<T> Deserialize<T>(JArray jsonData)
        {
            var items = new List<T>();
            foreach (var item in jsonData)
            {
               var deserializedItem = item.ToObject<T>();
               items.Add(deserializedItem);
            }
            return items;
        }
    }
}
