using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEntity
{
    public class EntCompanyEmployeeRegistration
    {
        public int pk_CompanyMemberId { get; set; }
        public int fk_CompanyId { get; set; }
        public int fk_CityId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? DOB { get; set; }
        public string? Gender { get; set; }
        public string? Role { get; set; }
        public string? CNIC { get; set; }
        public string? Mobile { get; set; }
        public string? WhatsappNum { get; set; }
        public string? Sector { get; set; }
        public string? RegDate { get; set; }
        public string? RegTime { get; set; }
        public bool RegStatus { get; set; }

    }
}
