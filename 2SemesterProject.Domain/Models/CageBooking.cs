using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2SemesterProjekt.Domain.Models;

namespace _2SemesterProjekt.Domain.Models
{
    public class CageBooking
    {
        public int CageBookingID { get; init; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public decimal TotalPrice { get; private set; }
        public Examination Examination { get; }
        public Cage Cage { get; }

        public CageBooking(DateTime startDate, DateTime endDate, decimal totalPrice)
        {
            StartDate = startDate;
            EndDate = endDate;
            TotalPrice = totalPrice;
        }
    }
}
