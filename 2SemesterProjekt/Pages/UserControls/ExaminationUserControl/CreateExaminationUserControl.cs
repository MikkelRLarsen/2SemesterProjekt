using _2SemesterProject.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProjekt.Domain.Models;
using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using Microsoft.Extensions.DependencyInjection;


namespace _2SemesterProjekt.Pages.UserControls.ExaminationUserControl
{
	public partial class CreateExaminationUserControl : UserControl
	{
		ICustomerService _customerService;
		IEmployeeService _employeeService;
		IPetService _petService;
		IExaminationService _examinationService;
		FlowLayoutPanel _konsultationPanel;

		public CreateExaminationUserControl(FlowLayoutPanel konsultationPanel)
		{
			InitializeComponent();
			_konsultationPanel = konsultationPanel;
		}

		private async void CustomerExaminationDropdown_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (CustomerExaminationDropdown.SelectedItem != null)
			{
				PetExaminationDropdown.Enabled = true;

				Customer kunde = CustomerExaminationDropdown.SelectedItem as Customer;
				PetExaminationDropdown.DataSource = kunde.Pets;
			}
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
			EmployeeExaminationDropdown.DataSource = await _employeeService.GetAllEmployeeAsync();
		}

		private void EmployeeExaminationDropdown_SelectedIndexChanged(object sender, EventArgs e)
		{
			CreateExaminationButton.Enabled = true;
			CreateExaminationButton.BackColor = Color.MediumAquamarine;
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

				_konsultationPanel.Controls.Clear();

			}
			catch (Exception ex)
			{
				ErrorMessageExamination.Text = ex.Message;
			}
		}

		private async void CreateExaminationUserControl_Load(object sender, EventArgs e)
		{
			ServiceProvider allServices = ServiceProviderSingleton.GetServiceProvider();

			_customerService = allServices.GetService<ICustomerService>();
			_employeeService = allServices.GetService<IEmployeeService>();
			_petService = allServices.GetService<IPetService>();
			_examinationService = allServices.GetService<IExaminationService>();

			CustomerExaminationDropdown.DataSource = await GetAllCustomers();

			SetAllDisplayMembers();
		}

		private async Task<List<Customer>> GetAllCustomers()
		{
			List<Customer> customers = new List<Customer>();
			customers.AddRange(await _customerService.GetAllCustomersAsync());
			return customers;
		}

		private void SetAllDisplayMembers()
		{
			CustomerExaminationDropdown.DisplayMember = "FirstName";
			PetExaminationDropdown.DisplayMember = "Name";
			EmployeeExaminationDropdown.DisplayMember = "FirstName";
		}

		private void CancelExaminationButton_Click(object sender, EventArgs e)
		{
			_konsultationPanel.Controls.Clear ();
		}
	}
}
