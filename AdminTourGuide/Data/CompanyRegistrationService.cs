using ClassLibraryEntity;

namespace AdminTourGuide.Data
{
	public class CompanyRegistrationService : ICompanyRegistrationService
	{
		private readonly HttpClient _httpClient;
		public CompanyRegistrationService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}
		public async Task<List<EntCompanyRegistration>>GetTourGuideCompanies(int tourGuideId)
		{
			return await _httpClient.GetFromJsonAsync<List<EntCompanyRegistration>>($"api/tourguide/gettourguidecompanies/{tourGuideId}");
		}

        public async Task SaveCompany(EntCompanyRegistration entCompany)
        {
			await _httpClient.PostAsJsonAsync("api/tourguide/", entCompany);
        }

        public async Task UpdateCompany(EntCompanyRegistration entCompany)
        {
			await _httpClient.PutAsJsonAsync("api/tourguide/", entCompany);
        }

	}
}
