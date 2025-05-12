using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using _2SemesterProjekt.Domain.Models;

namespace _2SemesterProjekt.Domain.Models
{
    public class CageBooking
    {
        public int CageBookingID { get; init; }
        public int CageID { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public decimal TotalPrice { get; private set; }
        public Examination Examination { get; }
        public Cage Cage { get; }

        public CageBooking(DateTime startDate, DateTime endDate, decimal totalPrice, int cageID)
        {
            StartDate = startDate;
            EndDate = endDate;
            TotalPrice = totalPrice;
            CageID = cageID;

            InformationValid();
        }

        /// <summary>
		/// Acceptcriteria:
		/// StartDate can't be before today
        /// Decimal
		/// <returns>Bool</returns>
		protected void InformationValid()
        {
            ValidateTotalPrice();

            if (CageID <= 0)
            {
                throw new ArgumentException("Cage was 0 or null");
            }
        }

        /// <summary>
        /// Checks if Price got decimals
        /// Also checks if it contains decimals that it doesn't have more than 2 decimals
        /// </summary>
        /// <returns></returns>
        protected void ValidateTotalPrice()
        {
            if (decimal.Round(TotalPrice, 2) != TotalPrice)
            {
                throw new ArgumentException("Price had to many digits");
            }
        }
    }
}
