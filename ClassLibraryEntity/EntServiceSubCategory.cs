using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEntity
{
    public class EntServiceSubCategory
    {
        public int pk_SubCategoryId { get; set; }
        public int fk_CategoryId { get; set; }
        public string Title { get; set; }
    }
}
