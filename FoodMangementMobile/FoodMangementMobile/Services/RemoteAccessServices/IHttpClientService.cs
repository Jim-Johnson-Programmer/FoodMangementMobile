using System.Threading.Tasks;

namespace FoodMangementMobile.Services.RemoteAccessServices
{
    public interface IHttpClientService
    {
        Task<string> GetHttpClientJsonResponse(string fullUrl);
    }
}