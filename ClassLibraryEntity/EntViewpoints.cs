using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEntity
{
    public class EntViewpoints
    {
        public int pk_ViewpointId { get; set; }

        public int fk_CityId { get; set; }
        public string? VpName { get; set; }
        public string? VpDetailEng { get; set; }
        public string? VpDetailUrdu { get; set; }

    }
}
