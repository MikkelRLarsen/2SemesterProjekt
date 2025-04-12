using _2SemesterProject.Domain.Models.Core.Pets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProject.Domain.Models.ExaminationSection
{
	public class Examination
	{
		public int ExaminationID { get; private set; }
		public int PetID { get; private set; }
		public int ExaminationTypeID { get; private set; }
		public DateTime ExaminationDate { get; private set; }
		public DateTime ExaminationBookingDate { get; private set; }

		public Pet Pet { get; }
		public ExaminationType ExaminationType { get; }

		public Examination(int examinationID, int petID, int examinationTypeID, DateTime examinationDate, DateTime examinationBookingDate)
		{
			ExaminationID = examinationID;
			PetID = petID;
			ExaminationTypeID = examinationTypeID;
			ExaminationDate = examinationDate;
			ExaminationBookingDate = examinationBookingDate;
		}
	}
}
