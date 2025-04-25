using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2SemesterProject.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProject.Domain.Models;
using Microsoft.Extensions.DependencyInjection;

namespace _2SemesterProjekt
{
	public partial class AddCustomer : UserControl
	{
		private readonly ICustomerService _customerService;
		private readonly string[] _customerTypes = { "Privat", "Erhverv" };

		public AddCustomer()
		{
			InitializeComponent();

			// Get the customer service from the service provider
			_customerService = ServiceProviderSingleton.GetServiceProvider().GetService<ICustomerService>()!;

			// Add buttons
			panelCancel.Controls.Add(new ButtonPanel("Anuller", Color.IndianRed, CancelButton_Click));
			panelCreate.Controls.Add(new ButtonPanel("Tilføj kunde", Color.MediumSeaGreen, CreateButton_Click));

			// Add content for dropdown
			comboBoxType.Items.AddRange(_customerTypes);
			comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
		}

		// Eventhandler for cancel button
		private void CancelButton_Click(object? sender, EventArgs e)
		{
			this.Controls.Clear();
			this.Controls.Add(new CustomerPage());
		}

		
		private void textBoxFirstName_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Allow only letters, control keys (backspace), and separators (space)
			if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void textBoxLastName_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Allow only letters, control keys (backspace), and separators (space)
			if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void textBoxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Allow only digits
			if (!char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void CreateButton_Click(object? sender, EventArgs e)
		{

			var customer = new Customer(
					textBoxFirstName.Text, // FirstName
					textBoxLastName.Text,  // LastName
					textBoxEmail.Text,     // Email
					textBoxAddress.Text,   // Address
					comboBoxType.Text,     // Type
					Convert.ToInt32(textBoxPhoneNumber.Text) // PhoneNumber
				);

			var result = _customerService.CreateCustomer(customer);

			if (result == true) // Display success result
			{
				MessageBox.Show($"{customer.FirstName} {customer.LastName} er blevet oprettet");
			}
			else // Display failure message
			{
				MessageBox.Show($"Fejl under oprettelse");
			}
		}
	}
}
