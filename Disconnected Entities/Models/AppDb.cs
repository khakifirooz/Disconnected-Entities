using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Disconnected_Entities.Models;

public class AppDb : DbContext
{
    public DbSet<Person> Persons { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configBulder = new ConfigurationBuilder();
        var configuration = configBulder.AddJsonFile("appsettings.json").Build();
        var configSection = configuration.GetSection("ConnectionStrings");
        var connectionString = configSection["DBConnection"];
        optionsBuilder.UseSqlServer(connectionString);
    }
}
