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
    public class MedicineService : IMedicineService
    {
        private readonly IMedicineRepository _medicineRepository;

        public MedicineService(IMedicineRepository medicineRepository)
        {
            _medicineRepository = medicineRepository;
        }
        /// <summary>
        /// Updates medicine
        /// </summary>
        /// <param name="medicine"></param>
        /// <returns></returns>
        public async Task UpdateMedicineAsync(Medicine medicine)
        {
            await _medicineRepository.UpdateMedicineAsync(medicine);
        }

    }
}
