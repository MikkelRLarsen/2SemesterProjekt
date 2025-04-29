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
		public decimal Price { get; private set; }
		public Pet Pet { get; }
		public Employee Employee { get; }

		public Examination(int petID, int employeeID, DateTime date, string type, decimal price)
		{
			PetID = petID;
			EmployeeID = employeeID;
			Date = date;
			Type = type;
			Price = price;

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

			Validate_Double_More_Than_2_Digits();
		}

		/// <summary>
		/// Checks if Price got decimals
		/// Also checks if it contains decimals that it doesn't have more than 2 decimals
		/// </summary>
		/// <returns></returns>
		protected bool Validate_Double_More_Than_2_Digits()
		{
			try
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
			catch (Exception)
			{
				throw new ArgumentException("Price had to many digits");
			}
		}
	}
}
