using _2SemesterProject.Domain.Models;
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
		public Task CreateExaminationAsync(Examination examination);
		public Task<IEnumerable<ExaminationType>> GetAllExaminationTypesAsync();

    }
}
