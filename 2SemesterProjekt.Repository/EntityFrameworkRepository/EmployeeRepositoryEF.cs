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

		public async Task<IEnumerable<Employee>> GetAllEmployeeWithTypeAsync(string employeeType)
		{
			return await _db.Employees
				.Where(e => e.Type == employeeType)
				.ToListAsync();
		}
	}
}
