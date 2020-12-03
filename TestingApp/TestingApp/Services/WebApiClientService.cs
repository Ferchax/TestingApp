using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.Services
{
    public class WebApiClientService
    {
        public async Task<T> Get<T>()
        {
            var httpClient = new HttpClient();

            httpClient.BaseAddress = new Uri("https://dacservicesdiagnosticapp.azurewebsites.net");

            var response = await httpClient.GetAsync("/api/ServiceUsuario");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<T>(json);
            }
            else 
            {
                return default(T);
            }
        }
    }
}
