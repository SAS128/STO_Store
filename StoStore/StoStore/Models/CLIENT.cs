using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoStore.Models
{
	public class Client
	{
		public int ClientId { get; set; }
		public string Fio { get; set; }
		public string Phone { get; set; }
		public string Adress { get; set; }
		public bool Status { get; set; }
		public int Cart_Id { get; set; }

		public Client(int ClientId_, string Fio_, string Phone_, string Adress_, bool Status_, int Cart_Id_)
		{
			this.ClientId = ClientId_;
			this.Fio = Fio_;
			this.Phone = Phone_;
			this.Adress = Adress_;
			this.Status = Status_;
			this.Cart_Id = Cart_Id_;
		}
		public virtual IEnumerable<Cart> Cart { get; set; }
	}
}