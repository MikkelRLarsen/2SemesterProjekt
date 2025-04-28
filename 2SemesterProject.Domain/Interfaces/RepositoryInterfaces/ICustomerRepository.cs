using _2SemesterProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProject.Domain.Interfaces.RepositoryInterfaces
{
	public interface ICustomerRepository
	{
		public Task<IEnumerable<Customer>> GetAllCustomersAsync();
		public Customer GetCustomerById(int customerID);
		public void UpdateCustomer(Customer customer);
		public void DeleteCustomer(Customer customer);
		public bool CreateCustomer(Customer customer);
		public int GetCustomerIDByPhoneNumber (int phoneNumber);
	}
}
