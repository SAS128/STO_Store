using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoStore.Models
{
	public class CATEGORY
	{
		public int ID { get; set; }
		public string NAME { get; set; }

		public CATEGORY(int ID_, string NAME_)
		{
			this.ID = ID_;
			this.NAME = NAME_;
		}
	}
}