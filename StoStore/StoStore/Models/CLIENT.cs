using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoStore.Models
{
	public class CLIENT
	{
		public int CLIENT_ID { get; set; }
		public string FNAME { get; set; }
		public string LNAME { get; set; }
		public string PHONE { get; set; }
		public string ADRESS { get; set; }
		public string STATUS { get; set; }
		public decimal CASH { get; set; }

		public CLIENT(int CLIENT_ID_, string FNAME_, string LNAME_, string PHONE_, string ADRESS_, string STATUS_, decimal CASH_)
		{
			this.CLIENT_ID = CLIENT_ID_;
			this.FNAME = FNAME_;
			this.LNAME = LNAME_;
			this.PHONE = PHONE_;
			this.ADRESS = ADRESS_;
			this.STATUS = STATUS_;
			this.CASH = CASH_;
		}
	}
}