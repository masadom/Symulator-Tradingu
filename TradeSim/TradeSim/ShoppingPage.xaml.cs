using RetrieveApiDataSample;
using RetrieveApiDataSample.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeSim.Models;
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

          
            listView.ItemsSource = Constants.FillTheList();
            if(Constants.BoughtCryptos == null)
            Constants.BoughtCryptos = new ObservableCollection<ListData>();

        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async private void Button_Clicked_buy(object sender, EventArgs e)
        {

            bool answer = await DisplayAlert("Question?", "Would you like to play a game", "Yes", "No");
            if (answer)
            {
                var button = (Button)sender;
                ListData currentobject = (ListData)button.BindingContext;
                if(!Constants.BoughtCryptos.Any(x=>x.cryptoname==currentobject.cryptoname))
                Constants.BoughtCryptos.Add(currentobject);
            }
        }

        
    }
}