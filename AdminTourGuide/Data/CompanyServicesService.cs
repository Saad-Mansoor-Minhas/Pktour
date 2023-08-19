using ClassLibraryEntity;

namespace AdminTourGuide.Data
{
	public class CompanyServicesService : ICompanyServicesService
	{
		private readonly HttpClient _httpClient;
		public CompanyServicesService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}
		public async Task<List<EntCompanyServices>> GetCompanyServices(int companyId)
		{
			return await _httpClient.GetFromJsonAsync<List<EntCompanyServices>>($"api/tourguide/getcompanyservices/{companyId}");
		}

		public async Task SaveCompanyServices(EntCompanyServices services)
		{
			await _httpClient.PostAsJsonAsync("api/tourguide/savecompanyservices", services);
		}
	}
}
