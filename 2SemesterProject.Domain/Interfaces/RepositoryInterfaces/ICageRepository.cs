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
        public Task CreateBookingAsync(CageBooking booking);
        public Task<decimal> GetBasePriceForPetCageAsync(Pet pet);
        public Task<Cage?> GetAvailableCageAsync(Pet pet, DateTime startDate, DateTime endDate);
    }
}
