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

        public async Task CreateCageBookingAsync(CageBooking cageBooking)
        {
            await IsFullyBooked(cageBooking);

        }

        private async Task IsFullyBooked(CageBooking booking)
        {
            IEnumerable<CageBooking> listOfCageBookingsOnDate = await _cageRepository.GetAllCageBookingsOnDate(booking.StartDate);

            int numberOfCatBookingsOnDate = listOfCageBookingsOnDate.Count(cBooking => cBooking.Cage.Species == "Kat");
            int numberOfDogBookingsOnDate = listOfCageBookingsOnDate.Count(cBooking => cBooking.Cage.Species == "Hund");

            if (numberOfCatBookingsOnDate >= 4 && booking.Cage.Species == "Kat" ||
                numberOfDogBookingsOnDate >= 4 && booking.Cage.Species == "Hund")
            {
                throw new ArgumentException($"Der er ikke flere ledige bure a typen {booking.Cage.Species} på denne dato");
            }
        }
    }
}
