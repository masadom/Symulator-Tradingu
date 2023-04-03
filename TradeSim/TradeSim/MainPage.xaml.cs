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
using TradeSim.Models;
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
        

        
        public MainPage()
        {

            InitializeComponent();
            


        }




        async private void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShoppingPage());
        }

        async private void CryptoSell_Clicked(object sender, EventArgs e)
        {
            

            bool answer = await DisplayAlert("Sprzedaż", "Czy chcesz sprzedać?", "Tak", "Nie");
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


            MainPageListView.ItemsSource = Constants.BoughtCryptos;

        }

    }
}
