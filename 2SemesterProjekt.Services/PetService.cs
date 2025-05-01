using _2SemesterProjekt.Domain.Interfaces.RepositoryInterfaces;
using _2SemesterProject.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProjekt.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Services
{
    public class PetService : IPetService
    {
        private readonly IPetRepository _petRepository;

        public PetService(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        public void CreatePet(Pet pet)
        {
            _petRepository.CreatePet(pet); // The pet gets added to the DB.
        }

        public bool CheckIfPetExists(Pet pet)
        {
            return _petRepository.CheckIfPetExists(pet);
            // Returns true if the pet exists. Returns false, if not.
        }

        public async Task<IEnumerable<Pet>> GetAllPetsAsync()
        {
            return await _petRepository.GetAllPetsAsync();
}
