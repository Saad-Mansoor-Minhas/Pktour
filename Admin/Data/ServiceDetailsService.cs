using ClassLibraryEntity;

namespace Admin.Data
{
    public class ServiceDetailsService : IServiceDetailsService
    {
        private readonly HttpClient _httpClient;
        public ServiceDetailsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task DeleteServiceDetails(int id)
        {
            await _httpClient.DeleteAsync($"api/deleteservicedetail/{id}");   
        }

        public async Task<List<EntServiceDetails>> GetAllServiceDetails()
        {
            return await _httpClient.GetFromJsonAsync<List<EntServiceDetails>>("api/getallservicedetails");
        }

		public async Task<List<EntServiceDetails>> GetServiceDetails(int SubCatId)
		{
			return await _httpClient.GetFromJsonAsync<List<EntServiceDetails>>($"api/getservicedetails/{SubCatId}");
		}

		public async Task SaveServiceDetails(EntServiceDetails serviceDetails)
        {
           await _httpClient.PostAsJsonAsync("api/saveservicedetail", serviceDetails);
        }

        public async Task UpdateServiceDetails(EntServiceDetails serviceDetails)
        {
            await _httpClient.PutAsJsonAsync<EntServiceDetails>("api/updateservicedetail", serviceDetails);
        }
    }
}
