using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using TradeSim;
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

        public static ObservableCollection<ListData> BoughtCryptos { get; set; }

        
         

        public static List<ListData> FillTheList()
        {
            var ListToReturn = new List<ListData>();
            foreach (var item in Constants.cryptoModels.data.Take(10))
            {
                int dotpostion = item.priceUsd.IndexOf(".");
                
                var NewCrypto = new ListData() { cryptoname = item.name, cryptoprice = item.priceUsd.Substring(0, dotpostion + 3)+" USD" };
                ListToReturn.Add(NewCrypto);
            }
            return ListToReturn;
        }
    }


}