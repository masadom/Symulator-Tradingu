using RetrieveApiDataSample;
using RetrieveApiDataSample.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TradeSim;
using Xamarin.Forms;

namespace TradeSim
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
            
            //var nazwa1 = ;
            //var nazwa2 = Constants.cryptoModels.data[2].name;
            //var nazwa3 = Constants.cryptoModels.data[3].name;
            //var nazwa4 = Constants.cryptoModels.data[4].name;
           // FillTheList();

            //UserData User = 

            //    new List<>
            //{
            //    new ListData {cryptoname= Constants.cryptoModels.data[1].name, cryptoprice = "Rośniee"},
            //    new ListData {cryptoname= "sda", cryptoprice = "Rośniee"},
            //    new ListData {cryptoname= "sda", cryptoprice = "Maleje"},
            //    new ListData {cryptoname= "fdr", cryptoprice = "Maleje"}
            //};


        }

       // public int MyCrypto { get; set; }



        async private void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShoppingPage());
        }

        async private void CryptoSell_Clicked(object sender, EventArgs e)
        {
            

            bool answer = await DisplayAlert("Sprzedaż", "Czy chcesz sprzedać?", "Tak", "Nie");
            //Debug.WriteLine("Answer: " + answer);
            if (answer)
            {
                var button = (Button)sender;
                ListData currentobject = (ListData)button.BindingContext;
                Constants.BoughtCryptos.Remove(currentobject);
            }
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var result = await App.RestApiService.GetCryptoAsync("a song of ice and fire");
            //apiResult.Text = $"Liczba publikacji: {result.docs.Count()} == {result.num_found}";
            //RestService zmienna = new RestService();
            //var result2 = await zmienna.GetCryptoAsync(string.Empty);
            //crypto.Text = Constants.cryptoModels.data[15].priceUsd; ;

            MainPageListView.ItemsSource = Constants.BoughtCryptos;

        }

    }
}
