using ClassLibraryEntity;

namespace AdminTourGuide.Data
{
	public class ServiceDetailsService : IServiceDetailsService
	{
		private readonly HttpClient _httpClient;
		public ServiceDetailsService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}
		public async Task<List<EntServiceDetails>> GetServiceDetails(int SubCatId)
		{
			return await _httpClient.GetFromJsonAsync<List<EntServiceDetails>>($"api/tourguide/getservicedetails/{SubCatId}");
		}

		public async Task<List<EntServiceDetails>> GetAllServiceDetails()
		{
			return await _httpClient.GetFromJsonAsync<List<EntServiceDetails>>("api/tourguide/getallservicedetails");
		}
	}
}
