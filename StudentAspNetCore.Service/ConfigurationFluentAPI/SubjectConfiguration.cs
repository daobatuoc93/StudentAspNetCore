using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentAspNetCore.Service.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAspNetCore.Service.ConfigurationFluentAPI
{
    public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.ToTable("Subjects");
            builder.HasKey(x => x.Id).HasName("SubjectsID");
            builder.Property(x => x.NameSubject).IsRequired().HasMaxLength(30);//default == true 
            builder.HasOne<StudentSubject>(a => a.StudentSubject).WithOne(wo => wo.Subject).HasForeignKey<StudentSubject>(fk => fk.SubjectId);

        }
    }
}
