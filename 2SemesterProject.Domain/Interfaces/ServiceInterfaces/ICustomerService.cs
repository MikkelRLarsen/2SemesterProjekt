using _2SemesterProjekt.Domain.Models;

namespace _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces
{
	public interface ICustomerService
	{
		public Task<IEnumerable<Customer>> GetAllCustomersWithPetsAsync();
		public string[] GetCustomerTypes();
		public Task CreateCustomerAsync(Customer customer);
		public Task<Customer> GetCustomerByPhoneNumberAsync(int phoneNumber);
		public Task<IEnumerable<Customer>> GetAllCustomersAsync();
	}
}
