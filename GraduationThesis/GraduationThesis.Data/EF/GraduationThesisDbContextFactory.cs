using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.Data.EF
{
    internal class GraduationThesisDbContextFactory: IDesignTimeDbContextFactory<GraduationThesisDbContext>
    {
        public GraduationThesisDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting.json")
                .Build();

            var connectionString = configuration.GetConnectionString("GraduationThesisDB");

            var optionsBuilder = new DbContextOptionsBuilder<GraduationThesisDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new GraduationThesisDbContext(optionsBuilder.Options);
        }
    }
}
