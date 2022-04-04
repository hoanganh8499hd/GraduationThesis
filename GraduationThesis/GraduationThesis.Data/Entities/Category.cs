using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.Data.Entities
{
    public class Category
    {
        public Category(int id ,string cate_name, string cate_slug, DateTime create_at, DateTime? update_at, DateTime? delete_at, bool isActive, bool isDelete, int? parent_id)
        {
            this.id = id;
            this.cate_name = cate_name;
            this.cate_slug = cate_slug;
            this.create_at = create_at;
            this.update_at = update_at;
            this.delete_at = delete_at;
            this.isActive = isActive;
            this.isDelete = isDelete;
            this.parent_id = parent_id;
        }

        public int id { get; set; }
        public string cate_name { get; set; }
        public string cate_slug { get; set; }
        public int? parent_id { get; set; }
        public bool isActive { get; set; }
        public bool isDelete { get; set; }
        public DateTime create_at { get; set; }
        public DateTime? update_at { get; set; }
        public DateTime? delete_at { get; set; }
        public List<ProductCategory> ProductInCategory { get; set; }
    }
}
