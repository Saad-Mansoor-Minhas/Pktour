using ClassLibraryEntity;

namespace AdminTourGuide.Data
{
	public interface IServiceCategoryService
	{
		Task<List<EntServiceCategory>> GetServiceCategory();
	}
}
