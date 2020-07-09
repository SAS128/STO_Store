using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoStore.Models.Repository
{
    public class Repository
    {



        private EFDbContext context = new EFDbContext();

        public IEnumerable<Car> Car { get { return context.Car; } }
        public IEnumerable<Cart> Cart { get { return context.Cart; } }
        public IEnumerable<Category> Category { get { return context.Category; } }
        public IEnumerable<Client> Client { get { return context.Client; } }
        public IEnumerable<Good> Good { get { return context.Good; } }
        public IEnumerable<Master> Master { get { return context.Master; } }
        public IEnumerable<Order> Order { get { return context.Order; } }
        public IEnumerable<Service> Service { get { return context.Service; } }

    }
}