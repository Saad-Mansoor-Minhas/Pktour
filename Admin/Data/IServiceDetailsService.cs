using ClassLibraryEntity;

namespace Admin.Data
{
    public interface IServiceDetailsService
    {
        Task<List<EntServiceDetails>> GetAllServiceDetails();
		Task<List<EntServiceDetails>> GetServiceDetails(int SubCatId);
		Task SaveServiceDetails(EntServiceDetails serviceDetails);
        Task DeleteServiceDetails(int id);
        Task UpdateServiceDetails(EntServiceDetails serviceDetails);
    }
}
