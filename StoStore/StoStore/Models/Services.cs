using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoStore.Models
{
	public class Services
	{
		public int Id { get; set; }
		public int ProductId { get; set; }

		public Services(int Id_, int ProductId_)
		{
			this.Id = Id_;
			this.ProductId = ProductId_;
		}
	}
}