using _2SemesterProject.Domain.Interfaces.RepositoryInterfaces.Core;
using _2SemesterProject.Domain.Interfaces.ServiceInterfaces.Core;
using _2SemesterProject.Domain.Models.Core.Pets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Services.Core
{
	public class PetService : IPetService
	{

		private readonly IPetRepository _petRepository;

		public PetService(IPetRepository petRepository)
		{
			_petRepository = petRepository;
		}

		public void CreatPet(Pet pet)
		{
			_petRepository.CreatPet(pet);
		}

		public void DeletePet(Pet pet)
		{
			_petRepository.DeletePet(pet);
		}

		public async Task<IEnumerable<Pet>> GetAllPetsAsync()
		{
			return await _petRepository.GetAllPetsAsync();	
		}

		public Pet GetPetById(int petId)
		{
			return _petRepository.GetPetById(petId);
		}

		public void UpdatePet(Pet pet)
		{
			_petRepository.UpdatePet(pet);
		}
	}
}
