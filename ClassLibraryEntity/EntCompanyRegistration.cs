using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEntity
{
    public class EntCompanyRegistration
    {
        public int pk_CompanyId { get; set; }
        public int fk_TourGuideId { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public int fk_CityId { get; set; }
        public int fk_AreaId { get; set; }
        public string? Address { get; set; }
        public string? Website { get; set; }
        public string? Facebook { get; set; }
        public string? Instagram { get; set; }
        public string? RegDate { get; set; }
        public string? RegTime { get; set; }
        public bool RegStatus { get; set; }
    }
}
