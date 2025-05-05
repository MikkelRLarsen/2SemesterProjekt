using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProjekt.Domain.Models;
using _2SemesterProjekt.Services;
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

namespace _2SemesterProjekt.Pages.UserControls.Product
{
    public partial class CreateOrder : UserControl
    {
        FlowLayoutPanel _orderPanel;
        private readonly IProductService _productService;
        private readonly ICustomerService _customerService;
        public CreateOrder(FlowLayoutPanel orderPanel)
        {
            InitializeComponent();
            _orderPanel = orderPanel;
            _productService = ServiceProviderSingleton.GetServiceProvider().GetService<IProductService>();
            _customerService = ServiceProviderSingleton.GetServiceProvider().GetService<ICustomerService>();
        }

        private void customerPhoneNumberTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // The user is only able to enter numbers in the textbox.
            }
        }

        private async void getCustomerButton_Click(object sender, EventArgs e)
        {
            int phoneNumber = Convert.ToInt32(customerPhoneNumberTextbox.Text);
            Customer customer = await _customerService.GetCustomerByPhoneNumberAsync(phoneNumber);
            if (customer == null)
            {
                customerNameLabel.Text = "Kunne ikke finde kunden.";
                customerNameLabel.Visible = true;
            }
            else
            {
                customerNameLabel.Text = $"{customer.FirstName} {customer.LastName}";
                customerAddressLabel.Text = $"{customer.Address}";
                customerEmailLabel.Text = $"{customer.Email}";
                customerNameLabel.Visible = true;
                customerAddressLabel.Visible = true;
                customerEmailLabel.Visible = true;
            }
        }
    }
}
