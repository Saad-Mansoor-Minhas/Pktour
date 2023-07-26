using ClassLibraryEntity;

namespace Admin.Data
{
	public interface IServiceCategoryService
	{
		Task<List<EntServiceCategory>> GetServiceCategory();
		Task SaveServiceCategory(EntServiceCategory serviceCategory);
		Task DeleteServiceCategory(int id);
		Task UpdateServiceCategory(EntServiceCategory serviceCategory);
	}
}
