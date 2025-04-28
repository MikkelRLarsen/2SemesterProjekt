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
    public class ExaminationService : IExaminationService
    {
        private readonly IExaminationRepository _examinationRepository;

		public ExaminationService(IExaminationRepository examinationRepository)
		{
			_examinationRepository = examinationRepository;
		}

		public Task<IEnumerable<Examination>> GetAllExaminationsAsync()
        {
            throw new NotImplementedException();
        }
        public Examination GetExaminationById(int examinationId)
        {
            throw new NotImplementedException();
        }
        public void UpdateExamination(Examination examination)
        {
            throw new NotImplementedException();
        }
        public void DeleteExamination(Examination examination)
        {
            throw new NotImplementedException();
        }
        public void CreateExamination(Examination examination)
        {
            _examinationRepository.CreateExamination(examination);
        }
        public async Task<IEnumerable<string>> GetAllExaminationTypesAsync()
        {
            List<string> examinationTypes = new List<string>()
            {
                "Konsulation", "Operation", "Behandling"
            };

            return examinationTypes;
        }
        public double GetAllExaminationPrices(string examinationType)
        {
            return 100;
        }
    }
}
