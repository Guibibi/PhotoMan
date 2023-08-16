using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PhotoMan.Models;

namespace PhotoMan.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Collection> Collections { get; set; }
        public DbSet<CollectionPurchase> CollectionPurchases { get; set; }
        public DbSet<Photo> Photos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CollectionPurchase>()
                .HasOne(cp => cp.Client)
                .WithMany(u => u.Purchases)
                .HasForeignKey(cp => cp.ClientId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CollectionPurchase>()
                .HasOne(cp => cp.Collection)
                .WithMany(c => c.CollectionPurchases)
                .HasForeignKey(cp => cp.CollectionId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}