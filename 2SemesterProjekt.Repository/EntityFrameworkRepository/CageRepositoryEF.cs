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

        public Task CreateBookingAsync(CageBooking booking)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CageBooking>> GetAllCageBookingsOnDate(DateTime date)
        {
            try
            {
                return await _db.CageBookings
                    // Filtrates and returns all bookings, where the desired dato falls in between.
                    .Where(cBooking => cBooking.StartDate <= date && cBooking.EndDate >= date)
                    .ToListAsync();
            }
            catch (Exception)
            {
                return Enumerable.Empty<CageBooking>(); // Returns empty list
            }
        }
    }
}
