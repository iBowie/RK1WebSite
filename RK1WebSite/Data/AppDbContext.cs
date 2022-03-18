using Microsoft.EntityFrameworkCore;
using RK1WebSite.Data.Models;

namespace RK1WebSite.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
