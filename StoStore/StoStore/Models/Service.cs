using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoStore.Models
{
	public class Service
	{
		public int ServiceId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int CategoryId { get; set; }
		public int MasterId { get; set; }
		public int CarId { get; set; }

		public Service(int ServiceId_, string Name_, string Description_, int CategoryId_, int MasterId_, int CarId_)
		{
			this.ServiceId = ServiceId_;
			this.Name = Name_;
			this.Description = Description_;
			this.CategoryId = CategoryId_;
			this.MasterId = MasterId_;
			this.CarId = CarId_;
		}
	}
}