using Microsoft.EntityFrameworkCore;
using MvcKBeauty.Models;

namespace MvcKBeauty.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Add DbSet properties for your entities here
        public DbSet<Product> Products { get; set; }
    }
}
