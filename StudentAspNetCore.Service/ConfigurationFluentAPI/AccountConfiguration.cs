using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentAspNetCore.Service.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAspNetCore.Service.ConfigurationFluentAPI
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Accounts");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Password).IsRequired().HasMaxLength(30);//default == true
            builder.Property(x => x.UserName).IsRequired().HasMaxLength(30);//default == true

            //builder.HasOne<Student>(x => x.Student).WithOne(y => y.Account).HasForeignKey<Account>(z => z.StudentId);
        }
    }
}
