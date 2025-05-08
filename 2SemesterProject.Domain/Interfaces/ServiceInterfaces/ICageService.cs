using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2SemesterProjekt.Domain.Models;

namespace _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces
{
    public interface ICageService
    {
        public Task<decimal> GetTotalPriceForCage(string petSpecies, DateTime startDate, DateTime estimatedEndDate);
        public Task IsFullyBooked(string petSpecies, DateTime startDate, DateTime estimatedEndDate);
        public Task<CageBooking> CreateCageBookingAsync(CageBooking cageBooking);
        public Task<Cage> GetPetCageAsync(string petSpecies);
    }
}
