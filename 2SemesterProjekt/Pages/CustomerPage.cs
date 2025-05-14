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

namespace _2SemesterProjekt
{
	public partial class CustomerPage : UserControl
	{
		private readonly ICustomerService _customerService;
		public CustomerPage()
		{
			InitializeComponent();

			// Button with a click event handler
			buttonFlowPanel.Controls.Add(new ButtonPanel("Vis alle", "", Color.MediumAquamarine, ShowAllCustomersButton_Click));
			buttonFlowPanel.Controls.Add(new ButtonPanel("Tilføj kunde", "AddCustomer.png", Color.MediumSeaGreen, AddCustomerButton_Click));

            _customerService = ServiceProviderSingleton.GetServiceProvider().GetService<ICustomerService>();
        }
		// Eventhandler with "Show All Customers" when button is clicked
		private async void ShowAllCustomersButton_Click(object? sender, EventArgs e)
		{
            // Retrieve all Customers
            IEnumerable<Customer> allCustomers = await _customerService.GetAllCustomersAsync();
            
			customerFlowPanel.Controls.Clear(); // Clears exisiting content, so customers can be loaded in:
            
            foreach (var customer in allCustomers)
            {
                customerFlowPanel.Controls.Add(new CustomerCard(customer, this));
            }
        }

        // Event handler with "Add Customer" when button is clicked
        private void AddCustomerButton_Click(object? sender, EventArgs e)
		{
			this.Controls.Clear();
			this.Controls.Add(new AddCustomer());
		}
	}
}
