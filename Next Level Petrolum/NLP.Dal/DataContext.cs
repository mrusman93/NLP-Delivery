using Microsoft.EntityFrameworkCore;
using NLP.Domain.Models;

namespace NLP.Dal
{
    public class DataContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Brands> Brand { get; set; }
        public DbSet<ProductSizes> ProductSize { get; set; }
        public DbSet<Addresses> Address { get; set; }
        public DbSet<Stores> Store { get; set; }
        public DbSet<Products> Product { get; set; }
        //public DbSet<ProductDispensing> ProductDispensing { get; set; }
        public DbSet<Users> User { get; set; }
        public DbSet<UserRoles> UsersRole { get; set; }
        public DbSet<ProductReceivers> ProductReceiver { get; set; }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableDetailedErrors();
            optionsBuilder.EnableSensitiveDataLogging();
        }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        
    }
}
