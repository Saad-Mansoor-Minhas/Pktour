using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEntity
{
    public class EntCompanyServices
    {
        public int pk_CompanyServiceId { get; set; }
        public int fk_CompanyId { get; set; }	
        public string? ServicesDescription { get; set; }

    }
}
