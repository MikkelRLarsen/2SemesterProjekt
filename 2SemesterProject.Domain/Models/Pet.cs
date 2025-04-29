using _2SemesterProject.Domain.Interfaces.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProject.Domain.Models
{
	public class Pet
	{
		public int PetID { get; init; }
		public int CustomerID { get; protected set; }
		public string Name { get; protected set; }
		public string Species { get; protected set; }
		public DateTime	Birthday { get; protected set; }

		public Customer Customer { get; }
		public List<Examination> Examinations { get; }

		public Pet(int petID, int customerID, string name, string species, DateTime birthday)
		{
			PetID = petID;
			CustomerID = customerID;
			Name = name;
			Species = species;
			Birthday = birthday;
		}
        public Pet(int customerID, string name, string species, DateTime birthday)
        {
            CustomerID = customerID;
            Name = name;
            Species = species;
            Birthday = birthday;
        }
		public string ValidateInformation()
		{
            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Species))
            {
                return "Udfyld venligst navn og/eller art!";
            }
            else
            {
                Pet pet = new Pet(ownerId, petName, petSpecies, petBirthday);
                bool petExists = _petRepository.CheckIfPetExists(pet);
                if (petExists)
                {
                    return "Kæledyret findes allerede i databasen.";
                }
                else
                {
                    CreatePet(pet);
                    return $"{pet.Name} er blevet tilføjet til systemet.";
                }
            }
        }
    }
}
