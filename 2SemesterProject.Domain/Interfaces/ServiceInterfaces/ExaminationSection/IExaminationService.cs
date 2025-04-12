using _2SemesterProject.Domain.Models.Core.Pets;
using _2SemesterProject.Domain.Models.ExaminationSection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProject.Domain.Interfaces.ServiceInterfaces.ExaminationSection
{
	public interface IExaminationService
	{
		public Task<IEnumerable<Examination>> GetAllExaminationsAsync();
		public Examination GetExaminationById(int examinationId);
		public void UpdateExamination(Examination examination);
		public void DeleteExamination(Examination examination);
		public void CreatExamination(Examination examination);
	}
}
