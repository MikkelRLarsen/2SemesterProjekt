using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _2SemesterProject.Domain.Models
{
	public class Customer
	{
		public int CustomerID { get; private set; }
		public string CustomerName { get; private set; }

		public List<Order> Order { get;}

		public Customer(int customerID, string customerName)
		{
			CustomerID = customerID;
			CustomerName = customerName;

			if (!InformationValid()) throw new ArgumentException("Customer Information not valid");
		}

		/// <summary>
		/// Checks if CustomerID is greater than 0 and if CustomerName contains any numbers or speciel characters
		/// </summary>
		/// <returns>Bool</returns>
		protected bool InformationValid()
		{
			Debug.Assert(CustomerID != null, "CustomerID was null");
			Debug.Assert(CustomerName != null, "CustomerName was null");

			if (CustomerID == 0) return false;
			if (CustomerName.Any(ch => !char.IsLetterOrDigit(ch))) return false;
			if (CustomerName.Any(ch => !char.IsDigit(ch))) return false;

			return true;

		}
	}
}
