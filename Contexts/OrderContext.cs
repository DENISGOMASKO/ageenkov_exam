using System;
using System.Collections.Generic;
using System.Text;
using ExamWPF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace ExamWPF.Contexts
{
    class OrderContext : DbContext
    {
        public DbSet<Order> store_order { get; set; }
        public DbSet<Product> product { get; set; }
        public DbSet<ProductsInOrder> products_in_order { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<Order>().HasMany(o => o.products).WithOne(p => p.order);
            modelBuilder.Entity<Product>().HasMany(p => p.orders).WithOne(o => o.product);*/

        }

        private static string _connectionString;

        public OrderContext(string connectionString)
        {
            _connectionString = connectionString;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
