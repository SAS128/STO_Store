using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoStore.Models
{
	public class Cart_Order
	{
		public int IDOrder { get; set; }
		public int IDCart { get; set; }

		public Cart_Order(int IDOrder_, int IDCart_)
		{
			this.IDOrder = IDOrder_;
			this.IDCart = IDCart_;
		}
	}
}