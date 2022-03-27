using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraduationThesis.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraduationThesis.Data.Configurations
{
    internal class RatingConfiguration : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            builder.ToTable("Rating");
            builder.HasKey(x => new { x.product_id, x.cus_id });
            builder.Property(x => x.score).IsRequired();
            builder.Property(x => x.date_rating)
                .HasDefaultValueSql("GetDate()");
            builder.HasOne(x => x.Product).WithMany(t => t.Ratings).HasForeignKey(x => x.product_id);
            builder.HasOne(x => x.Customer).WithMany(t => t.Ratings).HasForeignKey(x => x.cus_id);
        }
    }
}
