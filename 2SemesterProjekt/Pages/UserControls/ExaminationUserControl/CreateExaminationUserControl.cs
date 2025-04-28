using _2SemesterProject.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProject.Domain.Models;
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

namespace _2SemesterProjekt.Pages.UserControls.ExaminationUserControl
{
	public partial class CreateExaminationUserControl : UserControl
	{
		ICustomerService _custerService;
		IEmployeeService _employeeService;
		IPetService _petService;

		public CreateExaminationUserControl()
		{
			InitializeComponent();
		}

		private async void LoadForm(object sender, EventArgs e)
		{
			ServiceProvider allServices = ServiceProviderSingleton.GetServiceProvider();

			_custerService = allServices.GetService<ICustomerService>();
			_employeeService = allServices.GetService<IEmployeeService>();
			_petService = allServices.GetService<IPetService>();

			CustomerExaminationDropdown.DataSource = await _custerService.GetAllCustomersAsync();
			CustomerExaminationDropdown.DisplayMember = "FirstName";
		}

		private async void CustomerExaminationDropdown_SelectedIndexChanged(object sender, EventArgs e)
		{
			PetExaminationDropdown.Enabled = true;

			Customer kunde = CustomerExaminationDropdown.SelectedItem as Customer;
			PetExaminationDropdown.DataSource = await _petService.GetAllPetsFromCustomerID(kunde.CustomerID);
			PetExaminationDropdown.DisplayMember = "Name";
		}
	}
}
