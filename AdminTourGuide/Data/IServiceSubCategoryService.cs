using ClassLibraryEntity;

namespace AdminTourGuide.Data
{
	public interface IServiceSubCategoryService
	{
		Task<List<EntServiceSubCategory>> GetServiceSubCategory(int serviceCategoryId);
		Task<List<EntServiceSubCategory>> GetAllServiceSubCategory();
	}
}
