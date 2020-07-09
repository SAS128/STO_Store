using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoStore.Models
{
	public class Cart
	{
		public int CartId { get; set; }
		public string SessionKey { get; set; }
		public decimal Price { get; set; }
		public int Service_ServiceId { get; set; }

		public Cart(int CartId_, string SessionKey_, decimal Price_, int Service_ServiceId_)
		{
			this.CartId = CartId_;
			this.SessionKey = SessionKey_;
			this.Price = Price_;
			this.Service_ServiceId = Service_ServiceId_;
		}
		public virtual IEnumerable<Service> Service { get; set; }
	}
}