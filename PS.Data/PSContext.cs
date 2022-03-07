using Microsoft.EntityFrameworkCore;
using PS.Data.myConfiguration;
using PS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Data
{
    public class PSContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Biological> Biologicals { get; set; }
        public DbSet<Chemical> Chemicals { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Provider> Providers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
                                        Initial Catalog=ProductStoreDB;
                                        Integrated Security=true;
                                        MultipleActiveResultSets=True");
            base.OnConfiguring(optionsBuilder);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());

            //  configuring inheritance table per type (tpt)
            // (soit nekhdmou b hethy soit nekhdmou beli fl Product Configuration )
            modelBuilder.Entity<Chemical>().ToTable("chemicals");
            modelBuilder.Entity<Biological>().ToTable("biologicals");

            base.OnModelCreating(modelBuilder);
        }
    }
}
