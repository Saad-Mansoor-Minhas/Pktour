using ClassLibraryEntity;

namespace Users.Data
{
	public interface ICityService
	{
		Task<List<EntCities>> GetCities();
	}
}
