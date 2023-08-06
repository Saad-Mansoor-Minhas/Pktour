using ClassLibraryEntity;

namespace Users.Data
{
	public class TGRegistrationService : ITGRegistrationService
	{
		private readonly HttpClient _httpClient;
		public TGRegistrationService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}
		public async Task RegisterTourGuide(RegistrationModel registerTourGuide)
		{
			await _httpClient.PostAsJsonAsync("api/registertourguide", registerTourGuide);
		}

    }
}
