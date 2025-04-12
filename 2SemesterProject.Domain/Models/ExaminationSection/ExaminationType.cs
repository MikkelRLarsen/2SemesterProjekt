using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProject.Domain.Models.ExaminationSection
{
	public class ExaminationType
	{
		public int ExaminationTypeID { get; private set; }
		public string ExaminationTypeName { get; private set; }
		public int ExaminationTypeDuration { get; private set; } // Given in minuttes

		public List<Examination> Examination { get; }

		public ExaminationType(int examinationTypeID, string examinationTypeName, int examinationTypeDuration)
		{
			ExaminationTypeID = examinationTypeID;
			ExaminationTypeName = examinationTypeName;
			ExaminationTypeDuration = examinationTypeDuration;
		}
	}
}
