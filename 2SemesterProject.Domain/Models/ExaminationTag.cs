using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProject.Domain.Models
{
	public class ExaminationTag
	{
		public int ExaminationTagID { get; init; }
		public string DecriptionTag { get; private set; }
		public List<ExaminationType> ExaminationTypes { get; }

		public ExaminationTag(int examinationTagID, string decriptionTag)
		{
			ExaminationTagID = examinationTagID;
			DecriptionTag = decriptionTag;
		}
	}
}
