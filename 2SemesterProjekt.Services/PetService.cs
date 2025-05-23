﻿using _2SemesterProjekt.Domain.Interfaces.RepositoryInterfaces;
using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProjekt.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;

namespace _2SemesterProjekt.Services
{
    public class PetService : IPetService
    {
        private readonly IPetRepository _petRepository;

        public PetService(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        public async Task CreatePetAsync(Pet pet)
        {
            await _petRepository.CreatePetAsync(pet); // The pet gets added to the DB.
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

        public async Task UpdatePetASync(Pet pet)
        {
            
            await _petRepository.UpdatePetAsync(pet);
        }

        public async Task<IEnumerable<Species>> GetAllPetSpeciesAsync()
        {
            var petSpecies = await _petRepository.GetAllPetSpeciesAsync();

            return petSpecies;
        }
    }
}
