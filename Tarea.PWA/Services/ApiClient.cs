using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Tarea.Shared.ApiModels;
using Tarea.Shared.Interfaces;

namespace Tarea.PWA.Services
{
    public class ApiClient : IApiClient
    {
        private readonly HttpClient _httpClient;
        public ApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<ICollection<Region>> GetRegiones()
        {
            var response = await _httpClient.GetAsync("https://ailive-public.s3.amazonaws.com/regiones.json");
            response.EnsureSuccessStatusCode();
            var regiones = JsonConvert.DeserializeObject<ICollection<Region>>(await response.Content.ReadAsStringAsync());
            return regiones.OrderBy(x => x.Nombre).ToList();       
        }
    }
}
