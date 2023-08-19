using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEntity
{
    public class EntAreas
    {
        public int pk_AreaId { get; set; }
        public string? AreaName { get; set; }
	    public int fk_CityId { get; set; }
    }
}
