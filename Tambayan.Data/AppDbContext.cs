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

        public DbSet<User> Users  {  get; set; } = null!;

        public DbSet<PostImage> PostImages { get; set; } = null!;


        // Configure the model relationships and constraints
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // User to Post (One-to-Many)
            modelBuilder.Entity<Post>()
                .HasOne(p => p.User)
                .WithMany(u => u.Posts)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Cascade);


            // Post to PostImage (One-to-Many)
            modelBuilder.Entity<PostImage>()
                .HasOne(pi => pi.Post)
                .WithMany(p => p.Images)
                .HasForeignKey(pi => pi.PostId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
