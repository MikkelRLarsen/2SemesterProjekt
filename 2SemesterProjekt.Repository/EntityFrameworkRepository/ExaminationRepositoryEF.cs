using _2SemesterProjekt.Domain.Interfaces.RepositoryInterfaces;
using _2SemesterProjekt.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Repository.EntityFrameworkRepository
{
    public class ExaminationRepositoryEF : IExaminationRepository
    {
        private readonly EntityFramework _db;
        
        public ExaminationRepositoryEF(EntityFramework db)
        {
            _db = db;
        }
        public async Task CreateExaminationAsync(Examination examination)
        {
            await _db.Examinations.AddAsync(examination);
            _db.SaveChanges();
        }

		public async Task<IEnumerable<Examination>> GetAllExaminationOnDate(DateTime date)
		{
            try
            {
				return await _db.Examinations
	                .Where(e => e.Date == date)
	                .ToListAsync();
			}
            catch (Exception)
            {
                return Enumerable.Empty<Examination>();
            }
		}
	}
}
