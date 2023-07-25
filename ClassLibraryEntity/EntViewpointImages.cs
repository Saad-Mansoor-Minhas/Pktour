using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEntity
{
    public class EntViewpointImages
    {
        public int pk_VpImageId { get; set; }
        public string VpImageUrl { get; set; }
        public int fk_ViewpointId { get; set; }
    }
}
