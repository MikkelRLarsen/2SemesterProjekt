namespace _2SemesterProjekt.Domain.Models
{
	public class Employee
	{
		public int EmployeeID { get; private set; }
		public string FirstName { get; private set; }
		public string LastName { get; private set; }
		public string Type { get; private set; }
		public List<Pet>? Pets { get; }
		public List<Examination>? Examinations { get; }

		public Employee(string firstName, string lastName, string type)
		{
			FirstName = firstName;
			LastName = lastName;
			Type = type;

			InformationValid();
		}

		protected void InformationValid()
		{
			if (FirstName.Any(ch => !char.IsLetterOrDigit(ch)))
			{
				throw new ArgumentException("FirstName indeholder tal eller speciel tegn");
			}

			if (LastName.Any(ch => !char.IsLetterOrDigit(ch)))
			{
				throw new ArgumentException("LastName indeholder tal eller speciel tegn");
			}

			if (Type != "Dyrelæge" && Type != "Assistent" && Type != "Receptionist")
			{
				throw new ArgumentException("Type var ikke en af de foruddefineret roller");
			}
		}
	}
}
