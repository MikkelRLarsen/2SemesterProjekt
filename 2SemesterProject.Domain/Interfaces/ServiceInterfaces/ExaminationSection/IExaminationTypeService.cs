using _2SemesterProject.Domain.Models.ExaminationSection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProject.Domain.Interfaces.ServiceInterfaces.ExaminationSection
{
	public interface IExaminationTypeService
	{
		public Task<IEnumerable<ExaminationType>> GetAllExaminationTypesAsync();
		public ExaminationType GetExaminationTypeById(int examinationTypeId);
		public void UpdateExaminationType(ExaminationType examinationType);
		public void DeleteExaminationType(ExaminationType examinationType);
		public void CreatExaminationType(ExaminationType examinationType);
	}
}
