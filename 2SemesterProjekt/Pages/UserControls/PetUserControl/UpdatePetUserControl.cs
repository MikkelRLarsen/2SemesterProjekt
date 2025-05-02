using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProjekt.Domain.Models;
using _2SemesterProjekt.Pages.UserControls.UIModels;
using Microsoft.Extensions.DependencyInjection;

namespace _2SemesterProjekt.Pages.UserControls.PetUserControl
{
    public partial class UpdatePetUserControl : UserControl
    {
        private readonly IPetService _petService;
        private readonly ICustomerService _customerService;
        private readonly IEmployeeService _employeeService;
        private PetCard PetCard;

        public UpdatePetUserControl(PetCard petCard)
        {
            InitializeComponent();
            petBirthdaySelector.MaxDate = DateTime.Today;
            _petService = ServiceProviderSingleton.GetServiceProvider().GetService<IPetService>()!;
            _customerService = ServiceProviderSingleton.GetServiceProvider().GetService<ICustomerService>()!;
            _employeeService = ServiceProviderSingleton.GetServiceProvider().GetService<IEmployeeService>()!;
            PetCard = petCard;
        }

        private async void UpdatePetUserControl_Load(object sender, EventArgs e)
        {
            // Set ups PetCard
            petNameTextbox.Text = PetCard.Pet.Name;
            petSpeciesTextbox.Text = PetCard.Pet.Species;
            ownerPhoneNumberTextbox.Text = PetCard.Pet.Customer.PhoneNumber.ToString();
            petBirthdaySelector.Text = PetCard.Pet.Birthday.ToString();
            var veterinarians = await _employeeService.GetAllPetDoctorsAsync();

            if (PetCard.Pet.Employee == null) // If the pet doesn't have a primary vet
            {
                var dropDownItems = new List<object> { "Ikke valgt" }; // Not chosen at index 0
                dropDownItems.AddRange(veterinarians); // Vets being added to list, to being able to being selected
                comboBoxPrimaryVeterinarian.DataSource = dropDownItems;
            }
            else
            {
                comboBoxPrimaryVeterinarian.DataSource = VeterinarianListBuilder.GetVeterinariansWithPrimaryFirst(veterinarians, PetCard.Pet.EmployeeID);
            }

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
            this.Controls.Clear(); // Clear existing content
            this.Controls.Add(new PetPage()); // Load the new page
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

        private void petSpeciesTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Resets textbox after error message
            petSpeciesTextbox.ForeColor = SystemColors.WindowText;
            petSpeciesTextbox.BackColor = SystemColors.Window;
        }

        private async void updateButton_Click(object sender, EventArgs e)
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

            // Validate pet name input
            if (string.IsNullOrWhiteSpace(petSpeciesTextbox.Text))
            {
                petSpeciesTextbox.ForeColor = Color.White;
                petSpeciesTextbox.BackColor = Color.LightCoral;
                displayMessage += "Indtast en dyreart.\n";
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
                    PetCard.Pet.UpdatePetData(petNameTextbox.Text, petSpeciesTextbox.Text, petBirthdaySelector.Value, (comboBoxPrimaryVeterinarian.SelectedItem as Employee).EmployeeID);

                    if (_petService.CheckIfPetExists(PetCard.Pet)) // Error message if the pet already exists
                    {
                        displayMessage += "Kæledyret findes allerede i databasen.";
                    }
                    else //If not, the pet will be saved to the DB through the service and a success message will appear.
                    {
                        await _petService.UpdatePetASync(PetCard.Pet); // The newly instantiated Pet object gets added to the DB.
                        displayMessage += $"{PetCard.Pet.Name} er blevet ændret i systemet.";
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
