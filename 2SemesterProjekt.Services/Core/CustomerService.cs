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
	public class CustomerService : ICustomerService
	{
		private readonly ICustomerRepository _customerRepo;

		public CustomerService(ICustomerRepository customerRepo)
		{
			_customerRepo = customerRepo;
		}

		public void CreateCustomer(Customer customer)
		{
			_customerRepo.CreateCustomer(customer);
		}

		public void DeleteCustomer(Customer customer)
		{
			_customerRepo.DeleteCustomer(customer);
		}

		public async Task<IEnumerable<Customer>> GetAllCustomersAsync()
		{
			return await _customerRepo.GetAllCustomersAsync();
		}

		public Customer GetCustomerById(int customerID)
		{
			return _customerRepo.GetCustomerById(customerID);
		}

		public void UpdateCustomer(Customer customer)
		{
			_customerRepo.UpdateCustomer(customer);
		}
	}
}
