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
        public Task<decimal> GetTotalPriceForCage(int petSpeciesID, DateTime startDate, DateTime estimatedEndDate);
        public Task IsFullyBooked(int petSpeciesID, DateTime startDate, DateTime estimatedEndDate);
        public Task CreateCageBookingAsync(CageBooking cageBooking);
        public Task<Cage> GetPetCageAsync(int petSpeciesID);
    }
}
