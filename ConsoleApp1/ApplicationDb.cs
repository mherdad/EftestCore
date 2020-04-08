using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ConsoleApp1
{
    public class ApplicationDb :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLoggerFactory(LoggerFactory.Create(builder => 
                    builder.AddConsole()))
                .EnableSensitiveDataLogging()
                .UseSqlServer(
                    @"Server=(localdb)\MSSQLLocalDB;Database=EfCoredb;Integrated security = true;Trusted_Connection=True;ConnectRetryCount=0");
            base.OnConfiguring(optionsBuilder);
        }
    }
}