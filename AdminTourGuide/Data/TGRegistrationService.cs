using ClassLibraryEntity;
namespace AdminTourGuide.Data
{
    public class TGRegistrationService : ITGRegistrationService
    {
        private readonly HttpClient _httpClient;
        public TGRegistrationService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<EntTourGuideRegistration> GetTourGuideProfile(int tourGuideId)
        {
           List<EntTourGuideRegistration> et = new List<EntTourGuideRegistration>();
           et= await _httpClient.GetFromJsonAsync<List<EntTourGuideRegistration>>($"api/tourguide/myprofile/{tourGuideId}");
            return et[0];
        }

        public async Task UpdateTourGuide(EntTourGuideRegistration entTourGuide)
        {
            await _httpClient.PutAsJsonAsync("api/tourguide/updateprofile", entTourGuide);
        }
    }
}
