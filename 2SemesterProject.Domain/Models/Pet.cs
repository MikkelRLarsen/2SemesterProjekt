namespace _2SemesterProjekt.Domain.Models
{
    public class Pet
    {
        public int PetID { get; init; }
        public int CustomerID { get; protected set; }
        public int? EmployeeID { get; protected set; }
        public string Name { get; protected set; }
        public string Species { get; protected set; }
        public DateTime Birthday { get; protected set; }

        public Customer Customer { get; }
        public Employee? Employee { get; }
        public List<Examination> Examinations { get; }

        public Pet(int customerID, string name, string species, DateTime birthday, int? employeeID)
        {
            CustomerID = customerID;
            Name = name;
            Species = species;
            Birthday = birthday;
            EmployeeID = employeeID;

            if (ValidateInformation() == false)
            {
                throw new ArgumentException("Invalid pet data.");
            }
        }

        public bool ValidateInformation()
        {
            if (CustomerID == 0) // Invalid if customerID is 0
            {
                return false;
            }
            else if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Species)) // Invalid if Name or Species is empty
            {
                return false;
            }
            else if (Birthday == null) // Invalid if Birthday is null
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Validate pet name input
        /// </summary>
        /// <param name="newPetName"></param>
        public void UpdatePetData(string newPetName, string species, DateTime birthday, int? employeeID)
        {
            if (string.IsNullOrWhiteSpace(newPetName) == false || string.IsNullOrWhiteSpace(species) == false)
            {
                Name = newPetName;
                Species = species;
            }

            Birthday = birthday;
            EmployeeID = employeeID;
        }
    }
}
