using _2SemesterProjekt.Domain.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;

namespace _2SemesterProjekt.Domain.Models
{
    public class Examination
    {
        public int ExaminationID { get; private set; }
        public int PetID { get; private set; }
        public int EmployeeID { get; private set; }
        public int? MedicineID { get; private set; }
        public DateTime Date { get; private set; }
        public int ExaminationTypeID { get; private set; }
        public int? CageBookingID { get; private set; }
        public decimal Price { get; private set; }
        public Pet Pet { get; }
        public Employee Employee { get; }
        public ExaminationType ExaminationType { get; }
        public CageBooking CageBooking { get; }
        public Medicine? Medicine { get; }

        public Examination(int petID, int employeeID, DateTime date, int? medicineID, int examinationTypeID, decimal price, int? cageBookingID)
        {
            PetID = petID;
            EmployeeID = employeeID;
            MedicineID = medicineID;
            Date = date;
            ExaminationTypeID = examinationTypeID;
            Price = price;
            CageBookingID = cageBookingID;

            InformationValid();
        }
        /// <summary>
        /// Checks and validate Examination Object. 
        /// Check if PetID or EmployeeID is null or 0
        /// Checks if Price got more then 2 digits
        /// </summary>
        /// <returns></returns>
        protected void InformationValid()
        {
            if (PetID == 0 || PetID == null)
            {
                throw new ArgumentException("PetID was 0 or null");
            }

            if (EmployeeID == 0 || EmployeeID == null)
            {
                throw new ArgumentException("Employee was 0 or null");
            }

            if (ExaminationTypeID == 0 || ExaminationTypeID == null)
            {
                throw new ArgumentException("Employee was 0 or null");
            }

            if (CageBookingID <= 0)
            {
                throw new ArgumentException("CageBooking was 0 or null");
            }

            Validate_Double_More_Than_2_Digits();
        }

        /// <summary>
        /// Checks if Price got decimals
        /// Also checks if it contains decimals that it doesn't have more than 2 decimals
        /// </summary>
        /// <returns></returns>
        protected void Validate_Double_More_Than_2_Digits()
        {
            if (decimal.Round(Price, 2) != Price)
            {
                throw new ArgumentException("Price had to many digits");
            }
        }

        /// <summary>
        /// Checks if cagebooking is valid
        /// </summary>
        public void SetCageBookingID(int cageBookingID)
        {
            if (cageBookingID <= 0)
            {
                throw new ArgumentException("CageBooking was 0");
            }
            else
            {
                CageBookingID = cageBookingID;
            }
        }

        /// <summary>
        /// Validate examination and then upadate chosen examination to mirror given examination (This does NOT include ExaminationID)
        /// </summary>
        /// <param name="examination"></param>
        public void UpdateExamination(Examination examination)
        {
            examination.InformationValid();

			EmployeeID = examination.EmployeeID;
			MedicineID = examination.MedicineID;
			Date = examination.Date;
			ExaminationTypeID = examination.ExaminationTypeID;
			Price = examination.Price;
			CageBookingID = examination.CageBookingID;

		}
    }
}
