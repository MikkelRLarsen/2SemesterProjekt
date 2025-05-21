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
using _2SemesterProjekt.Pages;

namespace _2SemesterProjekt
{
    public partial class CustomerCard : UserControl
    {
        public Customer Customer { get; private set; } // Holds Customer data
        private CustomerPage _customerPage;
        public CustomerCard(Customer customer, CustomerPage customerPage)
        {
            InitializeComponent();
            Customer = customer;
            InitializeUIDesign();
            _customerPage = customerPage;
        }
        private void InitializeUIDesign()
        {
            customerIdLabel.Text = Customer.CustomerID.ToString();
            customerNameLabel.Text = $"{Customer.FirstName} {Customer.LastName}";
            customerPhoneNumberLabel.Text = Customer.PhoneNumber.ToString();
            customerEmailLabel.Text = Customer.Email;
            customerAddressLabel.Text = Customer.Address;
        }

        private void CustomerCard_Click(object sender, EventArgs e)
        {
            if (_customerPage.CustomerCard != null) // protects against null reference exceptions the first time it's clicked
            {
                _customerPage.CustomerCard.BackColor = SystemColors.Window; // If a card was previously selected, reset its background color
            }

            _customerPage.CustomerCard = this; // Set the currently clicked card as the new selected card

            this.BackColor = SystemColors.ActiveBorder;
        }
    }
}
