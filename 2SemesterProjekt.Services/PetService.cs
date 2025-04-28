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
        public string CreatePet(Pet pet, int ownerPhoneNumber) /* This method can return different
                                                                messages to the UI, so it
                                                                can generate either an error
                                                                message or success message. */
        {
            int ownerId = _customerRepository.GetCustomerIDByPhoneNumber(ownerPhoneNumber);
            if (ownerId == 0 || ownerId == null)
            {
                return "Customer Not Found";
            }
            else
            {
                bool petCreation = _petRepository.CreatePet(pet, ownerId);
                if (!petCreation)
                {
                    return "Pet Already In DB";
                }
                else
                {
                    return "Pet Added To DB";
                }
            }
        }
    }
}
