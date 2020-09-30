using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodMangementMobile.Services.RemoteAccessServices;
using FoodMangementMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodMangementMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductLookup : ContentPage
    {
        private IHttpClientService _httpClientService;
        private IFoodMangementWebService _foodMangementWebService;
        public ProductLookup()
        {
            InitializeComponent();
            _httpClientService = new HttpClientService();
            _foodMangementWebService = new FoodMangementWebService(_httpClientService);
        }

        private async void UpcScanButton_OnClicked(object sender, EventArgs e)
        {
            ProductInfoViewModel productInfoViewModel = new ProductInfoViewModel(_foodMangementWebService);
            await productInfoViewModel.GetInfoForUpc(UpcEntry.Text);
            await Navigation.PushAsync(new ProductInfoPage(productInfoViewModel));
        }
    }
}