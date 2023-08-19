using ClassLibraryEntity;

namespace AdminTourGuide.Data
{
    public interface ICityService
    {
        Task<List<EntCities>> GetCities();
    }
}
