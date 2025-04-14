using _2SemesterProject.Domain.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProject.Domain.Interfaces.ServiceInterfaces.Core
{
	public interface IEmployeeService
	{
		public Task<IEnumerable<Employee>> GetAllEmployeeAsync();
		public Employee GetEmployeeById(int employeeId);

		public void UpdateEmployee(Employee employee);
		public void DeleteEmployee(Employee employee);
		public void CreateEmployee(Employee employee);
	}
}
