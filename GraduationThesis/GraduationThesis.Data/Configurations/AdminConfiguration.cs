﻿using GraduationThesis.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.Data.Configurations
{
    internal class AdminConfiguration:IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.ToTable("Admin");
            builder.HasKey(x => x.id);
            builder.Property(x => x.name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.password).IsRequired().HasMaxLength(100).IsUnicode(false);
            builder.Property(x => x.email).IsRequired().HasMaxLength(50).IsUnicode(false);
            builder.Property(x => x.phone).IsRequired().HasMaxLength(20).IsUnicode(false);
            builder.Property(x => x.create_at)
              .HasDefaultValueSql("GetDate()");
            builder.Property(x => x.update_at);
        }
    }
}
