using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentAspNetCore.Service.Entity;


namespace StudentAspNetCore.Service.ConfigurationFluentAPI
{
   
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contacts");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Url);//default == true
            builder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(10);//default == true
            //Noted that we need to change 1-1
            //builder.HasOne(s => s.Student).WithOne(x => x.Contact);
            //builder.HasOne<Student>(x => x.Student).WithOne(y => y.Contact).HasForeignKey<Contact>(z => z.StudentId);
        }
    }
}
