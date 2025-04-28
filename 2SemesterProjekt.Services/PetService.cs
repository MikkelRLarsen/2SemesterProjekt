using _2SemesterProject.Domain.Interfaces.RepositoryInterfaces;
using _2SemesterProject.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProject.Domain.Models;
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
        private readonly ICustomerRepository _customerRepository;

        public PetService(IPetRepository petRepository, ICustomerRepository customerRepository)
        {
            _petRepository = petRepository;
            _customerRepository = customerRepository;
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
        public string CreatePet(string petName, string petSpecies, DateTime petBirthday, int phoneNumber) /* This method can return different
                                                                messages to the UI, so it
                                                                can generate either an error
                                                                message or success message. */
        {
            int ownerId = _customerRepository.GetCustomerIDByPhoneNumber(phoneNumber);
            if (ownerId == 0 || ownerId == null)
            {
                return "Kunden med dette telefonnummer findes ikke i systemet.";
            }
            else if (string.IsNullOrWhiteSpace(petName) || string.IsNullOrWhiteSpace(petSpecies))
            {
                return "Udfyld venligst navn og/eller art!";
            }
            else
            {
                Pet pet = new Pet(ownerId, petName, petSpecies, petBirthday);
                bool petCreation = _petRepository.CreatePet(pet);

                if (!petCreation)
                {
                    return "Kæledyret findes allerede i databasen.";
                }
                else
                {
                    return $"{pet.Name} er blevet tilføjet til systemet.";
                }
            }
        }
    }
}
