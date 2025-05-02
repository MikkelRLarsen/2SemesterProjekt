using _2SemesterProjekt.Domain.Models;

namespace _2SemesterProjekt.Domain.Interfaces.RepositoryInterfaces
{
	public interface ICustomerRepository
	{
		public Task<IEnumerable<Customer>> GetAllCustomersAsync();
		public int GetCustomerIDByPhoneNumber (int phoneNumber);
		public Task CreateCustomerAsync(Customer customer);
		public Task<Customer> GetCustomerByPhoneNumberAsync(int phoneNumber);
	}
}
