using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StoStore.Models.Repository
{
    public class EFDbContext : DbContext
    {
        public DbSet<CAR> CARS { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Cart_Order> Cart_Orders { get; set; }
        public DbSet<CATEGORY> CATEGORYS { get; set; }
        public DbSet<CLIENT> CLIENTS { get; set; }
        public DbSet<Goods> Goodss { get; set; }
        public DbSet<Masters> Masterss { get; set; }
        public DbSet<Masters_Services> Masters_Servicess { get; set; }
        public DbSet<Orders> Orderss { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Services> Servicess { get; set; }
    }
}