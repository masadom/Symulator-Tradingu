using System.Collections.Generic;
using TradeSim.Models;

namespace RetrieveApiDataSample.Services
{
    public class Constants
    {
        // api documentation
        // api.coincap.io/v2/assets
        public static string RestUrl { get => "api.coincap.io/v2/assets";  }
        public static string Remove { get; set; }

        public static cryptoModel cryptoModels { get; set; }
    }
}