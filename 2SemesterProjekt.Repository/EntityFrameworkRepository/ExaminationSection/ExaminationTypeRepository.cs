using _2SemesterProject.Domain.Interfaces.RepositoryInterfaces.ExaminationSection;
using _2SemesterProject.Domain.Models.ExaminationSection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Repository.EntityFrameworkRepository.ExaminationSection
{
	public class ExaminationTypeRepository : IExaminationTypeRepository
	{
		private readonly EntityFrameworkRepositoryCore _dbContext = new EntityFrameworkRepositoryCore();	
		public void CreateExaminationType(ExaminationType examinationType)
		{
			_dbContext.ExaminationType.Add(examinationType);
			_dbContext.SaveChanges();
		}

		public void DeleteExaminationType(ExaminationType examinationType)
		{
			_dbContext.ExaminationType.Remove(examinationType);
			_dbContext.SaveChanges();
		}

		public async Task<IEnumerable<ExaminationType>> GetAllExaminationTypesAsync()
		{
			return await _dbContext.ExaminationType
				.Include(ex => ex.Examination)
				.ThenInclude(e => e.Pet)
				.ToListAsync();
		}

		public ExaminationType GetExaminationTypeById(int examinationTypeId)
		{
			return _dbContext.ExaminationType
				.Include(ex => ex.Examination)
				.ThenInclude(e => e.Pet)
				.Where(ex => ex.ExaminationTypeID == examinationTypeId)
				.First();
		}

		public void UpdateExaminationType(ExaminationType examinationType)
		{
			_dbContext.ExaminationType.Update(examinationType);
			_dbContext.SaveChanges();
		}
	}
}
