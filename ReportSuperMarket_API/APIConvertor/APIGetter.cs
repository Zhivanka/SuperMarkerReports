using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ReportSuperMarket_API
{
    internal class APIGetter
    {
        public static async Task<JArray> GetJsonApi(string apiUrl)
        {

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetStringAsync(apiUrl);
                return JArray.Parse(response);
            }
        }

    }
}
