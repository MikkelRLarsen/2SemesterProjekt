using _2SemesterProject.Domain.Interfaces.RepositoryInterfaces.ExaminationSection;
using _2SemesterProject.Domain.Models.ExaminationSection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Services.ExaminationSection
{
	public class ExaminationTypeService : IExaminationTypeRepository
	{

		private readonly IExaminationTypeRepository _examinationTypeRepo;

		public ExaminationTypeService(IExaminationTypeRepository examinationTypeRepo)
		{
			_examinationTypeRepo = examinationTypeRepo;
		}

		public void CreateExaminationType(ExaminationType examinationType)
		{
			_examinationTypeRepo.CreateExaminationType(examinationType);
		}

		public void DeleteExaminationType(ExaminationType examinationType)
		{
			_examinationTypeRepo.DeleteExaminationType(examinationType);
		}

		public async Task<IEnumerable<ExaminationType>> GetAllExaminationTypesAsync()
		{
			return await _examinationTypeRepo.GetAllExaminationTypesAsync();
		}

		public ExaminationType GetExaminationTypeById(int examinationTypeId)
		{
			return _examinationTypeRepo.GetExaminationTypeById(examinationTypeId);
		}

		public void UpdateExaminationType(ExaminationType examinationType)
		{
			_examinationTypeRepo.UpdateExaminationType(examinationType);
		}
	}
}
