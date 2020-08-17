
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentAspNetCore.Service.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAspNetCore.Service.ConfigurationFluentAPI
{
    class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(30);//default == true
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(30);//default == true
            builder.HasMany<Image>(x => x.Images).WithOne(st => st.Student).HasForeignKey(st => st.StudentId);
            builder.HasMany<Subject>(s => s.Subjects).WithOne(wost => wost.Student).HasForeignKey(wost => wost.StudentId);
            builder.HasOne<Address>(a => a.Address).WithOne(wo => wo.Student).HasForeignKey<Address>(fk => fk.StudentId);
            builder.HasOne<Account>(a => a.Account).WithOne(wo => wo.Student).HasForeignKey<Account>(fk => fk.StudentId);
            builder.HasOne<Contact>(a => a.Contact).WithOne(wo => wo.Student).HasForeignKey<Contact>(fk => fk.StudentId);
        }
    }
}
