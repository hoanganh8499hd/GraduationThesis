using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.Data.Entities
{
    internal class Coupon
    {
        public int id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public double? min_order_value { get; set; }
        public double? max_price { get; set; }
        public double value { get; set; }
        public int? quantity { get; set; }
        public bool isActive { get; set; }
        public DateTime start_at { get; set; }
        public DateTime end_at { get; set; }
        public List<Order> Orders { get; set; }
    }
}
