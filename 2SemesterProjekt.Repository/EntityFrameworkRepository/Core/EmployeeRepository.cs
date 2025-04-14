using _2SemesterProject.Domain.Interfaces.RepositoryInterfaces.Core;
using _2SemesterProject.Domain.Models.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Repository.EntityFrameworkRepository.Core
{
	public class EmployeeRepository : IEmployeeRepository
	{
		private readonly EntityFrameworkRepositoryCore _dbContext = new EntityFrameworkRepositoryCore();

		public void CreateEmployee(Employee employee)
		{
			_dbContext.Employees.Add(employee);
			_dbContext.SaveChanges();
		}

		public void DeleteEmployee(Employee employee)
		{
			_dbContext.Employees.Remove(employee);
			_dbContext.SaveChanges();
		}

		public async Task<IEnumerable<Employee>> GetAllEmployeeAsync()
		{
			return await _dbContext.Employees
				.Include(e => e.Pets)
				.ToListAsync();
		}

		public Employee GetEmployeeById(int employeeId)
		{
			return _dbContext.Employees
				.Include (e => e.Pets)
				.Where(e => e.EmployeeID == employeeId)
				.First();
		}

		public void UpdateEmployee(Employee employee)
		{
			_dbContext.Employees.Update(employee);
			_dbContext.SaveChanges();
		}
	}
}
