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
        private readonly ChangePetPage _changePage;
        private readonly PetCard _petCard;

        public UpdatePetUserControl(PetCard petCard, ChangePetPage changePage)
        {
            InitializeComponent();
            petBirthdaySelector.MaxDate = DateTime.Today;
            _petService = ServiceProviderSingleton.GetServiceProvider().GetService<IPetService>()!;
            _customerService = ServiceProviderSingleton.GetServiceProvider().GetService<ICustomerService>()!;
            _employeeService = ServiceProviderSingleton.GetServiceProvider().GetService<IEmployeeService>()!;
            _petCard = petCard;
            _changePage = changePage;
        }

        private async void UpdatePetUserControl_Load(object sender, EventArgs e)
        {
            // Set ups PetCard
            petNameTextbox.Text = _petCard.Pet.Name;
            ownerPhoneNumberTextbox.Text = _petCard.Pet.Customer.PhoneNumber.ToString();
            petBirthdaySelector.Text = _petCard.Pet.Birthday.ToString();
            var veterinarians = await _employeeService.GetAllEmployeeWithTypeAsync("Dyrlæge");
            var petSpecies = await _petService.GetAllPetSpeciesAsync();

            comboBoxPetSpecies.DataSource = ListBuilder.GetSpeciesWithCurrentFirst(petSpecies, _petCard.Pet.SpeciesID);
            comboBoxPetSpecies.DisplayMember = "Name";

            if (_petCard.Pet.Employee == null) // If the pet doesn't have a primary vet
            {
                var dropDownItems = new List<object> { "Ikke valgt" }; // Not chosen at index 0
                dropDownItems.AddRange(veterinarians); // Vets being added to list, to being able to being selected
                comboBoxPrimaryVeterinarian.DataSource = dropDownItems;
            }
            else
            {
                comboBoxPrimaryVeterinarian.DataSource = ListBuilder.GetVeterinariansWithPrimaryFirst(veterinarians, _petCard.Pet.EmployeeID);
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

			int customerId;
			try
			{
				customerId = (await _customerService.GetCustomerByPhoneNumberAsync(phoneNumber)).CustomerID; // Retrieves the customer's ID by using the entered phone number.
			}
			catch (Exception)
			{

				ownerPhoneNumberTextbox.ForeColor = Color.White;
				ownerPhoneNumberTextbox.BackColor = Color.LightCoral;
				displayMessage += "Kunden med dette telefonnummer findes ikke i systemet.";
				customerId = 0; //Place holder value
			}

			var selectedVet = comboBoxPrimaryVeterinarian.SelectedItem as Employee;

            if (displayMessage == string.Empty)
            {
                try
                {
                    _petCard.Pet.UpdatePetData(
                        petNameTextbox.Text,
                        (comboBoxPetSpecies.SelectedItem as Species).SpeciesID,
                        petBirthdaySelector.Value,
                        (comboBoxPrimaryVeterinarian.SelectedItem as Employee).EmployeeID
                    );

                    await _petService.UpdatePetASync(_petCard.Pet); // The newly instantiated Pet object gets added to the DB.
                    displayMessage += $"{_petCard.Pet.Name} er blevet ændret i systemet.";

                    int index = _changePage.AllPetCards.FindIndex(petCard => petCard.Pet.PetID == _petCard.Pet.PetID);

                    // Replaces ExaminationCard with a new one with the updated information
                    _changePage.AllPetCards[index] = new PetCard(_changePage, _petCard.Pet, PetCardType.WholePet);

                    // Set the selected ExaminationCard to null, so its no longer highligted
                    _changePage.PetCard = null;

                    _changePage.LoadAndShowPetCards(_changePage.AllPetCards);

                    this.Parent!.Controls.Remove(this); // Clear existing content (Parent is PetPage)
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
