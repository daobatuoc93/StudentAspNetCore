using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentAspNetCore.Service.Entity;

namespace StudentAspNetCore.Service.ConfigurationFluentAPI
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Addresss");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.City).HasMaxLength(30);//default == true
            builder.Property(x => x.State);//default == true
            builder.Property(em => em.Email).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Zip).HasMaxLength(10);//default == true
            builder.Property(x => x.Street);//default == true
            //Noted that we need to change 1-1
 //           builder.HasOne<Student>(s => s.Student).WithOne(y=>y.Address).HasForeignKey<Address>(z => z.StudentId);
        }
    }
}
