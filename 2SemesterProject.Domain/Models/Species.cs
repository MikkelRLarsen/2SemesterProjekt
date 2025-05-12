using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Domain.Models
{
    public class Species
    {
        public int SpeciesID { get; protected set; }
        public string Name { get; protected set; }

        public Species(int speciesID, string name)
        {
            SpeciesID = speciesID;
            Name = name;
        }
    }
}
