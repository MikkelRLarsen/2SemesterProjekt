using _2SemesterProjekt.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces
{
	public interface IExaminationService
	{
		public Task<IEnumerable<Examination>> GetAllExaminationsAsync();
		public Examination GetExaminationById(int examinationId);
		public void UpdateExamination(Examination examination);
		public void DeleteExamination(Examination examination);
		public void CreateExamination(Examination examination);

		public IEnumerable<string> GetAllExaminationTypes();
		public double GetAllExaminationPrices(string examinationType);

    }
}
