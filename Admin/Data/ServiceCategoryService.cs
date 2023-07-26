using Admin.Pages;
using ClassLibraryEntity;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Admin.Data
{
	public class ServiceCategoryService : IServiceCategoryService
	{
		private readonly HttpClient _httpClient;
		public ServiceCategoryService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}
		public async Task DeleteServiceCategory(int id)
		{
			await _httpClient.DeleteAsync("api/deleteservicecategory/" + id);
		}

		public async Task<List<EntServiceCategory>> GetServiceCategory()
		{
			return await _httpClient.GetFromJsonAsync<List<EntServiceCategory>>("/api/getservicecategory");
		}

		public async Task SaveServiceCategory(EntServiceCategory serviceCategory)
		{
			await _httpClient.PostAsJsonAsync("api/saveservicecategory", serviceCategory);
		}

		public async Task UpdateServiceCategory(EntServiceCategory serviceCategory)
		{
			await _httpClient.PutAsJsonAsync<EntServiceCategory>("api/updateservicecategory", serviceCategory);
		}
	}
}
