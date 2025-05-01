using _2SemesterProjekt.Domain.Models;

namespace _2SemesterProjekt.Domain.Models
{
	public class ExaminationType
	{
		public int ExaminationTypeID { get; init; }
		public string Description { get; private set; }
		public int ExaminationTagID { get; private set;}
		public decimal BasePrice { get; private set; }
		public ExaminationTag ExaminationTag { get;}
		public List<Examination> Examinations { get;}

		public ExaminationType(int examinationTypeID, string description, int examinationTagID, decimal basePrice)
		{
			ExaminationTypeID = examinationTypeID;
			Description = description;
			ExaminationTagID = examinationTagID;
			BasePrice = basePrice;
		}
	}
}
