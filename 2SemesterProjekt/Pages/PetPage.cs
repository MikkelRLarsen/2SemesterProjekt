using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using Microsoft.Extensions.DependencyInjection;
using _2SemesterProjekt.Services;
using _2SemesterProjekt.Pages.UserControls.PetUserControl;
using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProjekt.Domain.Models;

namespace _2SemesterProjekt.Pages
{
    public partial class PetPage : UserControl
    {
        private IPetService _petService;
        private ICustomerService _customerService;
        private IEnumerable<Pet> _listOfPets;
        private IExaminationService _examinationService;
        public PetCard PetCard { get; set; }

        public PetPage()
        {
            InitializeComponent();
            buttonFlowPanel.Controls.Add(new ButtonPanel("Find kæledyr", Color.MediumAquamarine, SearchForPetByPhoneNumber));
            buttonFlowPanel.Controls.Add(new ButtonPanel("Tilføj kæledyr", Color.MediumSeaGreen, ShowPetCreation));

            // Clicking the "Vis inaktiv liste"-button loads any inactive pets via method: "ShowInactivePets".
            buttonFlowPanel.Controls.Add(new ButtonPanel("Vis inaktiv liste", Color.MediumVioletRed, ShowInactivePets));

            buttonFlowPanel.Controls.Add(new ButtonPanel("Redigér kæledyr", Color.Goldenrod, ShowPetUpdate));

            _petService = ServiceProviderSingleton.GetServiceProvider().GetService<IPetService>()!;
            _examinationService = ServiceProviderSingleton.GetServiceProvider().GetService<IExaminationService>()!;

        }
        private void ShowPetCreation(object sender, EventArgs e)
        {
            var addPetControl = new AddPetUserControl(this);
            this.Controls.Add(addPetControl); // Load the new page
            addPetControl.BringToFront();
        }

        private void ShowPetUpdate(object sender, EventArgs e)
        {
            if (this.PetCard != null)
            {
                var updatePetControl = new UpdatePetUserControl(this.PetCard, this); // This = PetPage
                this.Controls.Add(updatePetControl); // Load the new page
                updatePetControl.BringToFront();
            }
            else
            {
                MessageBox.Show("Vælg et kæledyr hvis du vil ændre det", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void PetPage_Load(object sender, EventArgs e)
        {
            textBoxCustomerPhoneNumber.Text = "Find kæledyr via tlf.";
            _listOfPets = await _petService.GetAllPetsAsync();
            foreach (var pet in _listOfPets)
            {
                flowLayoutPanel1.Controls.Add(new PetCard(this, pet, PetCardType.WholePet));
            }
        }

        private async void SearchForPetByPhoneNumber(object sender, EventArgs e)
        {
            string displayMessage = string.Empty;

            // Validate phonenumber: only numbers and 8-digit long.
            if (!Int32.TryParse(textBoxCustomerPhoneNumber.Text, out int phoneNumber) || textBoxCustomerPhoneNumber.Text[0] == '0' || phoneNumber < 10000000 || phoneNumber > 99999999)
            {
                textBoxCustomerPhoneNumber.ForeColor = Color.White;
                textBoxCustomerPhoneNumber.BackColor = Color.LightCoral;
                displayMessage += "Telefonnummer skal være et helt 8-cifret tal.";
            }
            else if (_listOfPets.Any(p => p.Customer.PhoneNumber == phoneNumber) == false) // If phonenumber doesn't match any pets add errormessage
            {
                textBoxCustomerPhoneNumber.ForeColor = Color.White;
                textBoxCustomerPhoneNumber.BackColor = Color.LightCoral;
                displayMessage += "Kunden har ikke nogen kæledyr registreret";
            }

            // No errors in search - codes executes
            if (displayMessage == string.Empty)
            {
                // Finds all pets of the specific customer
                var customerPets = _listOfPets.Where(p => p.Customer.PhoneNumber == phoneNumber).ToList();

                // Clear flowpanel and add the customers pets
                flowLayoutPanel1.Controls.Clear();
                foreach (var pet in customerPets)
                {
                    flowLayoutPanel1.Controls.Add(new PetCard(this, pet, PetCardType.WholePet));
                }

                // Checks if the button already exists before adding
                if (!buttonFlowPanel.Controls.OfType<ButtonPanel>().Any(b => b.Text == "Vis alle kæledyr"))
                {
                    // Add option for resetting the flowpanel
                    buttonFlowPanel.Controls.Add(new ButtonPanel("Vis alle kæledyr", Color.MediumVioletRed, ShowAllPets));
                }
            }
            else // Throw error message in UI
            {
                MessageBox.Show(displayMessage, "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Shows all pets in flowpanel.
        /// Enabled after showing specific customer pets.
        /// </summary>
        private async void ShowAllPets(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            // Finds and removes the button by its text
            ButtonPanel control = buttonFlowPanel.Controls
                .OfType<ButtonPanel>()
                .First(c => c.ButtonText.Text == "Vis alle kæledyr");

            if (control != null)
            {
                buttonFlowPanel.Controls.Remove(control);
            }

            // Resets the inputbox
            textBoxCustomerPhoneNumber.Text = "Find kæledyr via tlf.";

            // Show all pets in flowpanel
            foreach (var pet in _listOfPets)
            {
                flowLayoutPanel1.Controls.Add(new PetCard(this, pet, PetCardType.WholePet));
            }
        }
        private async void ShowInactivePets(object sender, EventArgs e)
        {
            // Clears the panel of potential existing content.
            flowLayoutPanel1.Controls.Clear();

            // If any, loads the inactive-pet-information onto PetCard.
            try
            {
                var listOfPets = await _examinationService.GetAllInactivesAsync();
                foreach (var examination in listOfPets)
                {
                    flowLayoutPanel1.Controls.Add(new PetCard(this, examination, PetCardType.InactivePet));
                }

                // Checks if the button already exists before adding
                if (!buttonFlowPanel.Controls.OfType<ButtonPanel>().Any(b => b.Text == "Vis alle kæledyr"))
                {
                    // Add option for resetting the flowpanel
                    buttonFlowPanel.Controls.Add(new ButtonPanel("Vis alle kæledyr", Color.MediumVioletRed, ShowAllPets));
                }
            }
            catch
            {
                MessageBox.Show("Der findes ingen inaktive kæledyr.");
            }
        }

        private void textBoxCustomerPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            // Resets textbox after error message
            textBoxCustomerPhoneNumber.ForeColor = SystemColors.WindowText;
            textBoxCustomerPhoneNumber.BackColor = SystemColors.Window;
        }

        /// <summary>
        /// Event for user to show the textbox is enabled for input
        /// </summary>
        private void textBoxCustomerPhoneNumber_Click(object sender, EventArgs e)
        {
            if (textBoxCustomerPhoneNumber.Text == "Find kæledyr via tlf.")
            {
                textBoxCustomerPhoneNumber.Text = string.Empty;
                textBoxCustomerPhoneNumber.ForeColor = SystemColors.WindowText;
            }
        }

        public async void RefreshPetList()
        {
            _listOfPets = await _petService.GetAllPetsAsync();
            flowLayoutPanel1.Controls.Clear();
            foreach (var pet in _listOfPets)
            {
                // This = PetPage
                flowLayoutPanel1.Controls.Add(new PetCard(this, pet, PetCardType.WholePet));
            }
        }
    }
}
