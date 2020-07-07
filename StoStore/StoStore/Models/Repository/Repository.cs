using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoStore.Models.Repository
{
    public class Repository
    {
        private EFDbContext context = new EFDbContext();
       
        public IEnumerable<CAR> CARS { get { return context.CARS; } }
        public IEnumerable<Cart> Carts { get { return context.Carts; } }
        public IEnumerable<Cart_Order> Cart_Orders { get { return context.Cart_Orders; } }
        public IEnumerable<CATEGORY> CATEGORYS { get { return context.CATEGORYS; } }
        public IEnumerable<CLIENT> CLIENTS { get { return context.CLIENTS; } }
        public IEnumerable<Goods> Goodss { get { return context.Goodss; } }
        public IEnumerable<Masters> Masterss { get { return context.Masterss; } }
        public IEnumerable<Masters_Services> Masters_Servicess { get { return context.Masters_Servicess; } }
        public IEnumerable<Orders> Orderss { get { return context.Orderss; } }
        public IEnumerable<Product> Products { get { return context.Products; } }
        public IEnumerable<Services> Servicess { get { return context.Servicess; } }
    }