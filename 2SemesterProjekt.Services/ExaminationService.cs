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
            if (IsDoubleBooked(examination) == false)
            {
			    await _examinationRepository.CreateExaminationAsync(examination);
            }
        }
        public async Task<IEnumerable<string>> GetAllExaminationTypesAsync()
        {
            return _examinationPrices.Keys.ToArray();
        }
        public async Task<double> GetAllExaminationPricesAsync(string examinationType)
        {
            return _examinationPrices[examinationType];
        }

        private bool IsDoubleBooked(Examination examination)
        {

            Examination[] allExaminationOnSpecificDate = _examinationRepository.GetAllExaminationOnDate(examination.Date).Result.ToArray();



            try
            {
				_examinationRepository.GetAllExaminationOnDate(examination.Date);
                return true;
			}
            catch (Exception)
            {

                return false;
            }
        }
    }
}
