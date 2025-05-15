using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Domain.Models
{
    public class Cage
    {
        public int CageID { get; init; }
        public int SpeciesID { get; private set; }
        public decimal Price { get; private set; }
        public Species Species { get; }
        public List<CageBooking> Bookings { get; }

        public Cage(int cageID, int speciesID, decimal price)
        {
            CageID = cageID;
            SpeciesID = speciesID;
            Price = price;
        }
    }
}
