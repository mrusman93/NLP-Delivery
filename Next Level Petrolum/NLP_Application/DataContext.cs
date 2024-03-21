using Infrastructure_NLP.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NLP_Application
{
    public class DataContext : IdentityDbContext<IdentityUser<int>, IdentityRole<int>, int>
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options) { }
        public DbSet<UserHistory> UsersHistory { get; set; }
        public DbSet<UserRoles> Role { get; set; }
        public DbSet<Users> User { get; set; }

        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UniformDispensing>()
                .HasOne(u => u.Store)
                .WithMany()
                .HasForeignKey(u => u.StoreID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<UniformDispensing>()
                .HasOne(u => u.User)
                .WithMany()
                .HasForeignKey(u => u.UserID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<UniformDispensing>()
                .HasOne(u => u.Receiver)
                .WithMany()
                .HasForeignKey(u => u.ReceiverID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<UniformDispensing>()
                .HasOne(u => u.Product)
                .WithMany()
                .HasForeignKey(u => u.ProductID)
                .OnDelete(DeleteBehavior.Restrict);
        }
        */
    }
}
