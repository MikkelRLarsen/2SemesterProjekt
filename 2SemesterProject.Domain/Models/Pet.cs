namespace _2SemesterProjekt.Domain.Models
{
    public class Pet
    {
        public int PetID { get; init; }
        public int CustomerID { get; protected set; }
        public int? EmployeeID { get; protected set; }
        public int SpeciesID { get; protected set; }
        public string Name { get; protected set; }
        public DateTime Birthday { get; protected set; }

        public Customer Customer { get; }
        public Employee? Employee { get; }
        public Species Species { get; }
        public List<Examination> Examinations { get; }

        public Pet(int customerID, string name, int speciesID, DateTime birthday, int? employeeID)
        {
            CustomerID = customerID;
            Name = name;
            SpeciesID = speciesID;
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
            else if (string.IsNullOrWhiteSpace(Name)) // Invalid if Name is empty
            {
                return false;
            }
            else if (Birthday == null) // Invalid if Birthday is null
            {
                return false;
            }
            else if (SpeciesID == 0) // Invalid if speciesID is 0
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
        public void UpdatePetData(string newPetName, int speciesID, DateTime birthday, int? employeeID)
        {
            if (string.IsNullOrWhiteSpace(newPetName) == false)
            {
                Name = newPetName;
            }

            if (SpeciesID != 0)
            {
                SpeciesID = speciesID;
            }

            Birthday = birthday;
            EmployeeID = employeeID;
        }
    }
}
