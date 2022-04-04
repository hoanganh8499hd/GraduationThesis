using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.Data.Entities
{
    public class Product
    {
        public Product(int id, string name, string code, string slug, int brand_id, string image, string more_images, decimal unit_price, decimal promotion_price, int warranty, int? instock, int view_count, string specifications, string short_desc, string descriptions, bool featured, bool best_seller, bool isActive, bool isDelete, string meta_tittle, string meta_keywords, string meta_descriptions, DateTime create_at, DateTime? update_at, DateTime? delete_at)
        {
            this.id = id;
            this.name = name;
            this.code = code;
            this.slug = slug;
            this.brand_id = brand_id;
            this.image = image;
            this.more_images = more_images;
            this.unit_price = unit_price;
            this.promotion_price = promotion_price;
            this.warranty = warranty;
            this.instock = instock;
            this.view_count = view_count;
            this.specifications = specifications;
            this.short_desc = short_desc;
            this.descriptions = descriptions;
            this.featured = featured;
            this.best_seller = best_seller;
            this.isActive = isActive;
            this.isDelete = isDelete;
            this.meta_tittle = meta_tittle;
            this.meta_keywords = meta_keywords;
            this.meta_descriptions = meta_descriptions;
            this.create_at = create_at;
            this.update_at = update_at;
            this.delete_at = delete_at;
        }

        public int id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string slug { get; set; }
        public int brand_id { get; set; }
        public string image { get; set; }
        public string more_images { get; set; }
        public decimal unit_price { get; set; }
        public decimal promotion_price { get; set; }
        public int warranty { get; set; }
        public int? instock { get; set; }
        public int view_count { get; set; }
        public string specifications { get; set; }
        public string short_desc { get; set; }
        public string descriptions { get; set; }
        public bool featured { get; set; }
        public bool best_seller { get; set; }
        public bool isActive { get; set; }
        public bool isDelete { get; set; }
        public string meta_tittle { get; set; }
        public string meta_keywords { get; set; }
        public string meta_descriptions { get; set; }
        public DateTime create_at { get; set; }
        public DateTime? update_at { get; set; }
        public DateTime? delete_at { get; set; }
        public Brand Brand { get; set; }
        public List<ProductCategory> ProductInCategory { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public List<Rating> Ratings { get; set; }
    }
}
