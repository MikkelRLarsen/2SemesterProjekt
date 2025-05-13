using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2SemesterProjekt.Domain.Interfaces.RepositoryInterfaces;
using _2SemesterProjekt.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Abstractions;

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

        public async Task<decimal> GetBasePriceForPetCageAsync(Cage availableCage)
        {
            var cage = await _db.Cages
                .FirstOrDefaultAsync(ca => ca.CageID == availableCage.CageID);

            if (cage == null)
            {
                throw new ArgumentException("Kunne ikke finde nogen bure");
            }

            return cage.Price;
        }

        public async Task<Cage?> GetAvailableCageAsync(Pet pet, DateTime startDate, DateTime endDate)
        {
            var cages = await _db.Cages
                .Where(c => c.Species == pet.Species)
                .ToListAsync();
            
            // Iterates through cages to find the first available
            foreach (var cage in cages)
            {
                bool isBooked = await _db.CageBookings
                    // Finds the ID in DB to check if its booked in interval
                    .AnyAsync(cb => cb.CageID == cage.CageID &&
                    startDate < cb.EndDate &&
                    endDate > cb.StartDate);

                // If hit then return the cage
                if (isBooked == false)
                {
                    return cage;
                }
            }

            // Return null if there isn't any cage available
            return null;
        }
    }
}
