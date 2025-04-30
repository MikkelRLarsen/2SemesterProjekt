using _2SemesterProject.Domain.Interfaces.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Domain.Models
{
	public class Pet
	{
		public int PetID { get; init; }
		public int CustomerID { get; protected set; }
		public string Name { get; protected set; }
		public string Species { get; protected set; }
		public DateTime	Birthday { get; protected set; }

		public Customer Customer { get; }
		public List<Examination> Examinations { get; }

		public Pet(int petID, int customerID, string name, string species, DateTime birthday)
		{
			PetID = petID;
			CustomerID = customerID;
			Name = name;
			Species = species;
			Birthday = birthday;
		}
        public Pet(int customerID, string name, string species, DateTime birthday)
        {
            CustomerID = customerID;
            Name = name;
            Species = species;
            Birthday = birthday;

            if (ValidateInformation() == false)
            {
                throw new ArgumentException("Invalid pet data.");
            }
        }
		public bool ValidateInformation()
		{
            if (CustomerID == 0) // Invalid if customerID is 0
            {
                return false;
            }
            else if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Species)) // Invalid if Name or Species is empty
            {
                return false;
            }
            else if (Birthday == null) // Invalid if Birthday is null
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
