using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEntity
{
	public class RegistrationModel
	{
		public EntTourGuideRegistration TourGuide { get; set; } = new EntTourGuideRegistration();
		public EntCompanyRegistration? TourGuideCompany { get; set; } = new EntCompanyRegistration();
    }

}
