using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2SemesterProjekt.Domain.Interfaces.RepositoryInterfaces;
using _2SemesterProjekt.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace _2SemesterProjekt.Repository.EntityFrameworkRepository
{
    public class PetRepositoryEF : IPetRepository
    {
        private readonly EntityFramework _db;
        public PetRepositoryEF(EntityFramework db)
        {
            _db = db;
        }
        public bool CheckIfPetExists(Pet pet)
        {
            var existingPet = _db.Pets.FirstOrDefault(p => p.Name == pet.Name && p.CustomerID == pet.CustomerID && p.Species == pet.Species);
            /* Checks if a pet with the same name, customer ID and species
            as the argument already exists in the DB. */

            if (existingPet == null)
            {
                return false; // The pet doesn't exist.
            }
            else 
            {
                return true; // The pet already exists.
            }
        }
        public async Task CreatePetAsync(Pet pet)
        {
            await _db.Pets.AddAsync(pet);
            _db.SaveChanges();
            // The pet has been added to the DB.
        }

        public async Task<IEnumerable<Pet>> GetAllPetsAsync()
        {
            return await _db.Pets
                .Include(p => p.Customer)
                .Include(p => p.Employee)
                .ToListAsync();
        }

        public async Task UpdatePetAsync(Pet pet)
        {
            _db.Update(pet);
            await _db.SaveChangesAsync();
        }
    }
}
