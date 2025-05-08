using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2SemesterProjekt.Domain.Interfaces.RepositoryInterfaces;
using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProjekt.Domain.Models;

namespace _2SemesterProjekt.Services
{
    public class CageService : ICageService
    {
        private readonly ICageRepository _cageRepository;

        public CageService(ICageRepository cageRepository)
        {
            _cageRepository = cageRepository;
        }

        public async Task<decimal> GetTotalPriceForCage(string petSpecies, DateTime startDate, DateTime estimatedEndDate)
        {
            decimal basePrice = await _cageRepository.GetBasePriceForPetCageAsync(petSpecies);

            decimal totalPrice = (startDate - estimatedEndDate).Days * basePrice; // Calculates estimated total price.

            return totalPrice;
        }

        public async Task IsFullyBooked(string petSpecies, DateTime startDate, DateTime estimatedEndDate)
        {
            IEnumerable<CageBooking> listOfCageBookingsOnDate = await _cageRepository.GetAllCageBookingsOnDate(startDate);

            int numberOfCatBookingsOnDate = listOfCageBookingsOnDate.Count(cBooking => cBooking.Cage.Species == "Kat");
            int numberOfDogBookingsOnDate = listOfCageBookingsOnDate.Count(cBooking => cBooking.Cage.Species == "Hund");

            if (numberOfCatBookingsOnDate >= 4 && petSpecies == "Kat" ||
                numberOfDogBookingsOnDate >= 4 && petSpecies == "Hund")
            {
                throw new ArgumentException($"Der er ikke flere ledige bure a typen {petSpecies} på denne dato");
            }
        }

        public async Task<CageBooking> CreateCageBookingAsync(CageBooking cageBooking)
        {
            return await _cageRepository.CreateBookingAsync(cageBooking);
        }

        public async Task<Cage> GetPetCageAsync(string petSpecies)
        {
            var cage = await _cageRepository.GetPetCageAsync(petSpecies);

            return cage;
        }
    }
}
