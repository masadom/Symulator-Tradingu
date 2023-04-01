using RetrieveApiDataSample.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RetrieveApiDataSample
{
    public partial class MainPage : ContentPage
    {
        class UserData
        {
            public double actualamountofmoney { get; set; }

            public string DisplayMoney => $"Amount of money: {actualamountofmoney}";
        }
        //class BoughtCrypto
        //{
        //    public string boughtcrypto { get; set; }


        //}
        public MainPage()
        {
            InitializeComponent();


            //UserData User = 

            MainPageListView.ItemsSource = new List<ListData>
            {
                new ListData {cryptoname= "Bitcoin",cryptostatus = "Rośniee"},
                new ListData {cryptoname= "Etherium",cryptostatus = "Rośniee"},
                new ListData {cryptoname= "Test1", cryptostatus = "Maleje"},
                new ListData {cryptoname= "Test2", cryptostatus = "Maleje"}
            };

        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShoppingPage());
        }

        private void CryptoSell_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Sprzedaż", "Czy chcesz sprzedać?", "Ok");

            
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
