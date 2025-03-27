using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProject.Domain.Models
{
	internal class Order
	{
		public int OrderID { get; private set; }
		public int CustomerID { get; private set; }
		public Customer Customer { get;}

		public Order(int orderID, int customerID)
		{
			OrderID = orderID;
			CustomerID = customerID;
		}

		/// <summary>
		/// Checks if OrderID or CustomerID is greater than 0
		/// </summary>
		/// <returns>Bool</returns>
		protected bool InformationValid()
		{
			Debug.Assert(OrderID != null, "OrderID was null");
			Debug.Assert(CustomerID != null, "CustomerID was null");

			if (CustomerID == 0) return false;
			if (OrderID == 0) return false;

			return true;
		}
	}
}
