using ClassLibraryEntity;
namespace AdminTourGuide.Data
{
	public interface ICompanyRegistrationService
	{
		Task<List<EntCompanyRegistration>> GetTourGuideCompanies(int TourGuideId);
		Task SaveCompany(EntCompanyRegistration entCompany);
		Task UpdateCompany(EntCompanyRegistration entCompany);

	}
}
