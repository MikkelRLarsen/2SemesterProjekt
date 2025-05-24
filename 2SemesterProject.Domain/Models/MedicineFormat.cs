using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Domain.Models
{
	public class MedicineFormat
	{
		public int MedicineFormatID { get; init; }
		public string Format { get; private set; }
		public List<MedicineDetails>? MedicineDetails { get; }

		public MedicineFormat(int medicineFormatID, string format)
		{
			MedicineFormatID = medicineFormatID;
			Format = format;
		}
	}
}
