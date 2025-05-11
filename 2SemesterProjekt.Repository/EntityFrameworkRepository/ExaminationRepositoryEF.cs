using _2SemesterProjekt.Domain.Models;
using _2SemesterProjekt.Domain.Interfaces.RepositoryInterfaces;
using _2SemesterProjekt.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

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

			await _db.SaveChangesAsync();
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
				return Enumerable.Empty<Examination>();
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
        public async Task<IEnumerable<Examination>> GetAllInactivesAsync()
        {

			var twelveMonthsAgo = DateTime.Now.AddMonths(-12);

            // This is a subquery inside a query
            // First it finds all examinations which are older than 12 months AND where a pet haven't had an examination within the last 12 months.
            // Then orders them by PetID and afterwards order them by examination date, so I can filter through them in BLL.

			var result = await _db.Examinations
				.Where(e => e.Date < twelveMonthsAgo &&

							!_db.Examinations // Subquery begins
								.Where(ex => ex.Date >= twelveMonthsAgo) // Find all examinations within 12 months
								.Select(ex => ex.PetID) // Selects the PetID, since its the only propperty I'm interested in.
								.Distinct() // I dont want duplicated petID, only the Distinct PetID. 
								.Contains(e.PetID)) // Checks if the PetID from subquery is inside the original search.
								// Summery of subquery. Gets all Distinct PetID from examinations which have happened within 12 months.
                                // and checks if they were in the original search which contains all examination older than 12 months.

                // All in all: query returns all examinations that are older than 12 months and where the pet haven't had an examination within 12 months.
				.Include(e => e.Pet)
					.ThenInclude(p => p.Customer)
				.OrderBy(e => e.PetID)
				.ThenByDescending(e => e.Date)
				.ToListAsync();

			return result;
        }
    }
}
