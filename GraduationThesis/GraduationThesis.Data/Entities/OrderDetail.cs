using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.Data.Entities
{
    public class OrderDetail
    {
        public int order_id { get; set; }
        public int product_id { get; set; }
        public int quantity { get; set; }
        public decimal unit_price { get; set; }
        public decimal? promotion_price { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
