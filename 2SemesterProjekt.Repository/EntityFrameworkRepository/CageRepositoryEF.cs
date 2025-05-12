using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2SemesterProjekt.Domain.Interfaces.RepositoryInterfaces;
using _2SemesterProjekt.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace _2SemesterProjekt.Repository.EntityFrameworkRepository
{
    public class CageRepositoryEF : ICageRepository
    {
        private readonly EntityFramework _db;

        public CageRepositoryEF(EntityFramework db)
        {
            _db = db;
        }

        public async Task CreateBookingAsync(CageBooking booking)
        {
            await _db.CageBookings
                .AddAsync(booking);

            await _db.SaveChangesAsync();
        }

        public async Task<decimal> GetBasePriceForPetCageAsync(Pet pet)
        {
            var cage = await _db.Cages
                .FirstOrDefaultAsync(ca => ca.SpeciesID == pet.SpeciesID);

            if (cage == null)
            {
                throw new ArgumentException("Kunne ikke finde nogen bure");
            }

            return cage.Price;
        }

        public async Task<IEnumerable<CageBooking>> GetAllCageBookingsOnDate(DateTime startDate, DateTime endDate)
        {
            try
            {
                return await _db.CageBookings
                    // Checks if there is any hits that overlaps the requested booking interval
                    .Where(cBooking => cBooking.StartDate < endDate.Date && cBooking.EndDate > startDate.Date)
                    .Include(cBooking => cBooking.Cage) // Include the cage for capacity-check for the specified pet
                    .ToListAsync();
            }
            catch (Exception)
            {
                return Enumerable.Empty<CageBooking>(); // Returns empty list
            }
        }

        public async Task<Cage> GetPetCageAsync(Pet pet)
        {
            var cage = await _db.Cages
                .FirstOrDefaultAsync(ca => ca.SpeciesID == pet.SpeciesID);
            
            if (cage == null)
            {
                throw new ArgumentException("Kunne ikke finde nogen bure");
            }

            return cage;
        }

        public async Task<IEnumerable<Cage>> GetAllCagesAsync()
        {
            var listOfCages = await _db.Cages
                .ToListAsync();

            return listOfCages;
        }
    }
}
