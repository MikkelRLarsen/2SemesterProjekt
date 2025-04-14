using _2SemesterProject.Domain.Interfaces.RepositoryInterfaces.Core;
using _2SemesterProject.Domain.Interfaces.ServiceInterfaces.Core;
using _2SemesterProject.Domain.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Services.Core
{
	public class EmployeeService : IEmployeeService
	{

		private readonly IEmployeeRepository _employeeRepository;

		public EmployeeService(IEmployeeRepository employeeRepository)
		{
			_employeeRepository = employeeRepository;
		}

		public void CreateEmployee(Employee employee)
		{
			_employeeRepository.CreateEmployee(employee);
		}

		public void DeleteEmployee(Employee employee)
		{
			_employeeRepository.DeleteEmployee(employee);
		}

		public async Task<IEnumerable<Employee>> GetAllEmployeeAsync()
		{
			return await _employeeRepository.GetAllEmployeeAsync();
		}

		public Employee GetEmployeeById(int employeeId)
		{
			return _employeeRepository.GetEmployeeById(employeeId);
		}

		public void UpdateEmployee(Employee employee)
		{
			_employeeRepository.UpdateEmployee(employee);
		}
	}
}
