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
using _2SemesterProject.Domain.Models.Core;

namespace _2SemesterProjekt
{
	public partial class CustomerCard : UserControl
	{
		private Customer _customer;
		private readonly CustomerPage _page;

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

		public CustomerCard(CustomerPage customerPage)
		{
			InitializeComponent();
			_page = customerPage;
		}

		private void InitializeUIDesign()
		{
			customerIdLabel.Text = _customer.CustomerID.ToString();
			customerNameLabel.Text = _customer.CustomerName;
		}

		private async void CustomerCard_Click(object sender, EventArgs e)
		{
			if (_page._selectedCustomerCard != null)
			{
				_page._selectedCustomerCard.BorderStyle = BorderStyle.None;
			}

			_page._selectedCustomerCard = this;
			this.BorderStyle = BorderStyle.FixedSingle;
		}
	}
}
