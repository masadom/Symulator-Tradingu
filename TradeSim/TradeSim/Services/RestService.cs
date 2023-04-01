using Newtonsoft.Json;
using RetrieveApiDataSample.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TradeSim.Models;

namespace RetrieveApiDataSample.Services
{
    public class RestService : IRestService
    {
        private HttpClient client;

        public RestService()
        {
            client = new HttpClient();
        }

        public async Task<ApiResponse> GetCryptoAsync(string query)
        {
            //HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create("api.coincap.io/v2/assets");
            Constants.Remove = "jebac xamarine";
            var responseModel = new ApiResponse();


            string html = string.Empty;
            Uri url = new Uri(@"https://api.coincap.io/v2/assets");

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }
            Constants.Remove = html;
            

            Constants.cryptoModels = JsonConvert.DeserializeObject<cryptoModel>(html);

            //string modQuery = query.Replace(" ", "+");
            //Uri uri = new Uri($"{Constants.RestUrl}?q={query}");
            //try
            //{
            //    HttpResponseMessage response = await client.GetAsync("api.coincap.io/v2/assets");
            //    if (response.IsSuccessStatusCode)
            //    {
            //        string content = await response.Content.ReadAsStringAsync();
            //        Constants.Remove = content;
            //        responseModel = JsonConvert.DeserializeObject<ApiResponse>(content);


            //    }
            //    else Constants.Remove = "ale shit";
            //}
            //catch (Exception ex)
            //{
            //    Debug.WriteLine(@"\tERROR {0}", ex.Message);
            //}

            return responseModel;
        }
    }
}
