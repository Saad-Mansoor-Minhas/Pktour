using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEntity
{
    public class EntServiceDetails
    {
        public int pk_ServiceDetailId { get; set; }
        public int fk_CategoryId { get; set; }
        public int fk_SubCategoryId { get; set; }
        public string Title { get; set; }
        public float Price { get; set; }
        public float Quantity { get; set; }
        public string Unit { get; set; }
    }
}
