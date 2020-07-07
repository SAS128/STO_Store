using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoStore.Models
{
	public class Masters_Services
	{
		public int IDMaster { get; set; }
		public int IDService { get; set; }

		public Masters_Services(int IDMaster_, int IDService_)
		{
			this.IDMaster = IDMaster_;
			this.IDService = IDService_;
		}
	}
}