using _2SemesterProject.Domain.Interfaces.RepositoryInterfaces.Core;
using _2SemesterProject.Domain.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Repository.EntityFrameworkRepository.Core
{
	public class CustomerRepository : EntityFrameworkRepositoryCore, ICustomerRepository
	{
		public Task<Customer> GetAllCustomerAsync()
		{
			 
		}
	}
}
