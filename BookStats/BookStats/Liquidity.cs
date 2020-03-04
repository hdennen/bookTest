using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace BookStats
{
    class Liquidity
    {
        static HttpClient client = new HttpClient();
        static String url = "https://api-pub.bitfinex.com/v2/";
        static String pathParams = "book/tBTCUSD/P0"; // Change based on desired pairs and precision
        static String queryParams = ""; // Change these based on relevant query params

        public static async Task GetBookSnapshot() 
        {
            String bookEntries;
            HttpResponseMessage response = await client.GetAsync(url + pathParams);

            if (response.IsSuccessStatusCode)
            {
                bookEntries = await response.Content.ReadAsStringAsync();
                String entriesJson = "{\"entries\": " + bookEntries + "}";
                JObject jsonEntries = JObject.Parse(entriesJson);

                Console.WriteLine(jsonEntries.First);
                //Console.WriteLine(bookEntries);
            }
        }
    }
}
