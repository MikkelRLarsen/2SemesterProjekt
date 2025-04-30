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
        public void CreatePet(Pet pet);
        public bool CheckIfPetExists(Pet pet);
	}
}
