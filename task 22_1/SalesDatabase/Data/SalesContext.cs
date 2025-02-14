using Microsoft.EntityFrameworkCore;
using P02_SalesDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace P02_SalesDatabase.Data
{
    internal class SalesContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Sale> Sales { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=localhost ; Initial Catalog=SalesDatabase ; Integrated Security = True ; TrustServerCertificate = True ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().Property(e=>e.Name).HasColumnType("varchar(50)").IsUnicode(true);
            modelBuilder.Entity<Customer>().Property(e => e.Name).HasColumnType("varchar(100)").IsUnicode(true);
            modelBuilder.Entity<Customer>().Property(e => e.Email).HasColumnType("varchar(80)").IsUnicode(false);
            modelBuilder.Entity<Store>().Property(e => e.Name).HasColumnType("varchar(80)").IsUnicode(true);
            modelBuilder.Entity<Product>().Property(e => e.Description).HasColumnType("varchar(250)").HasDefaultValue("No description");
            modelBuilder.Entity<Sale>().Property(e => e.Date).HasDefaultValueSql("GETDATE()");
        }
    }
}
