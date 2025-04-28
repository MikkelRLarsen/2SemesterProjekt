using _2SemesterProjekt.Domain.Interfaces.RepositoryInterfaces;
using _2SemesterProjekt.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Repository.EntityFrameworkRepository
{
	public class EmployeeRepositoryEF : IEmployeeRepository
	{
		private readonly EntityFramework _db;

		public EmployeeRepositoryEF(EntityFramework db)
		{
			_db = db;
		}

		public void CreateEmployee(Employee employee)
		{
			throw new NotImplementedException();
		}

		public void DeleteEmployee(Employee employee)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<Employee>> GetAllEmployeeAsync()
		{
			return await _db.Employees.ToListAsync();
		
		}

		public Employee GetEmployeeById(int employeeId)
		{
			throw new NotImplementedException();
		}

		public void UpdateEmployee(Employee employee)
		{
			throw new NotImplementedException();
		}
	}
}
