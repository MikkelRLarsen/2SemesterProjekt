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
        private decimal _totalPrice;
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
                customerAddressLabel.Visible = false;
                customerEmailLabel.Visible = false;
                orderListBox.Enabled = false;
                discountNumericUpDown.Enabled = false;
                addToOrderButton.Enabled = false;
                productSearchButton.Enabled = false;
                productSearchTextbox.Enabled = false;
                productsListBox.Enabled = false;
                createOrderButton.Enabled = false;
            }
            else
            {
                customerNameLabel.Text = $"{customer.FirstName} {customer.LastName}";
                customerAddressLabel.Text = $"{customer.Address}";
                customerEmailLabel.Text = $"{customer.Email}";
                customerNameLabel.Visible = true;
                customerAddressLabel.Visible = true;
                customerEmailLabel.Visible = true;
                orderListBox.Enabled = true;
                discountNumericUpDown.Enabled = true;
                addToOrderButton.Enabled = true;
                productSearchButton.Enabled = true;
                productSearchTextbox.Enabled = true;
                productsListBox.Enabled = true;
                createOrderButton.Enabled = true;
            }
        }


        private void createOrderButton_Click(object sender, EventArgs e)
        {
            if (discountNumericUpDown.Value >= 60)
            {
                DialogResult messageBoxResult = MessageBox.Show("Indtastet rabat er over 60%. Er du sikker på, at du vil fortsætte?", "Advarsel", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (messageBoxResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void discountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (_totalPrice != 0)
            {
                _totalPrice = (_totalPrice * ((100 - discountNumericUpDown.Value) / 100));
                totalPriceInfoLabel.Text = _totalPrice.ToString();
            }
        }
    }
}
