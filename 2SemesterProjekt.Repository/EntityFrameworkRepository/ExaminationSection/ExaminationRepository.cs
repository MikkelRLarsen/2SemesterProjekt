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
	public class ExaminationRepository : IExaminationRepository
	{
		private readonly EntityFrameworkRepositoryCore _dbContext = new EntityFrameworkRepositoryCore();

		public void CreateExamination(Examination examination)
		{
			_dbContext.Examinations.Add(examination);
			_dbContext.SaveChanges();
		}

		public void DeleteExamination(Examination examination)
		{
			_dbContext.Examinations.Remove(examination);
			_dbContext.SaveChanges();
		}

		public async Task<IEnumerable<Examination>> GetAllExaminationsAsync()
		{
			return await _dbContext.Examinations
				.Include(e => e.ExaminationType)
				.Include(e => e.Pet)
				.ToListAsync();
		}

		public Examination GetExaminationById(int examinationId)
		{
			return _dbContext.Examinations
				.Include(e => e.ExaminationType)
				.Include(e => e.Pet)
				.Where(e => e.ExaminationID == examinationId)
				.First();
		}

		public void UpdateExamination(Examination examination)
		{
			_dbContext.Examinations.Update(examination);
			_dbContext.SaveChanges();
		}
	}
}
