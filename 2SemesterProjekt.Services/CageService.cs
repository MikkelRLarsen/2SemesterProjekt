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

            decimal totalPrice = (estimatedEndDate - startDate).Days * basePrice; // Calculates estimated total price.

            return totalPrice;
        }

        public async Task IsFullyBooked(string petSpecies, DateTime startDate, DateTime estimatedEndDate)
        {
            // Gets all petcages bookings in booking interval
            IEnumerable<CageBooking> listOfCageBookingsInInterval = await _cageRepository.GetAllCageBookingsOnDate(startDate, estimatedEndDate);

            // Counts number of cat cages in interval
            int numberOfCatBookingsOnDate = listOfCageBookingsInInterval.Count(cBooking => cBooking.Cage.Species == "Kat");

            // Counts number of dog cages in interval
            int numberOfDogBookingsOnDate = listOfCageBookingsInInterval.Count(cBooking => cBooking.Cage.Species == "Hund");

            // If there isn't space for the pet => throw error
            // Max is hardcoded for now => refactoring in another sprint
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
