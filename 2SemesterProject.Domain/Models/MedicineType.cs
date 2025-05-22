using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Domain.Models
{
	public class MedicineType 
	{
		public int MedicineTypeID { get; init; }
		public string Name { get; private set; }
		public string Type { get; private set; }
		public List<MedicineDetails>? MedicineDetails { get; }
	}
}
