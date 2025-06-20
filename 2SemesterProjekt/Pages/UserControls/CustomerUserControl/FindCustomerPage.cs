﻿using System;
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

namespace _2SemesterProjekt.Pages.UserControls.CustomerUserControl
{
    public partial class FindCustomerPage : UserControl
    {
        private readonly ICustomerService _customerService;
        public List<CustomerCard> AllCustomerCards { get; set; } = new List<CustomerCard>();
        public FindCustomerPage()
        {
            InitializeComponent();
            _customerService = ServiceProviderSingleton.GetServiceProvider().GetService<ICustomerService>()!;
        }

        /// <summary>
        /// Eventhandler when "Find alle"-button is clicked, calls Method: LoadAndShowCustomerCards.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindCustomerPage_Load(object sender, EventArgs e)
        {
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

            findAllButton.Image = Properties.Resources.FindAllButton;
        }

        private void findAllButton_Click(object sender, EventArgs e)
        {
            // Wait cursor (hourglass)
            Cursor = Cursors.WaitCursor;
            findAllButton.Enabled = false;

            LoadAndShowCustomerCards(AllCustomerCards);

            // Wait cursor (pointer)
            Cursor = Cursors.Default;
            findAllButton.Enabled = true;
        }

        /// <summary>
        /// Responsible for adding the userControl CustomerCards to the customerFlowPanel.
        /// </summary>
        /// <param name="customerCardsToBeLoaded"></param>
		public async void LoadAndShowCustomerCards(IEnumerable<CustomerCard> customerCardsToBeLoaded)
        {
            flowPanel.Controls.Clear();
            flowPanel.Controls.AddRange(customerCardsToBeLoaded.ToArray());
        }

        /// <summary>
        /// Searches for a customer by phonenumber or name (first or last).
        /// If numbers is entered, search by phonenumber.
        /// </summary>
        private async void ShowCustomerByPhoneNumberOrName()
        {
            try
            {
                string input = textBoxCustomerPhoneNumberOrName.Text.Trim();

                if (Int32.TryParse(input, out int customerPhoneNumber))
                {
                    // Search by phonenumber
                    CustomerCard customerCard = AllCustomerCards
                        .First(c => c.Customer.PhoneNumber == customerPhoneNumber);

                    flowPanel.Controls.Clear();

                    flowPanel.Controls.Add(customerCard);
                }
                else
                {
                    // Search by name
                    IEnumerable<CustomerCard> customerCards = AllCustomerCards
                        .Where(c => c.Customer.FirstName.Contains(textBoxCustomerPhoneNumberOrName.Text, StringComparison.OrdinalIgnoreCase) ||
                                    c.Customer.LastName.Contains(textBoxCustomerPhoneNumberOrName.Text, StringComparison.OrdinalIgnoreCase));

                    LoadAndShowCustomerCards(customerCards);
                }

                // No hits - show user
                if (flowPanel.Controls.Count == 0)
                {
                    MessageBox.Show($"Ingen hits på \"{textBoxCustomerPhoneNumberOrName.Text}\"", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                textBoxCustomerPhoneNumberOrName.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxCustomerPhoneNumberOrName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true; // The user is only able to enter numbers and letters in the textbox.
            }
        }

        private void customerSearchButton_Click(object sender, EventArgs e)
        {
            ShowCustomerByPhoneNumberOrName();
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
