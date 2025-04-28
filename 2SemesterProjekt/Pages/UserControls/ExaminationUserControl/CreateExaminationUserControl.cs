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
		IExaminationService _examinationService;

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
			_examinationService = allServices.GetService<IExaminationService>();

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

		private async void PetExaminationDropdown_SelectedIndexChanged(object sender, EventArgs e)
		{
			ExaminationDropdown.DataSource = await _examinationService.GetAllExaminationsAsync(); // Not implemented Yet
			ExaminationDropdown.Enabled = true;
		}

		private void ExaminationDropdown_SelectedIndexChanged(object sender, EventArgs e)
		{
			PriceExaminationDisplay.Text = ""; //Get Price for Examination
			DateTimePickerExamination.Enabled = true;
		}

		private async void DateTimePickerExamination_ValueChanged(object sender, EventArgs e)
		{
			EmployeeExaminationDropdown.Enabled = true;
			if (EmployeeExaminationDropdown.DataSource != null)
			{
				EmployeeExaminationDropdown.DataSource = await _employeeService.GetAllEmployeeAsync();
			}
		}

		private void EmployeeExaminationDropdown_SelectedIndexChanged(object sender, EventArgs e)
		{
			CreateExaminationButton.Enabled = true;
			CreateExaminationButton
		}

		private void CreateExaminationButton_Click(object sender, EventArgs e)
		{
			try
			{
				Examination newExamination = new Examination(0
					, (PetExaminationDropdown.SelectedItem as Pet).PetID
					, (EmployeeExaminationDropdown.SelectedItem as Employee).EmployeeID
					, DateTimePickerExamination.Value
					, ExaminationDropdown.SelectedItem as String
					, Convert.ToDouble(PriceExaminationDisplay.Text));

				_examinationService.CreateExamination(newExamination);

			}
			catch (Exception ex)
			{
				ErrorMessageExamination.Text = ex.Message; 
			}			
		}
	}
}
