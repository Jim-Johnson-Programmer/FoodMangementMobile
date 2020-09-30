using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FoodMangementMobile.Models;
using FoodMangementMobile.Services.RemoteAccessServices;

namespace FoodMangementMobile.ViewModels
{
    public class ProductInfoViewModel
    {
        private IFoodMangementWebService _foodMangementWebService;
        private ProductDetailsDto _productDetails { get; set; }

        public string BrandName => _productDetails.BrandName;
        public string CategoryPath => _productDetails.CategoryPath;
        public string RawSize => _productDetails.RawSize;
        public string Upc => _productDetails.Upc;
        public string ImageSourceUrl => _productDetails.ImgLargeUrl.Remove(_productDetails.ImgLargeUrl.IndexOf("?"));

        public ProductInfoViewModel(IFoodMangementWebService foodMangementWebService)
        {
            _foodMangementWebService = foodMangementWebService;
        }

        public async Task GetInfoForUpc(string upcCode)
        {
            _productDetails = await _foodMangementWebService.GetProductInfo(upcCode);
        }
    }
}
