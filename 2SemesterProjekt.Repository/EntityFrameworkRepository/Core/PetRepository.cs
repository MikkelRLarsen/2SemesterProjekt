using _2SemesterProject.Domain.Interfaces.RepositoryInterfaces.Core;
using _2SemesterProject.Domain.Models.Core.Pets;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Repository.EntityFrameworkRepository.Core
{
	public class PetRepository : IPetRepository
	{
		private readonly EntityFrameworkRepositoryCore _dbContext = new EntityFrameworkRepositoryCore();

		public void CreatPet(Pet pet)
		{
			_dbContext.Pets.Add(pet);
			_dbContext.SaveChanges();
		}

		public void DeletePet(Pet pet)
		{
			_dbContext.Pets.Remove(pet);
			_dbContext.SaveChanges();
		}

		public async Task<IEnumerable<Pet>> GetAllPetsAsync()
		{
			return await _dbContext.Pets
				.Include(p => p.Customer)
				.Include(p => p.Examinations)
				.ThenInclude(e => e.ExaminationType)
				.ToListAsync(); 
		}

		public Pet GetCustomerById(int petId)
		{
			return _dbContext.Pets
				.Where(p => p.PetID == petId)
				.First();
		}

		public void UpdatePet(Pet pet)
		{
			_dbContext.Pets.Update(pet);
			_dbContext.SaveChanges();
		}
	}
}
