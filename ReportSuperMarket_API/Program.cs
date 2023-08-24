using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;


namespace ReportSuperMarket_API
{
    internal class Program
    {
   
        static async Task Main(string[] args)
        {
            //1.Get API (return JArray)
            var recieptDetails = await APIGetter.GetJsonApi("https://interview-task-api.mca.dev/qr-scanner-codes/alpha-qr-gFpwhsQ8fkY1");

            //2.Deserialize - convert Json to Product objects
            var products = Deserializator.Deserialize<Product>(recieptDetails);

            //3. Sort the product by name
            var sortedProducts = Sorter<Product>.SortByName(products);

            //4.generate the the report
            ReportGenerator report =  new ReportGenerator();
            report.GenerateDomesticReport(sortedProducts, p=>p.Domestic);
        }





       
    }
}
