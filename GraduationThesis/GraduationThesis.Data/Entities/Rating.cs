using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.Data.Entities
{
    public class Rating
    {
        public int product_id { get; set; }
        public int cus_id { get; set; }
        public int score { get; set; }
        public string content { get; set; }
        public DateTime date_rating { get; set; }
        public Product Product { get; set; }
        public Customer Customer { get; set; }
    }
}
