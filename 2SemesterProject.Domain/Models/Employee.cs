using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProject.Domain.Models
{
	public class Employee
	{
		public int EmployeeID { get; private set; }
		public string? FirstName { get; private set; }
		public string? LastName { get; private set; }
		public string Type { get; private set; }
		public List<Examination> Examinations {get;}

		public Employee(int employeeID, string? firstName, string? lastName, string type)
		{
			EmployeeID = employeeID;
			FirstName = firstName;
			LastName = lastName;
			Type = type;

			if (!InformationValid()) throw new ArgumentException("Employee Information not valid");
		}

		protected bool InformationValid()
		{
			Debug.Assert(EmployeeID != null, "EmployeeID was null");
			Debug.Assert(FirstName != null, "EmployeeName was null");

			if (EmployeeID == 0) return false;
			if (FirstName.Any(ch => !char.IsLetterOrDigit(ch))) return false;
			//if (FirstName.Any(ch => !char.IsDigit(ch))) return false;

			return true;
		}
	}
}
