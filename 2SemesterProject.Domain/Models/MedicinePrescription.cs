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
	}
}
