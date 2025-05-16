using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2SemesterProjekt.Domain.Models;
using _2SemesterProjekt.Pages.UserControls.ExaminationUserControl;
using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using Microsoft.Extensions.DependencyInjection;
using _2SemesterProjekt.Services;

namespace _2SemesterProjekt
{
    public partial class CustomerPage : UserControl
    {
        private ButtonPanel _showButton;
        private readonly ICustomerService _customerService;
        public List<CustomerCard> AllCustomerCards { get; set; } = new List<CustomerCard>();
        public CustomerPage()
        {
            InitializeComponent();
            _customerService = ServiceProviderSingleton.GetServiceProvider().GetService<ICustomerService>()!;
        }
        private async void CustomerPage_Load(object sender, EventArgs e)
        {
            ButtonPanel showButton = new ButtonPanel("Vis alle", Color.MediumAquamarine, ShowAllCustomersButton_Click);
            _showButton = showButton;
            buttonFlowPanel.Controls.Add(showButton);
            buttonFlowPanel.Controls.Add(new ButtonPanel("Tilføj kunde", "AddCustomer.png", Color.MediumSeaGreen, AddCustomerButton_Click));

            Task.Run(() => FindAndSetAllCustomersAsync()); // New thread calling the method below.
        }

        /// <summary>
        /// Loads all customers on customerPage click, making them ready for "Vis alle"-click. 
        /// </summary>
        private async void FindAndSetAllCustomersAsync()
        {
            IEnumerable<Customer> allCustomers = await _customerService.GetAllCustomersAsync();

            foreach (var customer in allCustomers)
            {
                AllCustomerCards.Add(new CustomerCard(customer));
            }
        }

        /// <summary>
        /// Eventhandler when "Find alle"-button is clicked, calls Method: LoadAndShowCustomerCards.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ShowAllCustomersButton_Click(object sender, EventArgs e)
        {
            if (textBoxCustomerSearch.Text == "Søg på navn eller ID" || string.IsNullOrEmpty(textBoxCustomerSearch.Text))
            {
                LoadAndShowCustomerCards(AllCustomerCards);
            }
            else
            {
                ShowCustomerByPhoneNumberOrName();
            }
        }

        /// <summary>
        /// Responsible for adding the userControl CustomerCards to the customerFlowPanel.
        /// </summary>
        /// <param name="customerCardsToBeLoaded"></param>
		public async void LoadAndShowCustomerCards(IEnumerable<CustomerCard> customerCardsToBeLoaded)
        {
            customerFlowPanel.Controls.Clear();
            customerFlowPanel.Controls.AddRange(customerCardsToBeLoaded.ToArray());
        }

        // Event handler with "Add Customer" when button is clicked
        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new AddCustomer());
        }

        /// <summary>
        /// Searches for a customer by phonenumber or name (first or last).
        /// If numbers is entered, search by phonenumber.
        /// </summary>
        private async void ShowCustomerByPhoneNumberOrName()
        {
            try
            {
                string input = textBoxCustomerSearch.Text.Trim();

                if (Int32.TryParse(input, out int customerPhoneNumber))
                {
                    // Search by ID
                    CustomerCard customerCard = AllCustomerCards
                        .First(c => c.Customer.PhoneNumber == customerPhoneNumber);

                    customerFlowPanel.Controls.Clear();

                    customerFlowPanel.Controls.Add(customerCard);
                }
                else
                {
                    // Search by name
                    IEnumerable<CustomerCard> customerCards = AllCustomerCards
                        .Where(c => c.Customer.FirstName.Contains(textBoxCustomerSearch.Text, StringComparison.OrdinalIgnoreCase) || 
                                    c.Customer.LastName.Contains(textBoxCustomerSearch.Text, StringComparison.OrdinalIgnoreCase));

                    LoadAndShowCustomerCards(customerCards);
                }

                // No hits - show user
                if (customerFlowPanel.Controls.Count == 0)
                {
                    MessageBox.Show($"Ingen hits på \"{textBoxCustomerSearch.Text}\"", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                textBoxCustomerSearch.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxCustomerSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true; // The user is only able to enter numbers and letters in the textbox.
            }
        }

        /// <summary>
        /// Prepares the textbox for input by clearing the placeholder text when clicked.
        /// </summary>
        private void textBoxCustomerSearch_Click(object sender, EventArgs e)
        {
            if (textBoxCustomerSearch.Text == "Søg på navn eller ID")
            {
                textBoxCustomerSearch.Text = string.Empty;
                textBoxCustomerSearch.ForeColor = SystemColors.WindowText;
            }
        }

        /// <summary>
        /// Changes search textbox when user writes.
        /// </summary>
        private void textBoxCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCustomerSearch.Text.Length > 0) // No characters = show all
            {
                if (_showButton.ButtonText.Text == "Vis alle")
                {
                    _showButton.ButtonText.Text = "Søg";
                    _showButton.CenterLabel();
                }
            }
            else // Characters = show search
            {
                if (_showButton.ButtonText.Text == "Søg")
                {
                    _showButton.ButtonText.Text = "Vis alle";
                    _showButton.CenterLabel();
                }
            }
        }
    }
}
