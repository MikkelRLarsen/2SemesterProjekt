using _2SemesterProject.Domain.Interfaces.RepositoryInterfaces;
using _2SemesterProject.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Services
{
	public class CustomerService : ICustomerService
	{
		private readonly ICustomerRepository _customerRepository;

		public CustomerService(ICustomerRepository customerRepository) 
		{
			_customerRepository = customerRepository;
		}

		public bool CreateCustomer(Customer customer)
		{
			var result = _customerRepository.CreateCustomer(customer);
			return result;
		}

		public void DeleteCustomer(Customer customer)
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
