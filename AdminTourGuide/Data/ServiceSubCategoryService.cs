using ClassLibraryEntity;

namespace AdminTourGuide.Data
{
	public class ServiceSubCategoryService:IServiceSubCategoryService
	{
		private readonly HttpClient _httpClient;

		public ServiceSubCategoryService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}
		public async Task<List<EntServiceSubCategory>> GetServiceSubCategory(int serviceCategoryId)
		{
			return await _httpClient.GetFromJsonAsync<List<EntServiceSubCategory>>("api/tourguide/getservicesubcategory/" + serviceCategoryId);
		}

		public async Task<List<EntServiceSubCategory>> GetAllServiceSubCategory()
		{
			return await _httpClient.GetFromJsonAsync<List<EntServiceSubCategory>>("api/tourguide/getallservicesubcategory");
		}
	}
}
