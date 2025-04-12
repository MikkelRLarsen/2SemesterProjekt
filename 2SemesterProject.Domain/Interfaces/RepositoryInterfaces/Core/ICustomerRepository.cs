using _2SemesterProject.Domain.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProject.Domain.Interfaces.RepositoryInterfaces.Core
{
	public interface ICustomerRepository
	{
		public Task<Customer> GetAllCustomerAsync();
	}
}
