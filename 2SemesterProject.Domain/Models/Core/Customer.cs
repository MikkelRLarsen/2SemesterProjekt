using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using _2SemesterProject.Domain.Models.Core.Pets;

namespace _2SemesterProject.Domain.Models.Core
{
	public class Customer
	{
		public int CustomerID { get; private set; }
		public string? CustomerName { get; private set; }

		public string? CustomerEmail { get; private set; }
		public string? CustomerAdress { get; private set; }
		public string? CustomerType { get; private set; }
		public int CustomerPhoneNumber { get; private set; }

		public List<Pet> Pets { get; }

		public Customer(int customerID, string? customerName, string? customerEmail, string? customerAdress, string? customerType, int customerPhoneNumber)
		{
			CustomerID = customerID;
			CustomerName = customerName;
			CustomerEmail = customerEmail;
			CustomerAdress = customerAdress;
			CustomerType = customerType;
			CustomerPhoneNumber = customerPhoneNumber;
		}

		public Customer() { }



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

		public void UpdateCustomer(string customerName, string customerEmail, string customerAdress, int? customerPhoneNumber)
		{
			CustomerName = customerName;
			CustomerEmail = customerEmail;
			CustomerAdress = customerAdress;
			CustomerPhoneNumber = (int)customerPhoneNumber;

			InformationValid();
		}
	}
}
