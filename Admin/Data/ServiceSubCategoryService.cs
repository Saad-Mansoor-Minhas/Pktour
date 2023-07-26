using Admin.Pages;
using ClassLibraryEntity;
using System.Net.Http;

namespace Admin.Data
{
	public class ServiceSubCategoryService : IServiceSubCategoryService
	{
		private readonly HttpClient _httpClient;

		public ServiceSubCategoryService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}
		public async Task DeleteServiceSubCategory(int id)
		{
			await _httpClient.DeleteAsync("api/deleteservicesubcategory/" + id);
		}

		public async Task<List<EntServiceSubCategory>> GetAllServiceSubCategory()
		{
			return await _httpClient.GetFromJsonAsync<List<EntServiceSubCategory>>("api/getallservicesubcategory");
		}
		public async Task<List<EntServiceSubCategory>> GetServiceSubCategory(int serviceCategoryId)
		{
			return await _httpClient.GetFromJsonAsync<List<EntServiceSubCategory>>("api/getservicesubcategory/"+serviceCategoryId);
		}

		public async Task SaveServiceSubCategory(EntServiceSubCategory serviceSubCategory)
		{
			await _httpClient.PostAsJsonAsync("api/saveservicesubcategory", serviceSubCategory);
		}

		public async Task UpdateServiceSubCategory(EntServiceSubCategory serviceSubCategory)
		{
			await _httpClient.PutAsJsonAsync<EntServiceSubCategory>("api/updateservicesubcategory", serviceSubCategory);
		}
	}
}
