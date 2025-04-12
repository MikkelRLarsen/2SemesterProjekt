using _2SemesterProject.Domain.Interfaces.RepositoryInterfaces.Core;
using _2SemesterProject.Domain.Models.Core;
using _2SemesterProject.Domain.Models.Core.Pets;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Repository.EntityFrameworkRepository.Core
{
	public class CustomerRepository : ICustomerRepository
	{
		private readonly EntityFrameworkRepositoryCore _dbContext = new EntityFrameworkRepositoryCore();

		public async Task<IEnumerable<Customer>> GetAllCustomerAsync()
		{
			return await _dbContext.Customers
			   .Include(c => c.Pets)
			   .ToListAsync();
		}
	}
}
