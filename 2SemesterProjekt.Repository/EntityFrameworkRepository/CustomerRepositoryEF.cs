using _2SemesterProject.Domain.Interfaces.RepositoryInterfaces;
using _2SemesterProject.Domain.Models;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Repository.EntityFrameworkRepository
{
	public class CustomerRepositoryEF : ICustomerRepository
	{
		private readonly EntityFramework _db;

		public CustomerRepositoryEF(EntityFramework db)
		{
			_db = db;
		}

		public bool CreateCustomer(Customer customer)
		{
			// Check if the customer is already in DB
			var existingCustomer = _db.Customers
				.FirstOrDefault(c => c.FirstName == customer.FirstName && c.LastName == customer.LastName);

			if (existingCustomer == null) // Add to DB
			{
				_db.Customers.Add(customer);
				_db.SaveChanges();
				return true;
			}
			else // If hit return and dont add it to DB
			{
				return false;
			}
		}

		public void DeleteCustomer(Customer customer)
		{
			throw new NotImplementedException();
		}

		public async Task<Customer> GetAllCustomerAsync()
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<Customer>> GetAllCustomersAsync()
		{
			throw new NotImplementedException();
		}

		public Customer GetCustomerById(int customerID)
		{
			throw new NotImplementedException();
		}

		public void UpdateCustomer(Customer customer)
		{
			throw new NotImplementedException();
		}
	}
}
