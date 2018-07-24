using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EPMS3POC2.Services
{
    public static class Service
    {
        static string apiUrl = "http://localhost:56239/api/";
        public static async Task<List<T>> GetAll<T>(string resource)
        {
            dynamic result = null;
            var response = await new HttpClient().SendAsync(new HttpRequestMessage(HttpMethod.Get, apiUrl + resource));
            if (response.IsSuccessStatusCode)
            {
                result = JsonConvert.DeserializeObject<List<T>>(await response.Content.ReadAsStringAsync());
            }
            return result;
        }
    }
}
