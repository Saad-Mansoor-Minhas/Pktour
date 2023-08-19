using ClassLibraryEntity;

namespace AdminTourGuide.Data
{
	public class AreaService : IAreaService
	{
		private readonly HttpClient _httpClient;
		public AreaService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}
		public async Task<List<EntAreas>> GetAreas()
		{
			 return await _httpClient.GetFromJsonAsync<List<EntAreas>>("api/tourguide/getareas");
		}

		public async Task<List<EntAreas>> GetCityAreas(int cityId)
		{
			return await _httpClient.GetFromJsonAsync<List<EntAreas>>($"api/tourguide/getcityareas/{cityId}");
		}
	}
}
