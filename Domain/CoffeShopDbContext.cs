using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Domain
{
    public class CoffeShopDbContext : DbContext
    {
        // protected readonly IConfiguration Configuration;
        public CoffeShopDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                "Server=localhost;Database=coffeeshopdb;Port=5432;User Id=postgres;Password=postgres"
            );
        }
        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<Order>()
        //         .HasMany(o => o.Items)
        //         .WithOne()
        //         .HasForeignKey(oi => oi.Item);
        // }


        public CoffeShopDbContext(DbContextOptions<CoffeShopDbContext> options)
            : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasMany(o => o.Items)
                .WithOne(oi => oi.Order)
                .HasForeignKey(oi => oi.ItemId)
                .IsRequired();
            modelBuilder.Entity<OrderItem>()
                .HasOne(or => or.Item)
                .WithMany(e => e.OrderItem)
                .HasForeignKey(or => or.ItemId)
                .HasPrincipalKey(e => e.Id);

        }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Customer> customer { get; set; }

    }
}
