using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProjekt.Domain.Models;

namespace _2SemesterProjekt.Services
{
    class ExaminationService : IExaminationService
    {

        
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
            throw new NotImplementedException();
        }
        
    }
}
