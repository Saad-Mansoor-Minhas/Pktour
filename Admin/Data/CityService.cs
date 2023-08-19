using ClassLibraryEntity;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;

namespace Admin.Data
{
    public class CityService : ICityService
    {

        private readonly HttpClient _httpClient;
        public CityService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<EntCities>> GetCities() {

            return await _httpClient.GetFromJsonAsync<List<EntCities>>("api/getcities");
        }

		public async Task SaveCity(EntCities entity)
		{
			await _httpClient.PostAsJsonAsync("api/savecity",entity);

		}
		public async Task DeleteCity(int citycode)
		{
			await _httpClient.DeleteAsync("api/deletecity/"+citycode);
		}
		public async Task UpdateCity(EntCities entity)
		{
			await _httpClient.PutAsJsonAsync<EntCities>("api/updatecity",entity);
		}
	}
}
