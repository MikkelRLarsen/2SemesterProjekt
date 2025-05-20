using _2SemesterProjekt.Domain.Models;

namespace _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces
{
	public interface IEmployeeService
	{
		public Task<IEnumerable<Employee>> GetAllEmployeeWithTypeAsync(string employeeType);
		public Task<IEnumerable<string>> GetAllEmployeeTypesAsync();
		public Task CreateEmployeeAsync(Employee employee);
	}
}
