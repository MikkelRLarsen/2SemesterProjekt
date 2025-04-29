using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Domain.Models
{
	public class Examination
	{
		public int ExaminationID { get; private set; }
		public int PetID { get; private set; }
		public int EmployeeID { get; private set; }
		public DateTime Date { get; private set; }
		public string Type { get; private set; }
		public double Price { get; private set; }
		public Pet Pet { get; }
		public Employee Employee { get; }

		public Examination(int petID, int employeeID, DateTime date, string type, double price)
		{
			PetID = petID;
			EmployeeID = employeeID;
			Date = date;
			Type = type;
			Price = price;

			if (InformationValid() == false)
			{
				throw new ArgumentException("Information for Examination was invalid");
			}
		}

		/// <summary>
		/// Checks and validate Examination Object. 
		/// Check if PetID or EmployeeID is null or 0
		/// Checks if Price got more then 2 digits
		/// </summary>
		/// <returns></returns>
		protected bool InformationValid()
		{
			if (PetID == 0 || PetID == null)
			{
				return false;
			}

			if (EmployeeID == 0 || EmployeeID == null)
			{
				return false;
			}

			if (ValidatePrice() != false)
			{
				return false;
			}

			return true;
		}

		/// <summary>
		/// Checks if Price got decimals
		/// Also checks if it contains decimals that it doesn't have more than 2 decimals
		/// </summary>
		/// <returns></returns>
		protected bool ValidatePrice()
		{
			string priceAsString = Price.ToString();

			if(!priceAsString.Contains(','))
			{
				return true;
			}

			string[] priceAsAStringArray = priceAsString.Split(',');

			if (priceAsAStringArray[1].Length <= 2)
			{
				return true;
			}

			return false;
		}
	}
}
