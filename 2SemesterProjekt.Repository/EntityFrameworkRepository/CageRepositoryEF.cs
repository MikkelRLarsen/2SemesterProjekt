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

        public async Task<CageBooking> CreateBookingAsync(CageBooking booking)
        {
            _db.CageBookings
                .Add(booking);

            _db.Entry(booking).GetDatabaseValues();

            return booking;
        }

        public async Task<decimal> GetBasePriceForPetCageAsync(string petSpecies)
        {
            var cage = _db.Cages
                .First(ca => ca.Species == petSpecies);

            return cage.Price;
        }

        public async Task<IEnumerable<CageBooking>> GetAllCageBookingsOnDate(DateTime date)
        {
            try
            {
                return await _db.CageBookings
                    // Filtrates and returns all bookings, where the desired dato falls in between.
                    .Where(cBooking => cBooking.StartDate <= date && cBooking.EndDate >= date)
                    .Include(cBooking => cBooking.Cage)
                    .ToListAsync();
            }
            catch (Exception)
            {
                return Enumerable.Empty<CageBooking>(); // Returns empty list
            }
        }

        public async Task<Cage> GetPetCageAsync(string petSpecies)
        {
            var cage = _db.Cages
                .First(ca => ca.Species == petSpecies);

            return cage;
        }
    }
}
