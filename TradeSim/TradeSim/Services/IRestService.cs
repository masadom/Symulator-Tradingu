using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RetrieveApiDataSample.Model;

namespace RetrieveApiDataSample.Services
{
    public interface IRestService
    {
        Task<ApiResponse> GetCryptoAsync(string query);
    }
}
