using _2SemesterProject.Domain.Models.Core.Pets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.DTO
{
	public class PetDTO
	{
		public PetDTO() { }

		public PetDTO(Pet pet) 
		{
			PetID = pet.PetID;
			CustomerID = pet.CustomerID;
			PetName = pet.PetName;
			PetSpecies = pet.PetSpecies;
		}


		public int PetID { get; protected set; }
		public int CustomerID { get; protected set; }
		public string PetName { get; protected set; }
		public string PetSpecies { get; protected set; }
	}
}
