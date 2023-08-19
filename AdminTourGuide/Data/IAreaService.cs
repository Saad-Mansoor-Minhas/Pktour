using ClassLibraryEntity;

namespace AdminTourGuide.Data
{
	public interface IAreaService
	{
		Task<List<EntAreas>> GetAreas();
		Task<List<EntAreas>> GetCityAreas(int cityId);
	}
}
