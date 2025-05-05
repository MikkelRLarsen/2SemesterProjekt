using _2SemesterProjekt.Domain.Models;
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

		public async Task<IEnumerable<Examination>> GetAllExaminationOnCustomerPhoneNumber(int customerPhoneNumber)
		{
			try
			{
				return await _db.Examinations
					.Where(e => e.Pet.Customer.PhoneNumber == customerPhoneNumber)
					.Include(e => e.Pet)
					.ThenInclude(p => p.Customer)
					.Include(e => e.Employee)
					.Include(e => e.ExaminationType)
					.ToListAsync();
			}
			catch (Exception)
			{
				throw new ArgumentException("Kunde har ikke nogle pets");
			}
		}

		public async Task<IEnumerable<Examination>> GetAllExaminationOnDate(DateTime date)
		{
            try
            {
				return await _db.Examinations
	                .Where(e => e.Date.Date == date.Date)
	                .ToListAsync();
			}
            catch (Exception)
            {
                return Enumerable.Empty<Examination>();
            }
		}

		public async Task<IEnumerable<Examination>> GetAllExaminationsAsync()
		{
            return await _db.Examinations
                .Include(e => e.Pet)
                .ThenInclude(p => p.Customer)
                .Include(e => e.Employee)
                .Include(e => e.ExaminationType)
                .ToListAsync();
		}

		public async Task<IEnumerable<ExaminationType>> GetAllExaminationTypesAsync()
		{
			return await _db.ExaminationTypes
                .Include(eType => eType.ExaminationTag)
                .ToListAsync();
		}
	}
}
