using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProject.Domain.Models
{
	public class Pet
	{
		public int PetID { get; protected set; }
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
	}
}
