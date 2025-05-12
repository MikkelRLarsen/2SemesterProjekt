using _2SemesterProjekt.Domain.Models;
using Microsoft.Extensions.DependencyInjection;
using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using System.Threading.Tasks;
using _2SemesterProjekt.Pages.UserControls.PetUserControl;

namespace _2SemesterProjekt.Pages
{
    public partial class AddPetUserControl : UserControl
    {
        private readonly IPetService _petService;
        private readonly ICustomerService _customerService;
        private readonly IEmployeeService _employeeService;
        public AddPetUserControl()
        {
            InitializeComponent();
            petBirthdaySelector.MaxDate = DateTime.Today;
            _petService = ServiceProviderSingleton.GetServiceProvider().GetService<IPetService>()!;
            _customerService = ServiceProviderSingleton.GetServiceProvider().GetService<ICustomerService>()!;
            _employeeService = ServiceProviderSingleton.GetServiceProvider().GetService<IEmployeeService>()!;
        }

        private async void AddPetPage_Load(object sender, EventArgs e)
        {
            // Species dropdown load
            var petSpecies = await _petService.GetAllPetSpeciesAsync();
            comboBoxSpecies.DataSource = petSpecies;
            comboBoxSpecies.DisplayMember = "Name";

            // Veterinarians dropdown load
            var dropDownItems = new List<object> { "Ikke valgt" }; // Add not chosen option
            var veterinarians = await _employeeService.GetAllPetDoctorsAsync();

            dropDownItems.AddRange(veterinarians);

            comboBoxPrimaryVeterinarian.DataSource = dropDownItems;
            comboBoxPrimaryVeterinarian.DisplayMember = "FirstName";

            comboBoxPrimaryVeterinarian.Format += ComboBoxPrimaryVeterinarian_Format!;
        }

        /// <summary>
        /// Goes through the list and displays employees first names
        /// </summary>
        private void ComboBoxPrimaryVeterinarian_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem is Employee employee) // Show first name if hit is employee
            {
                e.Value = employee.FirstName;
            }
            else // Make the item to a string
            {
                e.Value = e.ListItem!.ToString();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
			if (this.Parent != null)
			{
				this.Parent.Controls.Remove(this); // Clear existing content (Parent is PetPage)
			}
		}

        private void ownerPhoneNumberTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // The user is only able to enter numbers in the textbox.
            }
            // Resets textbox after error message
            ownerPhoneNumberTextbox.ForeColor = SystemColors.WindowText;
            ownerPhoneNumberTextbox.BackColor = SystemColors.Window;
        }

        private void petNameTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Resets textbox after error message
            petNameTextbox.ForeColor = SystemColors.WindowText;
            petNameTextbox.BackColor = SystemColors.Window;
        }

        private async void createButton_Click(object sender, EventArgs e)
        {
            string displayMessage = string.Empty;

            // Validate phonenumber: only numbers and 8-digit long.
            if (!Int32.TryParse(ownerPhoneNumberTextbox.Text, out int phoneNumber) || ownerPhoneNumberTextbox.Text[0] == '0' || phoneNumber < 10000000 || phoneNumber > 99999999)
            {
                ownerPhoneNumberTextbox.ForeColor = Color.White;
                ownerPhoneNumberTextbox.BackColor = Color.LightCoral;
                displayMessage += "Telefonnummer skal være et helt 8-cifret tal.\n";
            }

            // Validate pet name input
            if (string.IsNullOrWhiteSpace(petNameTextbox.Text))
            {
                petNameTextbox.ForeColor = Color.White;
                petNameTextbox.BackColor = Color.LightCoral;
                displayMessage += "Indtast et gyldigt kæledyrsnavn.\n";
            }

            int customerId = _customerService.GetCustomerIDByPhoneNumber(phoneNumber); // Retrieves the customer's ID by using the entered phone number.

            if (customerId == 0) // Customer ID validation
            {
                ownerPhoneNumberTextbox.ForeColor = Color.White;
                ownerPhoneNumberTextbox.BackColor = Color.LightCoral;
                displayMessage += "Kunden med dette telefonnummer findes ikke i systemet.";
            }

            var selectedVet = comboBoxPrimaryVeterinarian.SelectedItem as Employee;

            if (displayMessage == string.Empty)
            {
                try
                {
                    var pet = new Pet(
                        customerId,
                        petNameTextbox.Text,
                        (comboBoxSpecies.SelectedValue as Species).SpeciesID,
                        petBirthdaySelector.Value,
                        selectedVet?.EmployeeID
                    ); /* Instantiating a Pet object with
                      the retrieved customer ID and the
                      text inside the textboxes.*/

                    if (_petService.CheckIfPetExists(pet)) // Error message if the pet already exists
                    {
                        displayMessage += "Kæledyret findes allerede i databasen.";
                    }
                    else //If not, the pet will be saved to the DB through the service and a success message will appear.
                    {
                        await _petService.CreatePetAsync(pet); // The newly instantiated Pet object gets added to the DB.
                        displayMessage += $"{pet.Name} er blevet tilføjet til systemet.";
                    }
                }
                catch (Exception ex)
                {
                    displayMessage += $"{ex}";
                }
            }

            MessageBox.Show(displayMessage, "Information", MessageBoxButtons.OK);
        }
    }
}
