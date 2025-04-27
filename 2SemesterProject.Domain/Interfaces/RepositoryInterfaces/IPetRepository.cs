using _2SemesterProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProject.Domain.Interfaces.RepositoryInterfaces
{
	public interface IPetRepository
	{
		public Task<IEnumerable<Pet>> GetAllPetsAsync();
		public Pet GetPetById(int petId);
		public void UpdatePet(Pet pet);
		public void DeletePet(Pet pet);
		public void CreatePet(Pet pet);
	}
}
