using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEntity
{
    public class EntTourGuideRegistration
    {
        public int pk_TourGuideId { get; set; }
        public int fk_CityId { get; set; }
        public string? Name { get; set; }
        public  string? CNIC { get; set; }
        public DateTime? DOB { get; set; }
        public string? Gender { get; set; }
        public string? Sector { get; set; } 
        public string? Email { get; set; }
        public DateTime? RegDate { get; set; }
        public TimeOnly? RegTime { get; set;}
        public bool? RegStatus { get; set;}
		public List<EntTourGuideContacts> Contacts { get; set; } = new List<EntTourGuideContacts>();

	}
}
