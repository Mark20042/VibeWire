using Microsoft.EntityFrameworkCore;
using Tambayan.Data.Models;

namespace Tambayan.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<Post> Posts { get; set; } = null!;


    }
}
