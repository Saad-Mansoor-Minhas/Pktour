using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEntity
{
    public class EntCompanyPortfolio
    {
        public int pk_PortfolioId { get; set; }
        public int fk_CompanyId { get; set; }
        public string? PortfolioDetails { get; set; }
    }
}
