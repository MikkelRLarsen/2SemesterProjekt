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
		public UpdateExaminationUserControl(Examination examination)
		{
			InitializeComponent();
			_examination = examination;

			_examinationService = ServiceProviderSingleton.GetServiceProvider().GetService<IExaminationService>()!;
			_employeeService = ServiceProviderSingleton.GetServiceProvider().GetService<IEmployeeService>()!;
		}

		private async void UpdateExaminationUserControl_Load(object sender, EventArgs e)
		{
			EmployeeExaminationDropdown.DataSource = (await GetListOfEmployeeWithExaminationEmployeeFirst(_examination)).ToList();
			EmployeeExaminationDropdown.DisplayMember = "FirstName";
		}

		private async Task<IEnumerable<Employee>> GetListOfEmployeeWithExaminationEmployeeFirst(Examination examination)
		{
			// Gets all PetDoctorsFromDatabase
			IEnumerable<Employee> allPetDocterFromDatabase = await _employeeService.GetAllPetDoctorsAsync();

			// Creates a Dictonary from said PetDoctors, so its easier to manipulate data in constant time, rather than linear time if List was used
			var allPetDoctorsInDict = allPetDocterFromDatabase.ToDictionary(em => em.EmployeeID, em  => em);

			// Removes said employee from Dictonary
			allPetDoctorsInDict.Remove(examination.EmployeeID);

			// Makes the Dictonary to List and Prepend examination employee as first and lastly returns list
			return allPetDoctorsInDict.Values.ToList().Prepend(examination.Employee);
		}
	}
}
