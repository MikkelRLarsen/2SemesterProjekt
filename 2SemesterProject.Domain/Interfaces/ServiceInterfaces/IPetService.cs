using _2SemesterProjekt.Domain.Models;

namespace _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces
{
	public interface IPetService
	{
        public void CreatePet(Pet pet);
		public bool CheckIfPetExists(Pet pet);
	}
}
