using _2SemesterProjekt.Domain.Models;
using _2SemesterProjekt.Domain.Interfaces.RepositoryInterfaces;
using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;

namespace _2SemesterProjekt.Services
{
	public class ExaminationService : IExaminationService
    {
        private readonly IExaminationRepository _examinationRepository;

		public ExaminationService(IExaminationRepository examinationRepository)
		{
			_examinationRepository = examinationRepository;
		}

        public async Task CreateExaminationAsync(Examination examination)
        {
            //Checks if the examination is a Double Booking that specific Date. Returns error if Pet or Employee is booked
            await IsDoubleBooked(examination);
            await _examinationRepository.CreateExaminationAsync(examination);
        }


        public async Task<IEnumerable<Examination>> GetAllExaminationOnCustomerPhoneNumber(int customerPhoneNumber)
		{
			return await _examinationRepository.GetAllExaminationOnCustomerPhoneNumber(customerPhoneNumber);
		}

		public async Task<IEnumerable<Examination>> GetAllExaminationsAsync()
		{
            return await _examinationRepository.GetAllExaminationsAsync();
		}

		public async Task<IEnumerable<ExaminationType>> GetAllExaminationTypesAsync()
        {
            return await _examinationRepository.GetAllExaminationTypesAsync();
        }

        /// <summary>
        /// Checks if The Employee or Pet is already booked for examination on the given day.
        /// Throw ArgumentException if they are already booked
        /// </summary>
        /// <param name="examination"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        private async Task IsDoubleBooked(Examination examination)
        {
            // Retrives all Examination of a given day
            IEnumerable<Examination> allExaminationOnSpecificDate = await _examinationRepository.GetAllExaminationOnDate(examination.Date);

            // Checks if Employee or Pet is already booked on that day
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
        public async Task<IEnumerable<Examination>> GetAllInactivesAsync()
        {
            IEnumerable<Examination> allExaminations = await _examinationRepository.GetAllInactivesAsync();

            List<Examination> distinctListWithOnlyOneExaminationPrPet = new List<Examination> {};

            // Removes every examination except the first foreach pet
            int currentPetID = 0; // Keeps track of which pet is being checked right now
            foreach (Examination examinaion in allExaminations)
            {
                if (examinaion.PetID != currentPetID)
                {
                    currentPetID = examinaion.PetID;
                    distinctListWithOnlyOneExaminationPrPet.Add(examinaion);
                }
            }

            if (allExaminations == null || allExaminations.Count() == 0)
            {
                throw new Exception();
            }

            return distinctListWithOnlyOneExaminationPrPet;
        }

        public async Task DeleteExaminationAsync(Examination examination)
        {
            await _examinationRepository.DeleteExaminationAsync(examination);
        }
    }
}
