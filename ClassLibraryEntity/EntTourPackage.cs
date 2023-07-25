using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEntity
{
    public class EntTourPackage
    {
        public int pk_PackageId { get; set; }
        public int fk_TourGuideId { get; set; }
        public string Title { get; set; }
        public string Duration { get; set; }
        public float Pricing { get; set; }
        public string? FromCity { get; set; }
        public string? ToCity { get; set; }

    }
}
