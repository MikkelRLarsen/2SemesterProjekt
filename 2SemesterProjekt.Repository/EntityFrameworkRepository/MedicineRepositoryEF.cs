using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using _2SemesterProjekt.Domain.Models;
using _2SemesterProjekt.Domain.Interfaces.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;

namespace _2SemesterProjekt.Repository.EntityFrameworkRepository
{
    public class MedicineRepositoryEF :IMedicineRepository
    {
        private readonly EntityFramework _db;

        public MedicineRepositoryEF(EntityFramework db)
        {
            _db = db;
        }
        public async Task UpdateMedicineAsync(Medicine medicine)
        {
            _db.Update(medicine);
            await _db.SaveChangesAsync();
        }

    }
}
