using _2SemesterProjekt.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces
{
	public interface ICustomerService
	{
		public Task<IEnumerable<Customer>> GetAllCustomersAsync();
		public string[] GetCustomerTypes();
		public int GetCustomerIDByPhoneNumber(int phoneNumber);
		public Task CreateCustomerAsync(Customer customer);
		public Task<Customer> GetCustomerByPhoneNumberAsync(int phoneNumber);
	}
}
