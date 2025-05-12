using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Domain.Models
{
    // Model for exporting invoice
    public class Invoice
    {
        public int InvoiceID { get; init; }
        public string CustomerName { get; set; }
        public string PetName { get; set; }
        public string ExaminationDescription { get; set; }
        public string Date { get; set; }
        public string? CageBookingInfo { get; set; }
        public string TotalPrice { get; set; }

        // Static method to call from UI
        public static Invoice FromExamination(Examination examination)
        {
            string cageBookingInfo = string.Empty;

            if (examination.CageBooking != null)
            {
                // Sets CageBookingInfo if there is any
                cageBookingInfo = $"{examination.CageBooking.StartDate:dd-MM-yyyy} til {examination.CageBooking.EndDate:dd-MM-yyyy}";
            }

            return new Invoice
            {
                CustomerName = $"{examination.Pet.Customer.FirstName} {examination.Pet.Customer.LastName}",
                PetName = examination.Pet.Name,
                ExaminationDescription = examination.ExaminationType.Description,
                Date = examination.Date.ToString("dd-MM-yyyy"),
                CageBookingInfo = cageBookingInfo,
                // Fallback value is 0 if CageBooking doesn't exist on current pet
                TotalPrice = (examination.Price + (examination.CageBooking?.TotalPrice ?? 0)).ToString() 
            };
        }
    }
}
