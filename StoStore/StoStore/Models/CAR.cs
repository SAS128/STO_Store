using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoStore.Models
{
	public class CAR
	{
		public int CAR_ID { get; set; }
		public string CARNAME { get; set; }
		public string CARTYPE { get; set; }
		public string CARCOLOR { get; set; }
		public int CLIENT_ID { get; set; }

		public CAR(int CAR_ID_, string CARNAME_, string CARTYPE_, string CARCOLOR_, int CLIENT_ID_)
		{
			this.CAR_ID = CAR_ID_;
			this.CARNAME = CARNAME_;
			this.CARTYPE = CARTYPE_;
			this.CARCOLOR = CARCOLOR_;
			this.CLIENT_ID = CLIENT_ID_;
		}
	}
}