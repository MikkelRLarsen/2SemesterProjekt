using _2SemesterProjekt.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProject.Domain.Interfaces.ServiceInterfaces
{
	public interface IPetService
	{
        public Task CreatePetAsync(Pet pet);
		public bool CheckIfPetExists(Pet pet);
        public Task<IEnumerable<Pet>> GetAllPetsAsync();
        public Task UpdatePetASync(Pet pet);
    }
}
