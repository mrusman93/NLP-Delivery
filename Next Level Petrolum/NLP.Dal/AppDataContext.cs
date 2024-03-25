using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NLP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLP.Dal
{
    public class AppDataContext : IdentityDbContext
    {
        public AppDataContext(DbContextOptions options) : base (options)
        {

        }
    }
}
/*
public class AppDataContext(DbContextOptions<Users> options) : Base(options)
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

}
*/