using ClassLibraryEntity;

namespace Users.Data
{
	public interface ITGRegistrationService
	{
		Task RegisterTourGuide(RegistrationModel registerTourGuide);
	}
}
