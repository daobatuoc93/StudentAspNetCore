using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentAspNetCore.Service.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAspNetCore.Service.ConfigurationFluentAPI
{
    public class SchoolConfiguration : IEntityTypeConfiguration<School>
    {
        public void Configure(EntityTypeBuilder<School> builder)
        {
            builder.ToTable("Schools");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.NameSchool).IsRequired().HasMaxLength(100);//default == true
            builder.HasMany<Student>(s => s.Students).WithOne(x => x.School).HasForeignKey(x => x.SchoolId);
//            builder.HasMany<Image>(i => i.Images).WithOne(x => x.School).HasForeignKey(x => x.SchoolId);
//            builder.HasOne<Address>(a => a.Address).WithOne(wo => wo.School).HasForeignKey<Address>(fk => fk.SchoolId);
//            builder.HasOne<Contact>(c => c.Contact).WithOne(wo => wo.School).HasForeignKey<Contact>(fk => fk.SchoolId);
        }
    }
}
