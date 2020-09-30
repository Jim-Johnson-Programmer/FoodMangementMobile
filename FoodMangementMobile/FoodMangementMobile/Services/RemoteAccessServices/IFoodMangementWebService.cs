using System.Threading.Tasks;
using FoodMangementMobile.Models;

namespace FoodMangementMobile.Services.RemoteAccessServices
{
    public interface IFoodMangementWebService
    {
        Task<ProductDetailsDto> GetProductInfo(string upcInput);
    }
}