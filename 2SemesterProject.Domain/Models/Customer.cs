using System.Diagnostics;

namespace _2SemesterProject.Domain.Models
{
	public class Customer
	{
		public int CustomerID { get; private set; }
		public string? FirstName { get; private set; }
		public string? LastName { get; private set; }
		public string? Email { get; private set; }
		public string? Adress { get; private set; }
		public string? Type { get; private set; }
		public int PhoneNumber { get; private set; }

		public List<Pet> Pets { get; }

		public Customer(int customerID, string? firstName, string? lastName, string? email, string? adress, string? type, int phoneNumber)
		{
			CustomerID = customerID;
			FirstName = firstName;
			LastName = lastName;
			Email = email;
			Adress = adress;
			Type = type;
			PhoneNumber = phoneNumber;
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
