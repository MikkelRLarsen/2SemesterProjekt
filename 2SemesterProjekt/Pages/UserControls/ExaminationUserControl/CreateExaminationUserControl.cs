using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProjekt.Domain.Models;
using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using Microsoft.Extensions.DependencyInjection;


namespace _2SemesterProjekt.Pages.UserControls.ExaminationUserControl
{
	public partial class CreateExaminationUserControl : UserControl
	{
		ICustomerService _customerService;
		IEmployeeService _employeeService;
		IExaminationService _examinationService;
		FlowLayoutPanel _konsultationPanel;
		private IEnumerable<Employee> _employees;

		public CreateExaminationUserControl(FlowLayoutPanel konsultationPanel)
		{
			InitializeComponent();
			_konsultationPanel = konsultationPanel;
		}

		/// <summary>
		/// Eventhandler for when CustomerDropdown Index is changed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void CustomerExaminationDropdown_SelectionChangeCommitted(object sender, EventArgs e)
		{
			PetExaminationDropdown.Enabled = true;

			Customer kunde = CustomerExaminationDropdown.SelectedItem as Customer;
			PetExaminationDropdown.DataSource = kunde.Pets;
			UpdateEmployeeExaminationDropDown(PetExaminationDropdown.SelectedItem as Pet);
		}

		/// <summary>
		/// Eventhandler for when PetExaminationDropdown Index is changed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void PetExaminationDropdown_SelectionChangeCommitted(object sender, EventArgs e)
		{
			ExaminationDropdown.DataSource = await _examinationService.GetAllExaminationTypesAsync();
			ExaminationDropdown.Enabled = true;

			UpdateEmployeeExaminationDropDown(PetExaminationDropdown.SelectedItem as Pet);
		}

		/// <summary>
		/// Eventhandler for when ExaminationDropdown Index is changed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void ExaminationDropdown_SelectionChangeCommitted(object sender, EventArgs e)
		{
			PriceExaminationDisplay.Text = Convert.ToString(await _examinationService.GetExaminationPrice(ExaminationDropdown.SelectedItem as string));
			DateTimePickerExamination.Enabled = true;
		}

		/// <summary>
		/// Eventhandler for when DateTimePickerExamination Value is Changed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void DateTimePickerExamination_ValueChanged(object sender, EventArgs e)
		{
			EmployeeExaminationDropdown.Enabled = true;

			_employees = await _employeeService.GetAllPetDoctorsAsync();

            EmployeeExaminationDropdown.DataSource = _employees;
        }

		/// <summary>
		/// Eventhandler for when EmployeeExaminationDropdown is changed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void EmployeeExaminationDropdown_SelectionChangeCommitted(object sender, EventArgs e)
		{
			CreateExaminationButton.Enabled = true;
			CreateExaminationButton.BackColor = Color.MediumAquamarine;
		}

		/// <summary>
		/// Button to create Examination. Currently Not-Async
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void CreateExaminationButton_Click(object sender, EventArgs e)
		{

			try
			{
				// Creates the new Examination as a local variable to run validate Information.
				Examination newExamination = new Examination((PetExaminationDropdown.SelectedItem as Pet).PetID
					, (EmployeeExaminationDropdown.SelectedItem as Employee).EmployeeID
					, DateTimePickerExamination.Value
					, ExaminationDropdown.SelectedItem as String
					, Convert.ToDecimal(PriceExaminationDisplay.Text));

				//Creates ExaminationAsync, so the user can continoue to use the program
				await _examinationService.CreateExaminationAsync(newExamination);

				//Shows a message that the creation has been completed
				ErrorMessageExamination.Visible = true;
				ErrorMessageExamination.Text = "Examination has been created";
			}
			catch (Exception ex)
			{
				//Shows error message if an error happend
				ErrorMessageExamination.Visible = true;
				ErrorMessageExamination.Text = ex.Message;
			}
		}

		/// <summary>
		/// Happens when the form is Loaded, not constructed.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void CreateExaminationUserControl_Load(object sender, EventArgs e)
		{
			ServiceProvider allServices = ServiceProviderSingleton.GetServiceProvider();

			_customerService = allServices.GetService<ICustomerService>();
			_employeeService = allServices.GetService<IEmployeeService>();
			_examinationService = allServices.GetService<IExaminationService>();


			SetAllDisplayMembers();
			DateTimePickerExamination.MinDate = DateTime.Now;

			CustomerExaminationDropdown.DataSource = await _customerService.GetAllCustomersAsync();
		}

		/// <summary>
		/// Set DisplayMembers foreach Combobox/Dropdown
		/// </summary>
		private void SetAllDisplayMembers()
		{
			CustomerExaminationDropdown.DisplayMember = "FirstName";
			PetExaminationDropdown.DisplayMember = "Name";
			EmployeeExaminationDropdown.DisplayMember = "FirstName";
		}

		/// <summary>
		/// Returns user back to prior page
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CancelExaminationButton_Click(object sender, EventArgs e)
		{
			_konsultationPanel.Controls.Clear();
		}

		/// <summary>
		/// Sets PriceExaminationsDisplay to white, when the value has changed. Default is greyed out
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PriceExaminationDisplay_TextChanged(object sender, EventArgs e)
		{
			PriceExaminationDisplay.BackColor = Color.White;
			PriceExaminationDisplay.ForeColor = Color.Black;
		}

		/// <summary>
		/// Sets the primary vet to the top of the dropdown list if the pet has a primary set
		/// </summary>
		/// <param name="pet"></param>
		private void UpdateEmployeeExaminationDropDown(Pet pet)
		{
			if (pet.EmployeeID != null)
			{
				Employee primaryVet = _employees.First(p => p.EmployeeID == pet.EmployeeID);

				_employees.ToList().Remove(primaryVet);

				var listWithPrimaryVetOnTop = new List<Employee>() { primaryVet };

				listWithPrimaryVetOnTop.AddRange(_employees);

				EmployeeExaminationDropdown.DataSource = listWithPrimaryVetOnTop;
			}
		}
	}
}
