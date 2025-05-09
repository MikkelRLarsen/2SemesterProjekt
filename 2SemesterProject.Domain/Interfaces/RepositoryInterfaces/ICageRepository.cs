using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2SemesterProjekt.Domain.Models;

namespace _2SemesterProjekt.Domain.Interfaces.RepositoryInterfaces
{
    public interface ICageRepository
    {
        public Task<CageBooking> CreateBookingAsync(CageBooking booking);
        public Task<IEnumerable<CageBooking>> GetAllCageBookingsOnDate(DateTime startDate, DateTime endDate);
        public Task<decimal> GetBasePriceForPetCageAsync(string petSpecies);
        public Task<Cage> GetPetCageAsync(string petSpecies);
    }
}
