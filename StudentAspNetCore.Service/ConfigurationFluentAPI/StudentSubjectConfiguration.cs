using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentAspNetCore.Service.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAspNetCore.Service.ConfigurationFluentAPI
{
    
    public class StudentSubjectConfiguration : IEntityTypeConfiguration<StudentSubject>
    {
        public void Configure(EntityTypeBuilder<StudentSubject> builder)
        {
            builder.ToTable("StudentSubject");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Score).HasMaxLength(3);//default == true 
            builder.Property(x => x.DateExam);//default == true
            builder.Property(x => x.Result);//default == true 
        }
    }
}
