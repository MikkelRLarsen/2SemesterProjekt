using _2SemesterProjekt.Domain.Models;

namespace _2SemesterProjekt.Domain.Interfaces.RepositoryInterfaces
{
	public interface IExaminationRepository
	{
		public Task CreateExaminationAsync(Examination examination);

		public Task<IEnumerable<Examination>> GetAllExaminationOnDate(DateTime date);

		public Task<IEnumerable<ExaminationType>> GetAllExaminationTypesAsync();

		public Task<IEnumerable<Examination>> GetAllInactivesAsync();
		public Task<IEnumerable<Examination>> GetAllExaminationsAsync();
		public Task<IEnumerable<Examination>> GetAllExaminationOnCustomerPhoneNumber(int customerPhoneNumber);
	}
}
