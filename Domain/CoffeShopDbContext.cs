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

        public CoffeShopDbContext(DbContextOptions<CoffeShopDbContext> options)
            : base(options) { }

        public DbSet<MenuItem> Menu { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<CustomerOrderList> CustomerOrderList{ get; set; }
    }
}
