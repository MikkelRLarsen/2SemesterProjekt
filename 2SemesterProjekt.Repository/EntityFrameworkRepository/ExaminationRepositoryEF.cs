using _2SemesterProjekt.Domain.Interfaces.RepositoryInterfaces;
using _2SemesterProjekt.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Repository.EntityFrameworkRepository
{
    class ExaminationRepositoryEF : IExaminationRepository
    {
        private readonly EntityFramework _db;
        
        public ExaminationRepositoryEF(EntityFramework db)
        {
            _db = db;
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
            throw new NotImplementedException();
        }
        
    }
}
