using System.ComponentModel;
using Xamarin.Forms;
using FoodMangementMobile.ViewModels;

namespace FoodMangementMobile.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}