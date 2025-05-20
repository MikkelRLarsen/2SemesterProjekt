using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2SemesterProjekt.Domain.Interfaces.RepositoryInterfaces;
using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProjekt.Domain.Models;

namespace _2SemesterProjekt.Services
{
	public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

		public EmployeeService(IEmployeeRepository employeeRepository)
		{
			_employeeRepository = employeeRepository;
		}

		public async Task CreateEmployeeAsync(Employee employee)
		{
			await _employeeRepository.CreateEmployeeAsync(employee);
		}

		public async Task<IEnumerable<string>> GetAllEmployeeTypesAsync()
		{
			string[] arr = { "Dyrelæge", "Assistent", "Receptionist" };
			return arr;
		}

		public async Task<IEnumerable<Employee>> GetAllEmployeeWithTypeAsync(string employeeType)
		{
			return await _employeeRepository.GetAllEmployeeWithTypeAsync(employeeType);
		}
    }
}
