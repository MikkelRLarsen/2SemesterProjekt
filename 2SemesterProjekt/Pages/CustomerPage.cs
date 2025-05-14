using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2SemesterProjekt
{
	public partial class CustomerPage : UserControl
	{
		public CustomerPage()
		{
			InitializeComponent();

			// Button with a click event handler
			buttonFlowPanel.Controls.Add(new ButtonPanel("Vis alle", "", Color.MediumAquamarine, ShowAllCustomersButton_Click));
			buttonFlowPanel.Controls.Add(new ButtonPanel("Tilføj kunde", "AddCustomer.png", Color.MediumSeaGreen, AddCustomerButton_Click));
		}
		// Eventhandler with "Show Áll Customers" when button is clicked
		private void ShowAllCustomersButton_Click(object? sender, EventArgs e)
		{
            this.Controls.Clear();
        }

        // Event handler with "Add Customer" when button is clicked
        private void AddCustomerButton_Click(object? sender, EventArgs e)
		{
			this.Controls.Clear();
			this.Controls.Add(new AddCustomer());
		}
	}
}
