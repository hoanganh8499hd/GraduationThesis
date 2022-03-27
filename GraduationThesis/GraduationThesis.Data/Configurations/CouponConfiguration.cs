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
    internal class CouponConfiguration : IEntityTypeConfiguration<Coupon>
    {
        public void Configure(EntityTypeBuilder<Coupon> builder)
        {
            builder.ToTable("Coupon");
            builder.HasKey(x => x.id);
            builder.Property(x => x.code).IsRequired().IsUnicode(false);
            builder.Property(x => x.name).IsRequired().HasMaxLength(255);
            builder.Property(x => x.isActive).IsRequired();
            builder.Property(x => x.type).IsRequired().HasMaxLength(50);
            builder.Property(x => x.value).IsRequired();
            builder.Property(x => x.start_at)
                .HasColumnType("Date");
            builder.Property(x => x.end_at)
                .HasColumnType("Date");
        }
    }
}
