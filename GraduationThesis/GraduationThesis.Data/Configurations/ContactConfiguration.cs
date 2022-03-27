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
    internal class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contact");
            builder.HasKey(x => x.id);
            builder.Property(x => x.adress).IsRequired();
            builder.Property(x => x.company_logo).IsRequired();
            builder.Property(x => x.company_name).HasMaxLength(255).IsRequired();
            builder.Property(x => x.email).IsRequired().HasMaxLength(50).IsUnicode(false);
            builder.Property(x => x.phone).IsRequired().HasMaxLength(20).IsUnicode(false);
        }
    }
}
