using _2SemesterProjekt.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Domain.Interfaces.RepositoryInterfaces
{
	public interface IEmployeeRepository
	{
		public Task<IEnumerable<Employee>> GetAllEmployeeAsync();
		public Employee GetEmployeeById(int employeeId);
		public void UpdateEmployee(Employee employee);
		public void DeleteEmployee(Employee employee);
		public void CreateEmployee(Employee employee);
	}
}
