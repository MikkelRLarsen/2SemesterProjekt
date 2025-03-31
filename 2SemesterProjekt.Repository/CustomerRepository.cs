using _2SemesterProject.Domain.Interfaces.RepositoryInterfaces;
using _2SemesterProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Repository
{
	internal class CustomerRepository : ICustomerRepository
	{
		public async Task<Customer> GetAllCustomerAsync()
		{
			throw new NotImplementedException();
		}
	}
}
