using ClassLibraryEntity;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;

namespace Admin.Data
{
    public class TourGuideRegistrationService : ITourGuideRegistrationService
    {

        private readonly HttpClient _httpClient;
        public TourGuideRegistrationService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task DeleteTourGuideRegistration(int id)
        {
            await _httpClient.DeleteAsync("api/deletetourguideregistration/" + id);
        }

        public async Task<List<EntTourGuideRegistration>> GetAllTourGuideRegistration()
        {
            return await _httpClient.GetFromJsonAsync<List<EntTourGuideRegistration>>("api/gettourguidesinfo");
        }

        public async Task SaveTourGuideRegistration(EntTourGuideRegistration entity)
        {
            await _httpClient.PostAsJsonAsync("api/registertourguide", entity);
        }

        public async Task UpdateTourGuideRegistration(EntTourGuideRegistration entity)
        {
            await _httpClient.PutAsJsonAsync<EntTourGuideRegistration>("api/updatetourguideregistration", entity);
        }
    }
}
