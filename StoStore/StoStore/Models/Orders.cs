using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoStore.Models
{
	public class Orders
	{
		public int OrderID { get; set; }
		public int IDProduct { get; set; }

		public Orders(int OrderID_, int IDProduct_)
		{
			this.OrderID = OrderID_;
			this.IDProduct = IDProduct_;
		}
	}
}