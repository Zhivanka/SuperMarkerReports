using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSuperMarket_API
{
    //handles the printing of the product informations based on the provided propery parameters
    internal class ProductReportPrinter
    {
        public List<ProductPropertyParameters> PropertyInfos { get; } = new List<ProductPropertyParameters>
        {
            new ProductPropertyParameters
            {
                Name="Name",
                Format="...{0}"
            },
             new ProductPropertyParameters
            {
                Name="Price",
                Format="   Price: ${0:F1}"
            },
              new ProductPropertyParameters
            {
                Name="Description",
                Format="   {0}",
                TrunincationLength=10
            },
              new ProductPropertyParameters
              {
                  Name="Weight",
                  Format="   Weight: {0}",
                  Suffix="g"
              }
        };


        public void PrintProductInfo<T>(T item)
        {

            foreach (var propertyFormat in PropertyInfos)
            {
                var property = typeof(T).GetProperty(propertyFormat.Name);

                if (property != null)
                {
                    var value = property.GetValue(item);
                    var formattedValue = Formater.FormatWithSuffix(propertyFormat.Format, value, propertyFormat.Suffix, propertyFormat.Name);


                    if (propertyFormat.TrunincationLength.HasValue)
                    {
                        formattedValue = TextTruncator.TruncateWithSpace(formattedValue, propertyFormat.TrunincationLength.Value);
                    }


                    Console.WriteLine($"{formattedValue}");
                }

                else
                {
                    Console.WriteLine("N/A");
                }

            }
        }
    }
}
