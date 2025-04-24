using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2SemesterProject.Domain.Models;

namespace _2SemesterProjekt
{
    public partial class CustomerCard: UserControl
    {
        private Customer _customer;

        public CustomerCard(Customer customer)
        {
            InitializeComponent();
			_customer = customer;
			InitializeUIDesign();
        }

        public CustomerCard()
        {
			InitializeComponent();
		}

        private void InitializeUIDesign()
        {
            customerIdLabel.Text = _customer.CustomerID.ToString();
            customerNameLabel.Text = _customer.CustomerName;
        }
    }
}
