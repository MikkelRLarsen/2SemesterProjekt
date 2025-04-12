using _2SemesterProject.Domain.Models.ExaminationSection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProject.Domain.Models.Core.Pets
{
	public class Pet
	{
		public int PetID { get; protected set; }
		public int CustomerID { get; protected set; }
		public int EmployeeID { get; protected set; }
		public string PetName { get; protected set; }
		public string PetSpecies { get; protected set; }

		public Customer Customer { get; }
		public Employee Employee { get; }
		public List<Examination> Examinations { get; }

		protected Pet(int petID, int customerID, int employeeID, string petName, string petSpecies)
		{
			PetID = petID;
			CustomerID = customerID;
			EmployeeID = employeeID;
			PetName = petName;
			PetSpecies = petSpecies;
		}
	}
}
