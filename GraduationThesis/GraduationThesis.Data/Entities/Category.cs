﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.Data.Entities
{
    public class Category
    {
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
