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

namespace _2SemesterProjekt
{
    public partial class CustomerCard : UserControl
    {
        public Customer Customer { get; private set; } // Holds Customer data
        public CustomerCard(Customer customer)
        {
            InitializeComponent();
            Customer = customer;
            InitializeUIDesign();
        }
        private void InitializeUIDesign()
        {
            customerIdLabel.Text = Customer.CustomerID.ToString();
            customerNameLabel.Text = $"{Customer.FirstName} {Customer.LastName}";
            customerPhoneNumberLabel.Text = Customer.PhoneNumber.ToString();
            customerEmailLabel.Text = Customer.Email;
            customerAddressLabel.Text = Customer.Address;
        }
    }
}
