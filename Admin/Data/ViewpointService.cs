using ClassLibraryEntity;
using System.Net.Http.Json;

namespace Admin.Data
{
	public class ViewpointService : IViewpointService
	{
		private readonly HttpClient _httpClient;
		public ViewpointService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task<List<EntViewpoints>> GetViewpoints()
		{
			return await _httpClient.GetFromJsonAsync<List<EntViewpoints>>("api/getviewpoints");
		}

		public async Task SaveViewpoint(EntViewpoints viewpoint)
		{
			await _httpClient.PostAsJsonAsync("api/saveviewpoint", viewpoint);
		}

		public async Task UpdateViewpoint(EntViewpoints viewpoint)
		{
			await _httpClient.PutAsJsonAsync<EntViewpoints>("api/updateviewpoint", viewpoint);
		}
		public async Task DeleteViewpoint(int id)
		{
			await _httpClient.DeleteAsync("api/deleteviewpoint/" + id);
		}

		public async Task<List<EntViewpoints>> GetCityViewpoints(int id)
		{
			return await _httpClient.GetFromJsonAsync<List<EntViewpoints>>($"api/getcityviewpoints/{id}");
		}
	}
}
