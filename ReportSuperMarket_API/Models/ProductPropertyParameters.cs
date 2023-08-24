using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSuperMarket_API
{

    //Parameters about each property of the Product class
    internal class ProductPropertyParameters
    {
        public string Name { get; set; }
        public string Format { get; set; }
        public int? TrunincationLength { get; set; }
        public string Suffix { get; set; }
    }
}
