using ClassLibraryEntity;

namespace Admin.Data
{
    public interface ITourGuideRegistrationService
    {
        Task<List<EntTourGuideRegistration>> GetAllTourGuideRegistration();
        Task SaveTourGuideRegistration(EntTourGuideRegistration entity);
        Task DeleteTourGuideRegistration(int id);
        Task UpdateTourGuideRegistration(EntTourGuideRegistration entity);
    }
}
