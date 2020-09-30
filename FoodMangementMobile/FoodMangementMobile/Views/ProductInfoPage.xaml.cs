using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodMangementMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodMangementMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductInfoPage : ContentPage
    {
        private ProductInfoViewModel _productInfoViewModel;

        public ProductInfoPage(ProductInfoViewModel productInfoViewModel)
        {
            InitializeComponent();
            _productInfoViewModel = productInfoViewModel;
            this.BindingContext = _productInfoViewModel;
        }

        private async void BackButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}