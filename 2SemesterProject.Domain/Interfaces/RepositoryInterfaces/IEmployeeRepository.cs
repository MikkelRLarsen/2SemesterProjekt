using _2SemesterProjekt.Domain.Models;

namespace _2SemesterProjekt.Domain.Interfaces.RepositoryInterfaces
{
	public interface IEmployeeRepository
	{
		public Task<IEnumerable<Employee>> GetAllEmployeeWithTypeAsync(string employeeType);
		public Task CreateEmployeeAsync(Employee employee);
	}
}
