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
            _db.SaveChanges();
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
            // First it find all examination which is older than 12 months AND where a pet haven't had a examination within the last 12 months
            // Then orders them by PetID and afterwards order them by examination date, so I can filter through them in BLL

			var result = await _db.Examinations
				.Where(e => e.Date < twelveMonthsAgo &&

							!_db.Examinations // Subquery begins
								.Where(ex => ex.Date >= twelveMonthsAgo) // Find all examinations within 12 months
								.Select(ex => ex.PetID) // Selects the PetID, since its the only propperty im intereset in
								.Distinct() // I dont want duplitcated petID, so I only want Distinct of them. 
								.Contains(e.PetID)) // Checks if the PetID from subquery is inside the original search
								// Summery of subquery. Gets all Distinct PetID from examinations which have happend wihtin 12 months
                                // and checks if they were in the original seach which contains all examination older than 12 months

                // All in all: query returns all examinations that are older than 12 months and where the pet haven't had a examination within 12 months
				.Include(e => e.Pet)
					.ThenInclude(p => p.Customer)
				.OrderBy(e => e.PetID)
				.ThenByDescending(e => e.Date)
				.ToListAsync();

			return result;
        }
    }
}
