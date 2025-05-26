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
using Microsoft.Extensions.DependencyInjection;

namespace _2SemesterProjekt.Pages.UserControls.PetUserControl
{
    public partial class FindPetPage : UserControl
    {
        private readonly IPetService _petService;
        public PetCard PetCard { get; set; }
        public List<PetCard> AllPetCards { get; set; } = new List<PetCard>();
        public FindPetPage()
        {
            InitializeComponent();
            _petService = ServiceProviderSingleton.GetServiceProvider().GetService<IPetService>()!;
        }

        private void FindPetPage_Load(object sender, EventArgs e)
        {
            Task.Run(() => FindAndSetAllPetsAsync()); // New thread calling the method below.
        }

        /// <summary>
        /// Loads all pets, making them ready for "Vis alle"-click. 
        /// </summary>
        private async void FindAndSetAllPetsAsync()
        {
            IEnumerable<Pet> allPets = await _petService.GetAllPetsAsync();

            foreach (var pet in allPets)
            {
                AllPetCards.Add(new PetCard(pet, PetCardType.WholePet));
            }

            findAllButton.Image = Properties.Resources.FindAllButton;
        }

        private void findAllButton_Click(object sender, EventArgs e)
        {
            // Wait cursor (hourglass)
            Cursor = Cursors.WaitCursor;
            findAllButton.Enabled = false;


            LoadAndShowPetCards(AllPetCards);

            // Wait cursor (pointer)
            Cursor = Cursors.Default;
            findAllButton.Enabled = true;
        }

        /// <summary>
        /// Responsible for adding the userControl PetCards to the petFlowPanel.
        /// </summary>
        /// <param name="customerCardsToBeLoaded"></param>
		public async void LoadAndShowPetCards(IEnumerable<PetCard> petCardsToBeLoaded)
        {
            flowPanel.Controls.Clear();
            flowPanel.Controls.AddRange(petCardsToBeLoaded.ToArray());
        }

        private async void SearchForPetByPhoneNumber(object sender, EventArgs e)
        {
            string displayMessage = string.Empty;

            // Validate phonenumber: only numbers and 8-digit long.
            if (!Int32.TryParse(textBoxCustomerPhoneNumberOrName.Text, out int phoneNumber) || textBoxCustomerPhoneNumberOrName.Text[0] == '0' || phoneNumber < 10000000 || phoneNumber > 99999999)
            {
                textBoxCustomerPhoneNumberOrName.ForeColor = Color.White;
                textBoxCustomerPhoneNumberOrName.BackColor = Color.LightCoral;
                displayMessage += "Telefonnummer skal være et helt 8-cifret tal.";
            }
            else if (AllPetCards.Any(p => p.Pet.Customer.PhoneNumber == phoneNumber) == false) // If phonenumber doesn't match any pets add errormessage
            {
                textBoxCustomerPhoneNumberOrName.ForeColor = Color.White;
                textBoxCustomerPhoneNumberOrName.BackColor = Color.LightCoral;
                displayMessage += "Kunden har ikke nogen kæledyr registreret";
            }

            // No errors in search - codes executes
            if (displayMessage == string.Empty)
            {
                // Finds all pets of the specific customer
                var customerPetCards = AllPetCards
                    .Where(pc => pc.Pet.Customer.PhoneNumber == phoneNumber)
                    .ToList();

                // Clear flowpanel and add the customers pets
                flowPanel.Controls.Clear();
                foreach (var pet in customerPetCards)
                {
                    flowPanel.Controls.AddRange(customerPetCards.ToArray());
                }
            }
            else // Throw error message in UI
            {
                MessageBox.Show(displayMessage, "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxCustomerPhoneNumberOrName_Click(object sender, EventArgs e)
        {
            if (textBoxCustomerPhoneNumberOrName.Text == "Søg på navn eller telefonnummer")
            {
                textBoxCustomerPhoneNumberOrName.Text = string.Empty;
                textBoxCustomerPhoneNumberOrName.ForeColor = SystemColors.WindowText;
            }
        }
    }
}
