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
        public Task<int> CreateBookingAsync(CageBooking booking);
        public Task<IEnumerable<CageBooking>> GetAllCageBookingsOnDate(DateTime date);
        public Task<decimal> GetBasePriceForPetCageAsync(string petSpecies);
        public Task<int> GetPetCageIdAsync(string petSpecies);
    }
}
