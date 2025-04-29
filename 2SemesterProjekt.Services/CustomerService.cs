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
        private readonly string[] _customerTypes = { "Privat", "Erhverv" };

        public CustomerService(ICustomerRepository customerRepository) 
		{
			_customerRepository = customerRepository;
		}

		public async Task CreateCustomerAsync(Customer customer)
		{
			var result = _customerRepository.CreateCustomerAsync(customer);
		}

		public void DeleteCustomer(Customer customer)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<Customer>> GetAllCustomersAsync()
		{
			throw new NotImplementedException();
		}

		public string[] GetCustomerTypes()
		{
			return _customerTypes;
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
