using Microsoft.EntityFrameworkCore;
using NLP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLP.Dal
{
    public class DataContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Brands> Brand { get; set; }
        public DbSet<ProductSizes> ProductSize { get; set; }
        public DbSet<Addresses> Address { get; set; }
        public DbSet<Stores> Store { get; set; }
        public DbSet<Products> Product { get; set; }
        public DbSet<ProductReceivers> ProductReceiver { get; set; }

    }
}
