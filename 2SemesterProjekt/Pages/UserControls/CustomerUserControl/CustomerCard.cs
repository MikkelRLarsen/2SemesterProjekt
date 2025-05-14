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
        private Customer _customer; // Holds Customer data
        private CustomerPage _customerCard;

        public CustomerCard(Customer customer, CustomerPage customerPage)
        {
            InitializeComponent();
            _customer = customer;
            InitializeUIDesign();
            _customerCard = customerPage;
        }
        private void InitializeUIDesign()
        {
            customerIdLabel.Text = _customer.CustomerID.ToString();
            customerNameLabel.Text = _customer.FirstName;
        }
    }
}
