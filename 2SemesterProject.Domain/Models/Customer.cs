using System.Diagnostics;

namespace _2SemesterProject.Domain.Models
{
	public class Customer
	{
		public int CustomerID { get; private set; }
		public string? FirstName { get; private set; }
		public string? Email { get; private set; }
		public string? Adress { get; private set; }
		public string? Type { get; private set; }
		public int PhoneNumber { get; private set; }

		public List<Pet> Pets { get; }

		public Customer(int customerID, string? customerName, string? customerEmail, string? customerAdress, string? customerType, int customerPhoneNumber)
		{
			CustomerID = customerID;
			FirstName = customerName;
			Email = customerEmail;
			Adress = customerAdress;
			Type = customerType;
			PhoneNumber = customerPhoneNumber;
		}


		/// <summary>
		/// Checks if CustomerID is greater than 0 and if CustomerName contains any numbers or speciel characters
		/// </summary>
		/// <returns>Bool</returns>
		protected bool InformationValid()
		{
			Debug.Assert(CustomerID != null, "CustomerID was null");
			Debug.Assert(FirstName != null, "CustomerName was null");

			if (CustomerID == 0) return false;
			if (FirstName.Any(ch => !char.IsLetterOrDigit(ch))) return false;
			if (FirstName.Any(ch => !char.IsDigit(ch))) return false;

			return true;

		}
	}
}
