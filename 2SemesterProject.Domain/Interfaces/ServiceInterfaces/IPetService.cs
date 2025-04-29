using _2SemesterProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProject.Domain.Interfaces.ServiceInterfaces
{
	public interface IPetService
	{
		public Task<IEnumerable<Pet>> GetAllPetsAsync();
		public Pet GetPetById(int petId);
		public void UpdatePet(Pet pet);
		public void DeletePet(Pet pet);
        public string CreatePet(string petName, string petSpecies, DateTime petBirthday, int phoneNumber);
	}
}
