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
		ICustomerService _customerService;
		string[] _customerTypes = { "Privat", "Erhverv" };

		public AddCustomer()
		{
			InitializeComponent();
			_customerService = ServiceProviderSingleton.GetServiceProvider().GetService<ICustomerService>()!;
			panelCancel.Controls.Add(new ButtonPanel("Anuller", Color.IndianRed, CancelButton_Click));
			panelCreate.Controls.Add(new ButtonPanel("Tilføj kunde", Color.MediumSeaGreen, CreateButton_Click));
			comboBoxType.Items.AddRange(_customerTypes);
			comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
		}

		private void CancelButton_Click(object? sender, EventArgs e)
		{
			this.Controls.Clear();
			this.Controls.Add(new CustomerPage());
		}

		private void textBoxFirstName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void textBoxLastName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void textBoxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void CreateButton_Click(object? sender, EventArgs e)
		{
			var customer = new Customer(
					textBoxFirstName.Text,
					textBoxLastName.Text,
					textBoxEmail.Text,
					textBoxAddress.Text,
					comboBoxType.Text,
					Convert.ToInt32(textBoxPhoneNumber.Text)
				);

			_customerService.CreateCustomer(customer);
		}
	}
}
