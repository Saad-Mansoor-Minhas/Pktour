using ClassLibraryEntity;

namespace AdminTourGuide.Data
{
	public class ServiceCategoryService : IServiceCategoryService
	{
		private readonly HttpClient _httpClient;
		public ServiceCategoryService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}
		public async Task<List<EntServiceCategory>> GetServiceCategory()
		{
			return await _httpClient.GetFromJsonAsync<List<EntServiceCategory>>("/api/getservicecategory");
		}

	}
}
