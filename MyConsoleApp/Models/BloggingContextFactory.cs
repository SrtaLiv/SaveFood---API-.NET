using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace MyConsoleApp.Models
{
    public class BloggingContextFactory : IDesignTimeDbContextFactory<BloggingContext>
    {
        public BloggingContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BloggingContext>();

            var connectionString = "server=localhost;user=root;database=ef";
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 29));

            optionsBuilder.UseMySql(connectionString, serverVersion);

            return new BloggingContext(optionsBuilder.Options);
        }
    }
}
