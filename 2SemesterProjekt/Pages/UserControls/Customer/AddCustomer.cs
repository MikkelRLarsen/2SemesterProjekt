using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2SemesterProject.Domain.Interfaces.ServiceInterfaces;
using Microsoft.Extensions.DependencyInjection;

namespace _2SemesterProjekt
{
	public partial class AddCustomer : UserControl
	{
		ICustomerService _customerService;

		public AddCustomer()
		{
			InitializeComponent();
			_customerService = ServiceProviderSingleton.GetServiceProvider().GetService<ICustomerService>()!;
			panelCancel.Controls.Add(new ButtonPanel("Anuller", Color.IndianRed, CancelButton_Click));
			panelCreate.Controls.Add(new ButtonPanel("Tilføj kunde", Color.MediumSeaGreen, CreateButton_Click));
		}

		private void CancelButton_Click(object? sender, EventArgs e)
		{
			this.Controls.Clear();
			this.Controls.Add(new CustomerPage());
		}

		private void CreateButton_Click(object? sender, EventArgs e)
		{
			//_customerService.CreateCustomer();
		}
	}
}
