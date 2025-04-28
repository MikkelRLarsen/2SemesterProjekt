using _2SemesterProjekt.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces
{
	public interface IPetService
	{
		public Task<IEnumerable<Pet>> GetAllPetsAsync();
		public Pet GetPetById(int petId);
		public void UpdatePet(Pet pet);
		public void DeletePet(Pet pet);
		public Task<IEnumerable<Pet>> GetAllPetsFromCustomerIDAsync(int customerID);
		public string CreatePet(Pet pet, int ownerPhoneNumber);

	}
}
