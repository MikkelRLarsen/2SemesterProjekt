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
            // Gets petIDs of those pets whose most recent exam is older than 12 months.   
            List<int> inactivePetIDs = new List<int>();
            DateTime twelveMonths = DateTime.Now.AddMonths(-12);

            inactivePetIDs = await _db.Examinations
                .GroupBy(e => e.PetID) 
                // GroupBy: adds all examinations (if there are more than one) to the PetID.
                .Where(g => g.Max(e => e.Date) < twelveMonths)
                // Max: the maximum date in the group.
                // twelveMonths: is that max date older than 12 months.
                .Select(g => g.Key) 
                // Key: gets the value of the key that was used to create the group: ie. PetId.
                .ToListAsync();

            // Gets old exams, pet and the pet's owner.
            List<Examination> listOfInactives = new List<Examination>();

            listOfInactives = await _db.Examinations
                .Where(e => inactivePetIDs.Contains(e.PetID) && e.Date < twelveMonths)
                // The old exams.
                .Include(e => e.Pet)
                // The pet.
                .ThenInclude(p => p.Customer)
                // The pet's owner.
                .ToListAsync();
            
            return listOfInactives;
        }
	}
}
