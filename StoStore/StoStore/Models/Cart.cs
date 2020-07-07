using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoStore.Models
{
	public class Cart
	{
		public int Id { get; set; }
		public int OrderId { get; set; }

		public Cart(int Id_, int OrderId_)
		{
			this.Id = Id_;
			this.OrderId = OrderId_;
		}
	}
}