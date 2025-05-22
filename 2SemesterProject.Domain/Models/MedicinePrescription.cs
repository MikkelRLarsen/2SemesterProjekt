using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Domain.Models
{
	public class MedicinePrescription
	{
		public int MedicinePrescriptionID { get; init; }
		public int ExaminationID { get; private set; }
		public int MedicineDetailsID { get; private set; }
		public int DoseDuration { get; private set; }
		public DateTime StartDate { get; private set; }

		public Examination Examination { get; }
		public MedicineDetails MedicineDetails { get; }

		public MedicinePrescription(int medicinePrescriptionID, int examinationID, int medicineDetailsID, int doseDuration, DateTime startDate)
		{
			MedicinePrescriptionID = medicinePrescriptionID;
			ExaminationID = examinationID;
			MedicineDetailsID = medicineDetailsID;
			DoseDuration = doseDuration;
			StartDate = startDate;
		}
	}
}
