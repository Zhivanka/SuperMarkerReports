using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ReportSuperMarket_API
{
    internal class ReportGenerator
    {

        public void GenerateDomesticReport<T>(IEnumerable<T> items, Func<T, bool> domesticPredicate)
        {
            var domesticItems = items.Where(domesticPredicate).ToList();
            var importedItems = items.Except(domesticItems).ToList();

            ProductReportPrinter productPrinter = new ProductReportPrinter();

            Console.WriteLine(".Domestic");
            foreach (var item in domesticItems)
            {
                productPrinter.PrintProductInfo(item);
            }

            Console.WriteLine(".Imported");
            foreach (var item in importedItems)
            {
                productPrinter.PrintProductInfo(item);
            }


            decimal domesticCost = Calculator.SumTotal<T, decimal>(domesticItems, "Price");
            decimal importedCost = Calculator.SumTotal<T, decimal>(importedItems, "Price");

            int domesticCount = domesticItems.Count();
            int importedCount = importedItems.Count();


            Console.WriteLine($"Domestic cost: ${domesticCost:F1}");
            Console.WriteLine($"Imported cost: ${importedCost:F1}");
            Console.WriteLine($"Domestic count: {domesticCount}");
            Console.WriteLine($"Imported count: {importedCount}");

        }

    }
}
