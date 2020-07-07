using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoStore.Models
{
	public class Goods
	{
		public int GoodsID { get; set; }
		public string Name { get; set; }
		public int Quantity { get; set; }
		public decimal Price { get; set; }

		public Goods(int GoodsID_, string Name_, int Quantity_, decimal Price_)
		{
			this.GoodsID = GoodsID_;
			this.Name = Name_;
			this.Quantity = Quantity_;
			this.Price = Price_;
		}
	}
}