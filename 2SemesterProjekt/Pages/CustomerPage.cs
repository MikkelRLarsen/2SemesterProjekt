using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2SemesterProjekt.Pages.User_Controls;
using _2SemesterProject.Domain.Models.Core;

namespace _2SemesterProjekt
{
	public partial class CustomerPage : UserControl
	{
		private readonly ButtonPanel _findCustomerButton;
		private readonly ButtonPanel _addCustomerButton;
		private readonly ButtonPanel _updateCustomerButton;
		private readonly ButtonPanel _deleteCustomerButton;
		public CustomerCard _selectedCustomerCard; 


		public CustomerPage()
		{
			InitializeComponent();
			_findCustomerButton = new ButtonPanel(this, "Find kunde", "FindCustomer.png", Color.SteelBlue);
			_addCustomerButton = new ButtonPanel(this, "Tilføj kunde", "AddCustomer.png", Color.MediumSeaGreen, AddCustomer_Click);
			_updateCustomerButton = new ButtonPanel(this, "Redigér kunde", "EditCustomer.png", Color.Goldenrod, UpdateCustomer_Click);
			_deleteCustomerButton = new ButtonPanel(this, "Fjern kunde", "RemoveCustomer.png", Color.IndianRed, DeleteCustomer_Click);

			buttonFlowPanel.Controls.Add(_findCustomerButton);
			buttonFlowPanel.Controls.Add(_addCustomerButton);
			buttonFlowPanel.Controls.Add(_updateCustomerButton);
			buttonFlowPanel.Controls.Add(_deleteCustomerButton);
		}

		private void AddCustomer_Click(object sender, EventArgs e)
		{
			customerFlowPanel.Controls.Add(new CustomerCard(this));
		}
		private void DeleteCustomer_Click(object sender, EventArgs e)
		{
			if (_selectedCustomerCard != null)
			{
				customerFlowPanel.Controls.Remove(_selectedCustomerCard);
			}
		}

		private void UpdateCustomer_Click(object sender, EventArgs e)
		{
			if (_selectedCustomerCard == null) return;

			customerFlowPanel.Controls.Clear();

			customerFlowPanel.Controls.Add(new UpdateCustomerCard(new Customer(1, "Mikkel", "Mikkel@rosendahllarsen.dk", "Sundvej 18B, 3th", "Private", 21435547)));

		}
	}
}
