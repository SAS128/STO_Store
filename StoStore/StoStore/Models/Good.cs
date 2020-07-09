using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoStore.Models
{
	public class Good
	{
		public int GoodId { get; set; }
		public string Name { get; set; }

		public Good(int GoodId_, string Name_)
		{
			this.GoodId = GoodId_;
			this.Name = Name_;
		}
	}
}