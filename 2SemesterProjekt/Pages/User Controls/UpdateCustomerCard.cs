using _2SemesterProject.Domain.Interfaces.ServiceInterfaces.Core;
using _2SemesterProject.Domain.Models.Core;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2SemesterProjekt.Pages.User_Controls
{
	public partial class UpdateCustomerCard : UserControl
	{
		private readonly CustomerDTO _customerDTO;
		private Customer _customer;
		private readonly ServiceProvider _serviceProviderSingleton = ServiceProviderSingleton._serviceProvider;

		public UpdateCustomerCard()
		{
			InitializeComponent();
			_customerDTO = new CustomerDTO();
		}

		public UpdateCustomerCard(Customer customer)
		{
			InitializeComponent();
			_customerDTO = new CustomerDTO(customer);
			customerNameTextBox.Text = customer.CustomerName;
			customerAdressTextBox.Text = customer.CustomerAdress;
			customerTlfTextBox.Text = customer.CustomerPhoneNumber.ToString();
			customerEmailTextBox.Text = customer.CustomerEmail;

			_customer = customer;
		}

		private void customerNameTextBox_TextChanged(object sender, EventArgs e)
		{
			_customerDTO.CustomerName = customerNameTextBox.Text;
		}

		private void customerAdressTextBox_TextChanged(object sender, EventArgs e)
		{
			_customerDTO.CustomerAdress = customerAdressTextBox.Text;
		}

		private void customerTlfTextBox_TextChanged(object sender, EventArgs e)
		{
			_customerDTO.CustomerPhoneNumber = Convert.ToInt32(customerTlfTextBox.Text);
		}

		private void customerEmailTextBox_TextChanged(object sender, EventArgs e)
		{
			_customerDTO.CustomerEmail = customerEmailTextBox.Text;
		}

		private void DoneButton_Click(object sender, EventArgs e)
		{
			ICustomerService service = _serviceProviderSingleton.GetService<ICustomerService>();

			if (_customer == null)
			{
				var customer = new Customer();
				_customer = customer;
			}

			_customer.UpdateCustomer(_customerDTO.CustomerName, _customerDTO.CustomerEmail, _customerDTO.CustomerAdress, _customerDTO.CustomerPhoneNumber);


			if (service != null)
			{
				service.UpdateCustomer(_customer);
			}
		}
	}
}
