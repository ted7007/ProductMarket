using ProductMarketAPI.Models;
using Microsoft.EntityFrameworkCore;
namespace ProductMarketAPI.Repository;

public class ApplicationContext : DbContext
{
    public DbSet<Models.Product> Products { get; set; }

    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {
        Database.EnsureCreated();
    }
}