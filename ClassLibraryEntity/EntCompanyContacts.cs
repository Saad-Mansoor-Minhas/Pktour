using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEntity
{
    public class EntCompanyContacts
    {
         public int pk_CompanyContactId { get; set; }
         public int fk_CompanyId { get; set; }
         public string? ContactType { get; set; }
         public string?  ContactNum { get; set; }

    }
}
