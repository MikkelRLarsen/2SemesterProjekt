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
using _2SemesterProjekt.Pages.UserControls.CustomerUserControl;
using Microsoft.Extensions.DependencyInjection;

namespace _2SemesterProjekt.Pages.UserControls.PetUserControl
{
    public partial class ChangePetPage : UserControl
    {
        private readonly IPetService _petService;
        private readonly Panel _mainPanel;
        public PetCard PetCard { get; set; }
        public List<PetCard> AllPetCards { get; set; } = new List<PetCard>();

        public ChangePetPage(Panel mainPanel)
        {
            InitializeComponent();
            _petService = ServiceProviderSingleton.GetServiceProvider().GetService<IPetService>()!;
            _mainPanel = mainPanel;
        }

        private void ChangePetPage_Load(object sender, EventArgs e)
        {
            Task.Run(() => FindAndSetAllPetsAsync()); // New thread calling the method below.
        }

        /// <summary>
        /// Loads all customers on customerPage click, making them ready for "Vis alle"-click. 
        /// </summary>
        private async void FindAndSetAllPetsAsync()
        {
            IEnumerable<Pet> allPets = await _petService.GetAllPetsAsync();

            foreach (var pet in allPets)
            {
                AllPetCards.Add(new PetCard(this, pet, PetCardType.WholePet));
            }

            findAllButton.Image = Properties.Resources.FindAllButton;
        }

        private void findAllButton_Click(object sender, EventArgs e)
        {
            if (textBoxPetByOwnerPhoneNumberOrPetName.Text == "Søg på kæledyr eller telefonnummer" || string.IsNullOrEmpty(textBoxPetByOwnerPhoneNumberOrPetName.Text))
            {
                LoadAndShowPetCards(AllPetCards);
            }
            else
            {
                ShowPetByOwnerPhoneNumberOrName();
            }
        }

        /// <summary>
        /// Responsible for adding the userControl CustomerCards to the customerFlowPanel.
        /// </summary>
        /// <param name="petCardsToBeLoaded"></param>
        public async void LoadAndShowPetCards(IEnumerable<PetCard> petCardsToBeLoaded)
        {
            flowPanel.Controls.Clear();
            flowPanel.Controls.AddRange(petCardsToBeLoaded.ToArray());
        }

        /// <summary>
        /// Searches for a customer by phonenumber or name (first or last).
        /// If numbers is entered, search by phonenumber.
        /// </summary>
        private async void ShowPetByOwnerPhoneNumberOrName()
        {
            try
            {
                string input = textBoxPetByOwnerPhoneNumberOrPetName.Text.Trim();

                if (Int32.TryParse(input, out int customerPhoneNumber))
                {
                    // Search by phonenumber
                    IEnumerable<PetCard> petCards = AllPetCards
                        .Where(p => p.Pet.Customer.PhoneNumber == customerPhoneNumber);

                    LoadAndShowPetCards(petCards);
                }
                else
                {
                    // Search by name
                    IEnumerable<PetCard> petCards = AllPetCards
                        .Where(p => p.Pet.Name.Contains(textBoxPetByOwnerPhoneNumberOrPetName.Text, StringComparison.OrdinalIgnoreCase));

                    LoadAndShowPetCards(petCards);
                }

                // No hits - show user
                if (flowPanel.Controls.Count == 0)
                {
                    MessageBox.Show($"Ingen hits på \"{textBoxPetByOwnerPhoneNumberOrPetName.Text}\"", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                textBoxPetByOwnerPhoneNumberOrPetName.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxPetByOwnerPhoneNumberOrPetName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true; // The user is only able to enter numbers and letters in the textbox.
            }
        }

        private void textBoxPetByOwnerPhoneNumberOrPetName_Click(object sender, EventArgs e)
        {
            if (textBoxPetByOwnerPhoneNumberOrPetName.Text == "Søg på kæledyr eller telefonnummer")
            {
                textBoxPetByOwnerPhoneNumberOrPetName.Text = string.Empty;
                textBoxPetByOwnerPhoneNumberOrPetName.ForeColor = SystemColors.WindowText;
            }
        }

        private void customerSearchButton_Click(object sender, EventArgs e)
        {
            if (textBoxPetByOwnerPhoneNumberOrPetName.Text != "Søg på kæledyr eller telefonnummer" || !string.IsNullOrEmpty(textBoxPetByOwnerPhoneNumberOrPetName.Text))
            {
                ShowPetByOwnerPhoneNumberOrName();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (this.PetCard == null)
            {
                MessageBox.Show("Vælg venligst den kunde, der skal ændres.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var updatePage = new UpdatePetUserControl(PetCard, this);

            _mainPanel.Controls.Add(updatePage);
            updatePage.BringToFront();

            changeButton.Image = Properties.Resources.ChangeButtonGreyedOut;
        }

        private void findAllButton_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void findAllButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void customerSearchButton_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void customerSearchButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
