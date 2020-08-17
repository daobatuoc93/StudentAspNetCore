using Microsoft.EntityFrameworkCore;
using StudentAspNetCore.Service.ConfigurationFluentAPI;
using StudentAspNetCore.Service.Entity;
using StudentAspNetCore.Service.StudentDataSeeding;

namespace StudentAspNetCore.Service.EntityFrameworkDB
{
    public class StudentAspNetCoreDbContext : DbContext
    {
        public StudentAspNetCoreDbContext(DbContextOptions options) : base(options)
        {

        }
        //configurate Buddy class has configured in ConfigurationFluentApi
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AccountConfiguration());
            modelBuilder.ApplyConfiguration(new AddressConfiguration());
            modelBuilder.ApplyConfiguration(new ImageConfiguration());
            modelBuilder.ApplyConfiguration(new SchoolConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new SubjectConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new StudentSubjectConfiguration());
            modelBuilder.Seed();
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<School> Schools { get; set; }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Image> Images { get; set; }
        public DbSet<StudentSubject> StudentSubjects { get; set; }

    }
}
