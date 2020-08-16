using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StudentAspNetCore.Service.EntityFrameworkDB
{
    public class StudentAspNetCoreDbContextFactory : IDesignTimeDbContextFactory<StudentAspNetCoreDbContext>
    {
        public StudentAspNetCoreDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<StudentAspNetCoreDbContext>();
            var connectionString = configuration.GetConnectionString("StudentAspNetCoreDB");
            builder.UseSqlServer(connectionString);
            return new StudentAspNetCoreDbContext(builder.Options);
        }
    }
}
