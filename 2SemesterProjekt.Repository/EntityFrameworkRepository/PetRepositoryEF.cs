using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2SemesterProjekt.Domain.Interfaces.RepositoryInterfaces;
using _2SemesterProjekt.Domain.Models;

namespace _2SemesterProjekt.Repository.EntityFrameworkRepository
{
    public class PetRepositoryEF : IPetRepository
    {
        private readonly EntityFramework _db;
        public PetRepositoryEF(EntityFramework db)
        {
            _db = db;
        }
        public Task<IEnumerable<Pet>> GetAllPetsAsync()
        {
            throw new NotImplementedException();
        }
        public Pet GetPetById(int petId)
        {
            throw new NotImplementedException();
        }
        public void UpdatePet(Pet pet)
        {
            throw new NotImplementedException();
        }
        public void DeletePet(Pet pet)
        {
            throw new NotImplementedException();
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
        public void CreatePet(Pet pet)
        {
            _db.Pets.Add(pet);
            _db.SaveChanges();
            // The pet has been added to the DB.
        }
    }
}
