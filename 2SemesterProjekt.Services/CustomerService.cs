using _2SemesterProjekt.Domain.Interfaces.RepositoryInterfaces;
using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProjekt.Domain.Models;
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
			await _customerRepository.CreateCustomerAsync(customer);
		}

		public async Task<IEnumerable<Customer>> GetAllCustomersAsync()
		{
			return await _customerRepository.GetAllCustomersAsync();
		}

		public string[] GetCustomerTypes()
		{
			return _customerTypes;
        }

		public int GetCustomerIDByPhoneNumber(int phoneNumber)
		{
			return _customerRepository.GetCustomerIDByPhoneNumber(phoneNumber);
			/* Retrieves and returns the customer ID of the customer, who has a specific
			 phone number. Will always return 0, if the customer doesn't exist in the DB. */
		}
		
		public async Task<Customer> GetCustomerByPhoneNumberAsync(int phoneNumber)
		{
			return await _customerRepository.GetCustomerByPhoneNumberAsync(phoneNumber);
		}
    }
}
