using ClassLibraryEntity;

namespace AdminTourGuide.Data
{
	public interface IServiceDetailsService
	{
		Task<List<EntServiceDetails>> GetServiceDetails(int SubCatId);
		Task<List<EntServiceDetails>> GetAllServiceDetails();

	}
}
