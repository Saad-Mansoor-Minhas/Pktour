using ClassLibraryEntity;

namespace Admin.Data
{
	public interface IServiceSubCategoryService
	{
		Task<List<EntServiceSubCategory>> GetServiceSubCategory(int serviceCategoryId);
		Task SaveServiceSubCategory(EntServiceSubCategory serviceSubCategory);
		Task DeleteServiceSubCategory(int id);
		Task UpdateServiceSubCategory(EntServiceSubCategory serviceSubCategory);
		Task<List<EntServiceSubCategory>> GetAllServiceSubCategory();
	}
}
