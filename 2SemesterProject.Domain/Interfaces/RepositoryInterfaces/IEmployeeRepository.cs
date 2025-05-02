using _2SemesterProjekt.Domain.Models;

namespace _2SemesterProjekt.Domain.Interfaces.RepositoryInterfaces
{
	public interface IEmployeeRepository
	{
		public Task<IEnumerable<Employee>> GetAllPetDoctorsAsync();
	}
}
