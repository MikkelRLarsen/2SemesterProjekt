using _2SemesterProjekt.Domain.Models;

namespace _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces
{
	public interface ICustomerService
	{
		public Task<IEnumerable<Customer>> GetAllCustomersAsync();
		public string[] GetCustomerTypes();
		public int GetCustomerIDByPhoneNumber(int phoneNumber);
		public Task CreateCustomerAsync(Customer customer);
	}
}
