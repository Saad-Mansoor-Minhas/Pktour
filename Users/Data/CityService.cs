using ClassLibraryEntity;

namespace Users.Data
{
	public class CityService : ICityService
	{
		private readonly HttpClient _httpClient;
		public CityService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}
		public async Task<List<EntCities>> GetCities()
		{
			return await _httpClient.GetFromJsonAsync<List<EntCities>>("api/user/getcities");
		}
	}
}
