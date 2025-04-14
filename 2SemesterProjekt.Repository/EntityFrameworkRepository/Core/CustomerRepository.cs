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

		public void CreateCustomer(Customer customer)
		{
			_dbContext.Customers.Add(customer);
			_dbContext.SaveChanges();
		}

		public void DeleteCustomer(Customer customer)
		{
			_dbContext.Customers.Remove(customer);
			_dbContext.SaveChanges();
		}

		public async Task<IEnumerable<Customer>> GetAllCustomersAsync()
		{
			return await _dbContext.Customers
			   .Include(c => c.Pets)
			   .ToListAsync();
		}

		public Customer GetCustomerById(int customerID)
		{
			return _dbContext.Customers
				.Where(c => c.CustomerID == customerID)
				.First();
		}

		public void UpdateCustomer(Customer customer)
		{
			_dbContext.Customers.Update(customer);
			_dbContext.SaveChanges();
		}
	}
}
