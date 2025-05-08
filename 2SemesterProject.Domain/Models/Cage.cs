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
        public string Species { get; private set; }
        public decimal Price { get; private set; }
        public List<CageBooking> Bookings { get; }

        public Cage(int cageID, string species, decimal price)
        {
            CageID = cageID;
            Species = species;
            Price = price;
        }
    }
}
