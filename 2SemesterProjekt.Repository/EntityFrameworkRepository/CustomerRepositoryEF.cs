using _2SemesterProjekt.Domain.Interfaces.RepositoryInterfaces;
using _2SemesterProjekt.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Repository.EntityFrameworkRepository
{
	internal class CustomerRepositoryEF : ICustomerRepository
	{
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
        public void DeleteCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
        public void CreateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
