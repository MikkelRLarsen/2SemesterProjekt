using _2SemesterProjekt.Domain.Models;

namespace _2SemesterProjekt.Domain.Interfaces.RepositoryInterfaces
{
	public interface IPetRepository
	{
        public void CreatePet(Pet pet);
        public bool CheckIfPetExists(Pet pet);
	}
}
