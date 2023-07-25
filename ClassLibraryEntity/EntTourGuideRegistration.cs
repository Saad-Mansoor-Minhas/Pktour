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
        public string Name { get; set; }
        public  string CNIC { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }
        public string Sector { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string RegDate { get; set; }
        public string RegTime { get; set;}
        public bool RegStatus { get; set;}

    }
}
