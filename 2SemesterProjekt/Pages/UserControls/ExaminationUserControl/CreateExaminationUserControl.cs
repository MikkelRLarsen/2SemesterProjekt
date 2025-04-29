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
		private async void CustomerExaminationDropdown_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (CustomerExaminationDropdown.SelectedItem != null)
			{
				PetExaminationDropdown.Enabled = true;

				Customer kunde = CustomerExaminationDropdown.SelectedItem as Customer;
				PetExaminationDropdown.DataSource = kunde.Pets;
			}
		}

		/// <summary>
		/// Eventhandler for when PetExaminationDropdown Index is changed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void PetExaminationDropdown_SelectedIndexChanged(object sender, EventArgs e)
		{
			ExaminationDropdown.DataSource = await _examinationService.GetAllExaminationTypesAsync();
			ExaminationDropdown.Enabled = true;
		}

		/// <summary>
		/// Eventhandler for when ExaminationDropdown Index is changed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void ExaminationDropdown_SelectedIndexChanged(object sender, EventArgs e)
		{
			PriceExaminationDisplay.Text = Convert.ToString(_examinationService.GetAllExaminationPrices(ExaminationDropdown.SelectedItem as string));
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
			EmployeeExaminationDropdown.DataSource = await _employeeService.GetAllEmployeeAsync();
		}

		/// <summary>
		/// Eventhandler for when EmployeeExaminationDropdown is changed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void EmployeeExaminationDropdown_SelectedIndexChanged(object sender, EventArgs e)
		{
			CreateExaminationButton.Enabled = true;
			CreateExaminationButton.BackColor = Color.MediumAquamarine;
		}

		/// <summary>
		/// Button to create Examination. Currently Not-Async
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CreateExaminationButton_Click(object sender, EventArgs e)
		{

			try
			{
				Examination newExamination = new Examination((PetExaminationDropdown.SelectedItem as Pet).PetID
					, (EmployeeExaminationDropdown.SelectedItem as Employee).EmployeeID
					, DateTimePickerExamination.Value
					, ExaminationDropdown.SelectedItem as String
					, Convert.ToDouble(PriceExaminationDisplay.Text));

				_examinationService.CreateExamination(newExamination);

				_konsultationPanel.Controls.Clear();

			}
			catch (Exception ex)
			{
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
		}
	}
}
