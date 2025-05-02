using _2SemesterProjekt.Domain.Models;

namespace _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces
{
	public interface IPetService
	{
        public Task CreatePetAsync(Pet pet);
		public bool CheckIfPetExists(Pet pet);
        public Task<IEnumerable<Pet>> GetAllPetsAsync();
        public Task UpdatePetASync(Pet pet);

        public Task<IEnumerable<Examination>> GetAllInactivesAsync();

    }
}
