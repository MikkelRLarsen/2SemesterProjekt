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

        public async Task<decimal> GetTotalPriceForCage(Pet pet, DateTime startDate, DateTime estimatedEndDate)
        {
            decimal basePrice = await _cageRepository.GetBasePriceForPetCageAsync(pet);

            decimal totalPrice = (estimatedEndDate - startDate).Days * basePrice; // Calculates estimated total price.

            return totalPrice;
        }

        public async Task IsFullyBooked(Pet pet, DateTime startDate, DateTime estimatedEndDate)
        {
            // Gets all petcages
            IEnumerable<Cage> totalCages = await _cageRepository.GetAllCagesAsync();
            
            // Gets all petcages bookings in booking interval
            IEnumerable<CageBooking> cageBookingsInInterval = await _cageRepository.GetAllCageBookingsOnDate(startDate, estimatedEndDate);

            // Counts number of total cages and booked cages in interval
            int totalCagesForSpecies = totalCages.Count(c => c.SpeciesID == pet.SpeciesID);
            int bookedCagesForSpecies = cageBookingsInInterval.Count(cBooking => cBooking.Cage.SpeciesID == pet.SpeciesID);

            // If there isn't space for the pet => throw error
            if (bookedCagesForSpecies >= totalCagesForSpecies)
            {
                throw new ArgumentException($"Der er ikke flere ledige bure a typen {pet.Species.Name} på denne dato");
            }
        }

        public async Task CreateCageBookingAsync(CageBooking cageBooking)
        {
            await _cageRepository.CreateBookingAsync(cageBooking);
        }

        public async Task<Cage> GetPetCageAsync(Pet pet)
        {
            var cage = await _cageRepository.GetPetCageAsync(pet);

            return cage;
        }
    }
}
