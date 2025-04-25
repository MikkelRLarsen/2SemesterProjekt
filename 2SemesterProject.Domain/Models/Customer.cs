using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace _2SemesterProject.Domain.Models
{
	public class Customer
	{
		public int CustomerID { get; init; }
		public string? FirstName { get; private set; }
		public string? LastName { get; private set; }
		public string? Email { get; private set; }
		public string? Adress { get; private set; }
		public string? Type { get; private set; }
		public int PhoneNumber { get; private set; }

		public List<Pet>? Pets { get; } = new();

		public Customer(string? firstName, string? lastName, string? email, string? adress, string? type, int phoneNumber)
		{
			FirstName = firstName;
			LastName = lastName;
			Email = email;
			Adress = adress;
			Type = type;
			PhoneNumber = phoneNumber;

			if (InformationValid() == false)
			{
				throw new ArgumentException("Pre-conditions not met: invalid customer data.");
			}
		}

		/// <summary>
		/// Acceptcriteria:
		/// CustomerID is greater than 0,
		/// FirstName and LastName only contains letters
		/// Email contains @ and .
		/// Adress only contains letters and digits
		/// Type only contains letters
		/// </summary>
		/// <returns>Bool</returns>
		protected bool InformationValid()
		{
			Debug.Assert(FirstName != null, "FirstName was null");
			Debug.Assert(LastName != null, "LastName was null");
			Debug.Assert(Email != null, "Email was null");
			Debug.Assert(Adress != null, "Adress was null");
			Debug.Assert(Type != null, "Type was null");
			Debug.Assert(PhoneNumber != 0, "PhoneNumber was null");

			if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName) ||
				!FirstName.All(char.IsLetter) || !LastName.All(char.IsLetter))
			{
				return false;
			}

			if (string.IsNullOrEmpty(Email) || !Email.Contains('@') || !Email.Contains('.'))
			{
				return false;
			}

			if (string.IsNullOrEmpty(Adress) || Adress.All(char.IsLetterOrDigit))
			{
				return false;
			}

			if (string.IsNullOrEmpty(Type) || !Type.All(char.IsLetter))
			{
				return false;
			}

			if (PhoneNumber < 10000000 || PhoneNumber > 99999999)
			{
				return false;
			}

			return true;
		}
	}
}
