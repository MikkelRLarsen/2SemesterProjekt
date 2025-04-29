using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using _2SemesterProjekt.Domain.Interfaces.RepositoryInterfaces;
using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProjekt.Domain.Models;

namespace _2SemesterProjekt.Services
{
    public class ExaminationService : IExaminationService
    {
        private readonly IExaminationRepository _examinationRepository;
        private Dictionary<string, double> _examinationPrices = new();

		public ExaminationService(IExaminationRepository examinationRepository)
		{
			_examinationRepository = examinationRepository;
            CreateDictionaryForExaminationPrices();
		}

        private void CreateDictionaryForExaminationPrices()
        {
            _examinationPrices.Add("Konsulation", 200);
            _examinationPrices.Add("Operation", 500);
            _examinationPrices.Add("Behandling", 400);
        }

        public async Task CreateExaminationAsync(Examination examination)
        {
            //Checks if the is a Double Booking that specific Date. Returns error if Pet or Employee is booked
            await IsDoubleBooked(examination);
            await _examinationRepository.CreateExaminationAsync(examination);
        }
        public async Task<IEnumerable<string>> GetAllExaminationTypesAsync()
        {
            return _examinationPrices.Keys.ToArray();
        }
        public async Task<double> GetAllExaminationPricesAsync(string examinationType)
        {
            return _examinationPrices[examinationType];
        }

        private async Task IsDoubleBooked(Examination examination)
        {
            IEnumerable<Examination> allExaminationOnSpecificDate = await _examinationRepository.GetAllExaminationOnDate(examination.Date);

            foreach (Examination examinationOnDate in allExaminationOnSpecificDate)
            {
                if (examinationOnDate.EmployeeID == examination.EmployeeID)
                {
                    throw new ArgumentException("Employee is already booked that day");
                }

                if (examinationOnDate.PetID == examination.PetID)
                {
					throw new ArgumentException("Pet is already booked that day");
				}
            }
        }
    }
}
