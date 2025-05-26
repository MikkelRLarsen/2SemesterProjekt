using System.Diagnostics;


namespace _2SemesterProjekt.Domain.Models
{
	public class Customer
	{
        public int CustomerID { get; init; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string Address { get; private set; }
        public string Type { get; private set; }
        public int PhoneNumber { get; private set; }

        public List<Pet>? Pets { get; } = new();
        public List<Order>? Orders { get; } = new();

        public Customer(string firstName, string lastName, string email, string address, string type, int phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Address = address;
            Type = type;
            PhoneNumber = phoneNumber;

            InformationValid();
        }

        /// <summary>
        /// Acceptcriteria:
        /// FirstName and LastName should only contains letters
        /// Email should contain "@" and "." and must be in a valid format.
        /// Address should only contains letters and digits.
        /// Type should be one of the allowed values ("Privat" or "Erhverv").
        /// PhoneNumber should only contain positive numbers and have a length of exactly 8 digits.
        /// <returns>Bool</returns>
        protected bool InformationValid()
        {
            // Assert that none of the fields are null.
            Debug.Assert(FirstName != null, "FirstName was null");
            Debug.Assert(LastName != null, "LastName was null");
            Debug.Assert(Email != null, "Email was null");
            Debug.Assert(Address != null, "Adress was null");
            Debug.Assert(Type != null, "Type was null");
            Debug.Assert(PhoneNumber != 0, "PhoneNumber was null");

            // Validate first and last name: only letters, single space(s), hyphens & apostrophes.
            if (string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(LastName) ||
                // Checks if names are null (no reference to an object), empty or only spaces.
                !FirstName.Replace(" ", "").Replace("-", "").Replace("'", "").All(char.IsLetter) ||
                !LastName.Replace(" ", "").Replace("-", "").Replace("'", "").All(char.IsLetter))
            //Removes all characters that are not letters, except spaces, hyphens & apostrophes.
            {
                throw new ArgumentException("Fornavn og efternavn må kun indeholde bogstaver, mellemrum og bindestreger");
            }

            // Validate email: "@" and "." in correct order.
            int atIndex = Email.IndexOf('@');
            int dotIndex = Email.LastIndexOf('.');
            if (string.IsNullOrWhiteSpace(Email) || atIndex <= 0 || dotIndex <= atIndex + 1 || dotIndex == Email.Length - 1)
            {
                throw new ArgumentException("Fejl i @ og/eller .");
            }

            // Validate address: only letters and digits.
            if (string.IsNullOrWhiteSpace(Address) || Address.All(char.IsLetterOrDigit))
            {
                throw new ArgumentException("Adresse må kun indeholde bogstaver og tal");
            }

            // Validate type: either "Privat" or "Erhverv".
            if (string.IsNullOrWhiteSpace(Type) || (Type != "Privat" && Type != "Erhverv"))
            {
                throw new ArgumentException("Kundetype skal enten være 'Privat' eller 'Erhverv'");
            }

            // Validate phonenumber: 8-digit long.
            if (PhoneNumber < 10000000 || PhoneNumber > 99999999)
            {
                throw new ArgumentException("Telefonnummer skal være 8 tal");
            }

            return true;
        }
        public void UpdateCustomerProperties(Customer customer)
        {
            customer.InformationValid();

            FirstName = customer.FirstName;
            LastName = customer.LastName;
            Email = customer.Email;
            PhoneNumber = customer.PhoneNumber;
            Address = customer.Address;
            Type = customer.Type;
        }
    }
}
