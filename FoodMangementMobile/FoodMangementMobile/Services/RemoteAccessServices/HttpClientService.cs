using System.Net.Http;
using System.Threading.Tasks;

namespace FoodMangementMobile.Services.RemoteAccessServices
{
    public class HttpClientService : IHttpClientService
    {
        public async Task<string> GetHttpClientJsonResponse(string fullUrl)
        {
            string jsonString = string.Empty;
            try
            {
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync(fullUrl))
                    {
                        jsonString = await response.Content.ReadAsStringAsync();
                    }
                }
            }
            catch (System.Exception ex)
            {
                var exception = ex;
                //Log.Logger.Error(ex, "Error in consuming external web service upcdatabase.org");
            }

            return jsonString;
        }
    }
}
