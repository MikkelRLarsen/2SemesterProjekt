using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2SemesterProject.Domain.Interfaces.RepositoryInterfaces;
using _2SemesterProject.Domain.Models;

namespace _2SemesterProjekt.Repository.EntityFrameworkRepository
{
    internal class PetRepositoryEF : IPetRepository
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
        public bool CreatePet(Pet pet, int ownerId)
        {
            Pet newPet = new Pet(pet.PetID, ownerId, pet.Name, pet.Species, pet.Birthday);
            var existingPet = _db.Pets.FirstOrDefault(p => p.Name == newPet.Name && p.CustomerID == newPet.CustomerID);

            if (existingPet != null)
            {
                return false;
            }
            else
            {
                _db.Pets.Add(newPet);
                _db.SaveChanges();
                return true;
            }
        }
    }
}
