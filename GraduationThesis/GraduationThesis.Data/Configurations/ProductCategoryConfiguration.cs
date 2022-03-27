using GraduationThesis.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.Data.Configurations
{
    internal class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.ToTable("ProductCategory");

            builder.HasKey(t => new { t.cate_id, t.product_id });

            builder.HasOne(t => t.Category).WithMany(c => c.ProductInCategory).HasForeignKey(c => c.cate_id);
            builder.HasOne(t => t.Product).WithMany(c => c.ProductInCategory).HasForeignKey(c => c.product_id);
        }
    }
}
