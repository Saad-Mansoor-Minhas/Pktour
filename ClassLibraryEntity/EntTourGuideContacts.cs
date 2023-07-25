using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEntity
{
    public class EntTourGuideContacts
    {
        public int pk_TourGuideContactId { get; set; }
        public int fk_TourGuideId { get; set; }
        public string ContactType { get; set; }
        public string ContactNum { get; set; }

    }
}
