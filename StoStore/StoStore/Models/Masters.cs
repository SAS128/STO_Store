using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoStore.Models
{
	public class Masters
	{
		public int MasterID { get; set; }
		public string NAME { get; set; }

		public Masters(int MasterID_, string NAME_)
		{
			this.MasterID = MasterID_;
			this.NAME = NAME_;
		}
	}
}