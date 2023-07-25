using ClassLibraryEntity;

namespace Admin.Data
{
    public interface ICityService
    {
        Task<List<EntCities>> GetCities();
        Task SaveCity(EntCities entity);
        Task DeleteCity(int id);
        Task UpdateCity(EntCities entity);

    }

}
