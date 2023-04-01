using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TradeSim
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShoppingPage : ContentPage
    {
        public ShoppingPage()
        {
            InitializeComponent();

            listView.ItemsSource = new List<ListData>
            {
                new ListData {cryptoname= "Bitcoin",cryptostatus = "Rośniee"},
                new ListData {cryptoname= "Etherium",cryptostatus = "Rośniee"},
                new ListData {cryptoname= "Test1", cryptostatus = "Maleje"},
                new ListData {cryptoname= "Test2", cryptostatus = "Maleje"}
            };
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}