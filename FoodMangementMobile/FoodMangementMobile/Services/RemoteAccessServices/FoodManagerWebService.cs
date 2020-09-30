using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FoodMangementMobile.Models;
using Newtonsoft.Json;

namespace FoodMangementMobile.Services.RemoteAccessServices
{
    public class FoodMangementWebService : IFoodMangementWebService
    {
        //private string _remoteUrl = "https://foodstoragemanagementservice20200928234324.azurewebsites.net/api/ProductLookup/078742088822";
        private string _remoteUrl = "https://foodstoragemanagementservice20200928234324.azurewebsites.net/api/ProductLookup/";
        private IHttpClientService _httpClientService;

        public FoodMangementWebService(IHttpClientService httpClientService)
        {
            _httpClientService = httpClientService;
        }

        public async Task<ProductDetailsDto> GetProductInfo(string upcInput)
        {
            string responseString = await _httpClientService.GetHttpClientJsonResponse(_remoteUrl + upcInput);
            ProductDetailsDto productDetails = JsonConvert.DeserializeObject<ProductDetailsDto>(responseString);
            return productDetails;
        }
    }
}
