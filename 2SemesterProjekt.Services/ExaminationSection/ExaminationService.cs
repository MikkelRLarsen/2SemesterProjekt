using _2SemesterProject.Domain.Interfaces.RepositoryInterfaces.ExaminationSection;
using _2SemesterProject.Domain.Interfaces.ServiceInterfaces.ExaminationSection;
using _2SemesterProject.Domain.Models.ExaminationSection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Services.ExaminationSection
{
	public class ExaminationService : IExaminationService
	{
		private readonly IExaminationRepository _examinationRepo;

		public ExaminationService(IExaminationRepository examinationRepo)
		{
			_examinationRepo = examinationRepo;
		}

		public void CreatExamination(Examination examination)
		{
			_examinationRepo.CreateExamination(examination);
		}

		public void DeleteExamination(Examination examination)
		{
			_examinationRepo.DeleteExamination(examination);
		}

		public async Task<IEnumerable<Examination>> GetAllExaminationsAsync()
		{
			return await _examinationRepo.GetAllExaminationsAsync();
		}

		public Examination GetExaminationById(int examinationId)
		{
			return _examinationRepo.GetExaminationById(examinationId);
		}

		public void UpdateExamination(Examination examination)
		{
			_examinationRepo.UpdateExamination(examination);
		}
	}
}
