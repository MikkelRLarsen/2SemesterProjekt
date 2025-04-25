using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProject.Domain.Models
{
	public class Examination
	{
		public int ExaminationID { get; private set; }
		public int PetID { get; private set; }
		public int EmployeeID { get; private set; }
		public DateTime Date { get; private set; }
		public string Type { get; private set; }
		public double Price { get; private set; }
		public Pet Pet { get; }
		public Employee Employee { get; }

		public Examination(int examinationID, int petID, int employeeID, DateTime date, string type, double price)
		{
			ExaminationID = examinationID;
			PetID = petID;
			EmployeeID = employeeID;
			Date = date;
			Type = type;
			Price = price;
		}
	}
}
