using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TradeSim
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            var client = new RestClient("https://rest.coinapi.io/v1/exchangerate/BTC/USD");
            var request = new RestRequest(Method.GET);
            request.AddHeader("X-CoinAPI-Key", "73034021-THIS-IS-SAMPLE-KEY");
            IRestResponse response = client.Execute(request);

            InitializeComponent();
        }


        

    }
}
