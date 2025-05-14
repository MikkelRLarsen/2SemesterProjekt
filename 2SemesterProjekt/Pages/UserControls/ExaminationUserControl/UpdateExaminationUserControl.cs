using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProjekt.Domain.Models;
using _2SemesterProjekt.Pages.UserControls.UIModels;
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
	public partial class UpdateExaminationUserControl : UserControl
	{
		private readonly IExaminationService _examinationService;
		private readonly IEmployeeService _employeeService;
		private readonly Examination _examination;
		private readonly KonsultationPage _konsultationPage;
		public UpdateExaminationUserControl(Examination examination, KonsultationPage konsultationPage)
		{
			InitializeComponent();
			_examination = examination;

			_examinationService = ServiceProviderSingleton.GetServiceProvider().GetService<IExaminationService>()!;
			_employeeService = ServiceProviderSingleton.GetServiceProvider().GetService<IEmployeeService>()!;
			_konsultationPage = konsultationPage;
		}

		private async void UpdateExaminationUserControl_Load(object sender, EventArgs e)
		{
			EmployeeExaminationDropdown.DataSource = (await GetListOfEmployeeWithExaminationEmployeeFirst(_examination)).ToList();
			EmployeeExaminationDropdown.DisplayMember = "FirstName";

			DateTimePickerExamination.Value = _examination.Date;
			DateTimePickerExamination.MinDate = DateTime.UtcNow;

			CustomerTextBox.Text = _examination.Pet.Customer.FirstName;
			PetTextBox.Text = _examination.Pet.Name;
			ExaminationTextBox.Text = _examination.ExaminationType.Description;
			PriceTextBox.Text = _examination.Price.ToString();
		}

		private async Task<IEnumerable<Employee>> GetListOfEmployeeWithExaminationEmployeeFirst(Examination examination)
		{
			// Gets all PetDoctorsFromDatabase
			IEnumerable<Employee> allPetDocterFromDatabase = await _employeeService.GetAllPetDoctorsAsync();

			// Creates a Dictonary from said PetDoctors, so its easier to manipulate data in constant time, rather than linear time if List was used
			var allPetDoctorsInDict = allPetDocterFromDatabase.ToDictionary(em => em.EmployeeID, em => em);

			// Removes said employee from Dictonary
			allPetDoctorsInDict.Remove(examination.EmployeeID);

			// Makes the Dictonary to List and Prepend examination employee as first and lastly returns list
			return allPetDoctorsInDict.Values.ToList().Prepend(examination.Employee);
		}

		private void GemExaminationButton_Click(object sender, EventArgs e)
		{
			try
			{
				Examination examinationWithUpdatetInformation = new Examination(
						_examination.PetID,
						(EmployeeExaminationDropdown.SelectedItem as Employee).EmployeeID,
						DateTimePickerExamination.Value, _examination.MedicineID,
						_examination.ExaminationTypeID,
						_examination.Price,
						_examination.CageBookingID);

				DialogResult messageBoxResult = MessageBox.Show("Er du sikker på, at denne konsultationstid skal ændres?", "Advarsel", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

				if (messageBoxResult != DialogResult.Yes)
				{
					return;
				}

				_examination.UpdateExaminationProperties(examinationWithUpdatetInformation);

				_examinationService.UpdateExamination(_examination);

				MessageBox.Show("Konsultationen er blevet opdateret", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void CancelExaminationButton_Click(object sender, EventArgs e)
		{
			_konsultationPage.AllExaminationCards.First(exCard => exCard.Examination.ExaminationID == _examination.ExaminationID);


			_konsultationPage.LoadAndShowExaminationCards(_konsultationPage.AllExaminationCards);
		}
	}
}
