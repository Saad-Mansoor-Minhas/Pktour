using ClassLibraryEntity;

namespace AdminTourGuide.Data
{
	public class TourPackageService:ITourPackageService
	{
		private readonly HttpClient _httpClient;
		public TourPackageService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task DeleteTourPackage(int companyId)
		{
			await _httpClient.DeleteAsync($"api/tourguide/deletetourpackage/{companyId}");
		}

		public async Task<List<EntTourPackage>> GetTourPackages(int companyId)
		{
			return await _httpClient.GetFromJsonAsync<List<EntTourPackage>>($"api/tourguide/gettourpackage/{companyId}");
		}

		public async Task SaveTourPackage(EntTourPackage tourPackage)
		{
			await _httpClient.PostAsJsonAsync("api/tourguide/savetourpackage", tourPackage);
		}

		public async Task UpdateTourPackage(EntTourPackage tourPackage)
		{
			await _httpClient.PutAsJsonAsync("api/tourguide/updatetourpackage", tourPackage);
		}
	}
}
