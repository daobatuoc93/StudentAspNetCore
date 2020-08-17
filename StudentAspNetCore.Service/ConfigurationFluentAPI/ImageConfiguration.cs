using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentAspNetCore.Service.Entity;


namespace StudentAspNetCore.Service.ConfigurationFluentAPI
{
    //Entity Splitting
    public class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        //public ImageMap()
        //{

        //    Map(p =>
        //    {
        //        p.Properties(ph => new Student { ph.FirstName, ph.LastName });
        //        p.ToTable("Student Information");
        //    });
        //    Map(x =>
        //    {
        //        x.Properties(y => new
        //        {
        //            y.Photo,
        //            y.CurriculumVitae
        //        });
        //        x.ToTable("Student DATAAA!");
        //    });
        //}

        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.ToTable("Images");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Photo);//default == true
            builder.Property(x => x.CurriculumVitae);        
        }
    }
}
