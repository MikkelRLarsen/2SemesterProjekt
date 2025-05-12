using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Domain.Models
{
    // Model for exporting invoice
    public class Invoice
    {
        public int InvoiceID { get; init; }
        public string CustomerName { get; private set; }
        public string PetName { get; private set; }
        public string ExaminationDescription { get; private set; }
        public string Date { get; private set; }
        public string? CageBookingInfo { get; private set; }
        public string TotalPrice { get; private set; }

        public Invoice(string customerName, string petName, string examinationDescription, string date, string? cageBookingInfo, string totalPrice)
        {
            CustomerName = customerName;
            PetName = petName;
            ExaminationDescription = examinationDescription;
            Date = date;
            CageBookingInfo = cageBookingInfo;
            TotalPrice = totalPrice;

            InformationValid();
        }

        // Static method to call from UI
        public static Invoice FromExamination(Examination examination)
        {
            string cageBookingInfo = string.Empty;

            if (examination.CageBooking != null)
            {
                // Sets CageBookingInfo if there is any
                cageBookingInfo = $"{examination.CageBooking.StartDate:dd-MM-yyyy} til {examination.CageBooking.EndDate:dd-MM-yyyy}";
            }

            var invoice = new Invoice(
                $"{examination.Pet.Customer.FirstName} {examination.Pet.Customer.LastName}",
                examination.Pet.Name,
                examination.ExaminationType.Description,
                examination.Date.ToString("dd-MM-yyyy"),
                cageBookingInfo,
                // Fallback value is 0 if CageBooking doesn't exist on current pet
                (examination.Price + (examination.CageBooking?.TotalPrice ?? 0)).ToString() 
            );

            invoice.InformationValid();

            return invoice;
        }

        protected void InformationValid()
        {
            // Customername check
            if (string.IsNullOrWhiteSpace(CustomerName))
            {
                throw new ArgumentException("Customer name is required.");
            }

            // Petname check
            if (string.IsNullOrWhiteSpace(PetName))
            {
                throw new ArgumentException("Pet name is required.");
            }

            // Description check
            if (string.IsNullOrWhiteSpace(ExaminationDescription))
            {
                throw new ArgumentException("Examination description is required.");
            }

            // Date check
            if (string.IsNullOrWhiteSpace(Date))
            {
                throw new ArgumentException("Date is required.");
            }

            // Totalprice check
            if (string.IsNullOrWhiteSpace(TotalPrice))
            {
                throw new ArgumentException("Total price is required.");
            }
        }
    }
}
