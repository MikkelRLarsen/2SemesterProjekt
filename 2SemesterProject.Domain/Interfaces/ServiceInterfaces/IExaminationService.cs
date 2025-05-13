using _2SemesterProjekt.Domain.Models;

namespace _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces
{
	public interface IExaminationService
	{
		public Task CreateExaminationAsync(Examination examination);
		public Task<IEnumerable<ExaminationType>> GetAllExaminationTypesAsync();
		public Task<IEnumerable<Examination>> GetAllInactivesAsync();
		public Task<IEnumerable<Examination>> GetAllExaminationsAsync();
		public Task<IEnumerable<Examination>> GetAllExaminationOnCustomerPhoneNumber(int customerPhoneNumber);
		public Task DeleteExaminationAsync(Examination examination);
		public Task<bool> CheckIfExaminationCanBeDeleted(DateTime examinationTime);
		public Task ExportInvoiceToTxtAsync(Invoice invoiceExamination, string fileName);
		public Task UpdateExamination(Examination examination);
    }
}
