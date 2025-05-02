using _2SemesterProjekt.Domain.Models;

namespace _2SemesterProjekt.Domain.Interfaces.RepositoryInterfaces
{
	public interface IPetRepository
	{
        public Task CreatePetAsync(Pet pet);
        public bool CheckIfPetExists(Pet pet);
        public Task<IEnumerable<Pet>> GetAllPetsAsync();
        public Task UpdatePetAsync(Pet pet);
    }
}
