using _2SemesterProject.Domain.Models.Core.Pets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProject.Domain.Interfaces.RepositoryInterfaces.Core
{
	public interface IPetRepository
	{
		public Task<IEnumerable<Pet>> GetAllPetsAsync();
		public Pet GetCustomerById(int petId);
		public void UpdatePet(Pet pet);
		public void DeletePet(Pet pet);
		public void CreatPet(Pet pet);
	}
}
