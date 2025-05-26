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

        public async Task<decimal> GetTotalPriceForCageAsync(Cage availableCage, DateTime startDate, DateTime estimatedEndDate)
        {
            decimal basePrice = await _cageRepository.GetBasePriceForPetCageAsync(availableCage);

            decimal totalPrice = (estimatedEndDate - startDate).Days * basePrice; // Calculates estimated total price.

            return totalPrice;
        }

        public async Task CreateCageBookingAsync(CageBooking cageBooking)
        {
            await _cageRepository.CreateBookingAsync(cageBooking);
        }

        public async Task<Cage> GetAvailableCageAsync(Pet pet, DateTime startDate, DateTime endDate)
        {
            var cage = await _cageRepository.GetAvailableCageAsync(pet, startDate, endDate);

            if (cage == null)
            {
                throw new ArgumentException($"Der er ikke flere ledige bure a typen {pet.Species.Name} på denne dato");
            }

            return cage;
        }
    }
}
