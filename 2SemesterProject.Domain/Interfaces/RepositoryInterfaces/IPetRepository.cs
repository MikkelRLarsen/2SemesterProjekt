using _2SemesterProjekt.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Domain.Interfaces.RepositoryInterfaces
{
	public interface IPetRepository
	{
		public Task<IEnumerable<Pet>> GetAllPetsAsync();
		public Pet GetPetById(int petId);
		public void UpdatePet(Pet pet);
		public void DeletePet(Pet pet);
		public void CreatPet(Pet pet);
	}
}
