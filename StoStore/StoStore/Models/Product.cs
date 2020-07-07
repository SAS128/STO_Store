using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoStore.Models
{
	public class Product
	{
		public int ProductID { get; set; }
		public string ProductDescription { get; set; }
		public decimal ProductPrice { get; set; }
		public int CategoryID { get; set; }
		public int CarID { get; set; }
		public int GoodsID { get; set; }

		public Product(int ProductID_, string ProductDescription_, decimal ProductPrice_, int CategoryID_, int CarID_, int GoodsID_)
		{
			this.ProductID = ProductID_;
			this.ProductDescription = ProductDescription_;
			this.ProductPrice = ProductPrice_;
			this.CategoryID = CategoryID_;
			this.CarID = CarID_;
			this.GoodsID = GoodsID_;
		}
	}
}