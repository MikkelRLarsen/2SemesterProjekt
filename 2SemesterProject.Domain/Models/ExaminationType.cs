using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProject.Domain.Models
{
	public class ExaminationType
	{
		public int ExaminationTypeID { get; init; }
		public string Description { get; private set; }
		public int ExaminationTagID { get; private set;}
		public ExaminationTag ExaminationTag { get;}

		public ExaminationType(int examinationTypeID, string description, int examinationTagID)
		{
			ExaminationTypeID = examinationTypeID;
			Description = description;
			ExaminationTagID = examinationTagID;
		}
	}
}
