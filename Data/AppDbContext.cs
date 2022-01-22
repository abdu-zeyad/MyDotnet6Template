using Microsoft.EntityFrameworkCore;
using Template.Models;

namespace Template.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Food> Foods { get; set; }
    }
}
