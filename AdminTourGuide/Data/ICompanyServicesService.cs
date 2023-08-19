using ClassLibraryEntity;

namespace AdminTourGuide.Data
{
	public interface ICompanyServicesService
	{
		Task<List<EntCompanyServices>> GetCompanyServices(int companyId);
		Task SaveCompanyServices(EntCompanyServices services);
	}
}
