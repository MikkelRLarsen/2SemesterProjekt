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
		private readonly ICustomerService _customerService;
        public List<CustomerCard> AllCustomerCards { get; set; } = new List<CustomerCard>();
        public CustomerPage()
		{
			InitializeComponent();
            _customerService = ServiceProviderSingleton.GetServiceProvider().GetService<ICustomerService>();
        }
        private async void CustomerPage_Load(object sender, EventArgs e)
        {
            buttonFlowPanel.Controls.Add(new ButtonPanel("Vis alle", Color.MediumAquamarine, ShowAllCustomersButton_Click));
            buttonFlowPanel.Controls.Add(new ButtonPanel("Tilføj kunde", "AddCustomer.png", Color.MediumSeaGreen, AddCustomerButton_Click));

            Task.Run(() => FindAndSetAllCustomersAsync()); // New thread calling the method below.
        }
        /// <summary>
        /// Loads all customers on customerPage click, making them ready for "Vis alle"-click. 
        /// </summary>
        private async void FindAndSetAllCustomersAsync() // 
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
            LoadAndShowCustomerCards(AllCustomerCards);
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
	}
}
