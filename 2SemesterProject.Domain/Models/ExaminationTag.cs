
namespace _2SemesterProjekt.Domain.Models
{
	public class ExaminationTag
	{
		public int ExaminationTagID { get; init; }
		public string DescriptionTag { get; private set; }
		public List<ExaminationType> ExaminationTypes { get; }

		public ExaminationTag(int examinationTagID, string descriptionTag)
		{
			ExaminationTagID = examinationTagID;
			DescriptionTag = descriptionTag;
		}
	}
}
