using RetrieveApiDataSample.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RetrieveApiDataSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var result = await App.RestApiService.GetCryptoAsync("a song of ice and fire");
            //apiResult.Text = $"Liczba publikacji: {result.docs.Count()} == {result.num_found}";
            RestService zmienna = new RestService();
            var result2 = await zmienna.GetCryptoAsync(string.Empty);
            crypto.Text = Constants.cryptoModels.data[15].priceUsd; ;
        }
    }
}
