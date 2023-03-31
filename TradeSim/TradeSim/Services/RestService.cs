using Newtonsoft.Json;
using RetrieveApiDataSample.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

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
            var responseModel = new ApiResponse();

            string modQuery = query.Replace(" ", "+");
            Uri uri = new Uri($"{Constants.RestUrl}?q={query}");
            try
            {
                HttpResponseMessage response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    responseModel = JsonConvert.DeserializeObject<ApiResponse>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return responseModel;
        }
    }
}
