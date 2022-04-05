using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.Data.Entities
{
    public class ProductCategory
    {
        public int product_id { get; set; }
        public int cate_id { get; set; }
        public Product Product { get; set; }
        public Category Category { get; set; }
    }
}
