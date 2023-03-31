using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            var result = await App.RestApiService.GetBooksAsync("a song of ice and fire");
            apiResult.Text = $"Liczba publikacji: {result.docs.Count()} == {result.num_found}";
        }
    }
}
