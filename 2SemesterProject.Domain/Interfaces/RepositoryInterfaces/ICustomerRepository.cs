using _2SemesterProjekt.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Domain.Interfaces.RepositoryInterfaces
{
	public interface ICustomerRepository
	{
		public Task<IEnumerable<Customer>> GetAllCustomersAsync();
		public int GetCustomerIDByPhoneNumber (int phoneNumber);
		public Task CreateCustomerAsync(Customer customer);
	}
}
