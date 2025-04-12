using _2SemesterProject.Domain.Models.Core.Pets;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProject.Domain.Models.Core
{
	public class Employee
	{
		public int EmployeeID { get; private set; }
		public string? EmployeeName { get; private set; }
		public List<Pet>? Pets { get; }

		public Employee(int employeeID, string employeeName)
		{
			EmployeeID = employeeID;
			EmployeeName = employeeName;


			if (!InformationValid()) throw new ArgumentException("Employee Information not valid");
		}

		protected bool InformationValid()
		{
			Debug.Assert(EmployeeID != null, "CustomerID was null");
			Debug.Assert(EmployeeName != null, "CustomerName was null");

			if (EmployeeID == 0) return false;
			if (EmployeeName.Any(ch => !char.IsLetterOrDigit(ch))) return false;
			if (EmployeeName.Any(ch => !char.IsDigit(ch))) return false;

			return true;
		}
	}
}
