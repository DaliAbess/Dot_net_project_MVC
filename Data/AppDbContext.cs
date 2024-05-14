using Dot_Net_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Dot_Net_Project.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

protected override void OnModelCreating(ModelBuilder builder)
             {
            base.OnModelCreating(builder);
        }

        public DbSet<Category> Category { get; set; }
        //public DbSet<Item> Items { get; set; }
    }
}