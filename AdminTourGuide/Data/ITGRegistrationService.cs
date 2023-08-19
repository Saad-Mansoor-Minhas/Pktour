using ClassLibraryEntity;

namespace AdminTourGuide.Data
{
   
    public interface ITGRegistrationService
    {
        Task UpdateTourGuide(EntTourGuideRegistration entTourGuide);
        Task<EntTourGuideRegistration> GetTourGuideProfile(int tourGuideId);
    }
}
