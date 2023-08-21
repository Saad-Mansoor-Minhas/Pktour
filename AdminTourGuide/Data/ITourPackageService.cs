using ClassLibraryEntity;
namespace AdminTourGuide.Data
{
	public interface ITourPackageService
	{
		Task<List<EntTourPackage>> GetTourPackages(int companyId);
		Task SaveTourPackage(EntTourPackage tourPackage);
		Task DeleteTourPackage(int companyId);
		Task UpdateTourPackage(EntTourPackage tourPackage);
	}
}
