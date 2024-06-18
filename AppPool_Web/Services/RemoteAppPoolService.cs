using System.Collections.Generic;
using AppPool_Web.Models;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AppPool_Web.Services
{


    public class RemoteAppPoolService
    {
        private readonly string _baseUrl;
        private readonly HttpClient _httpClient;

        public RemoteAppPoolService(string baseUrl)
        {
            _baseUrl = baseUrl;
            _httpClient = new HttpClient();
        }

        public async Task<List<AppPool>> GetAppPoolsAsync()
        {
            var response = await _httpClient.GetStringAsync($"https://localhost:7198/GetNames");
            return JsonConvert.DeserializeObject<List<AppPool>>(response);
        }

        public async Task RecycleAppPoolAsync(string name)
        {
            await _httpClient.PostAsync($"{_baseUrl}/Recycle/{name}", null);
        }

        public async Task StartAppPoolAsync(string name)
        {
            await _httpClient.PostAsync($"{_baseUrl}/Start/{name}", null);
        }

        public async Task StopAppPoolAsync(string name)
        {
            await _httpClient.PostAsync($"{_baseUrl}/Stop/{name}", null);
        }
    }
}
