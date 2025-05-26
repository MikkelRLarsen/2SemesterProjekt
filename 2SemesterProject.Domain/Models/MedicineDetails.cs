using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Domain.Models
{
	public class MedicineDetails
	{
		public int MedicineDetailsID { get; init; }
		public int MedicineTypeID { get; private set; }
		public int MedicineFormatID { get; private set; }
		public int DoseAmount { get; private set; }
		public int Doses24Hours { get; private set; }
		public List<MedicinePrescription>? MedicinePrescriptions { get; }
		public MedicineType MedicineType { get; }
		public MedicineFormat MedicineFormat { get; }

		public MedicineDetails(int medicineDetailsID, int medicineTypeID, int medicineFormatID, int doseAmount, int doses24Hours)
		{
			MedicineDetailsID = medicineDetailsID;
			MedicineTypeID = medicineTypeID;
			MedicineFormatID = medicineFormatID;
			DoseAmount = doseAmount;
			Doses24Hours = doses24Hours;
		}
	}
}
