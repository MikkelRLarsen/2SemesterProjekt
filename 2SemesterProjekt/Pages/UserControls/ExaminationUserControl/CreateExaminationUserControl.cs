using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProjekt.Domain.Models;
using Microsoft.Extensions.DependencyInjection;
using _2SemesterProjekt.Pages.UserControls.UIModels;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;


namespace _2SemesterProjekt.Pages.UserControls.ExaminationUserControl
{
	public partial class CreateExaminationUserControl : UserControl
	{
		ICustomerService _customerService;
		IEmployeeService _employeeService;
		IExaminationService _examinationService;
		FlowLayoutPanel _konsultationPanel;
		private IEnumerable<Employee> _employees;
		private Decimal? _basePriceForExamination;

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

			// Show only next box if the Customer has Pets
			if (kunde.Pets != null)
			{
				PetExaminationDropdown.DataSource = kunde.Pets;
				UpdateEmployeeExaminationDropDown(PetExaminationDropdown.SelectedItem as Pet);
			}

			UpdateDiscountStatus();
		}

		/// <summary>
		/// Eventhandler for when PetExaminationDropdown Index is changed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void PetExaminationDropdown_SelectionChangeCommitted(object sender, EventArgs e)
		{
			ExaminationTypeDropdown.DataSource = await _examinationService.GetAllExaminationTypesAsync();
			ExaminationTypeDropdown.Enabled = true;

			UpdateEmployeeExaminationDropDown(PetExaminationDropdown.SelectedItem as Pet);
		}

		/// <summary>
		/// Eventhandler for when ExaminationDropdown Index is changed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void ExaminationDropdown_SelectionChangeCommitted(object sender, EventArgs e)
		{
			_basePriceForExamination = (ExaminationTypeDropdown.SelectedItem as ExaminationType).BasePrice;
			PriceExaminationDisplay.Text = _basePriceForExamination.ToString();

			DateTimePickerExamination.Enabled = true;
			UpdateDiscountStatus();
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
			//Resets ErrorMessage when retrying
			ErrorMessageExamination.Text = "";

			// Creates a messagebox if Discount is higher then 60% to confirm the booking of examination
			if (DiscountNumericUpDown.Value >= 60)
			{
				DialogResult resultFromMessageBox = MessageBox.Show("Er du sikkker på at du vil forsætte?", "Valgt rabat er over 60%", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

				// If the user press No then abort booking
				if (resultFromMessageBox == DialogResult.No)
				{
					return;
				}
			}

			try
			{
				// Creates the new Examination as a local variable to run validate Information.
				Examination newExamination = new Examination((PetExaminationDropdown.SelectedItem as Pet).PetID
					, (EmployeeExaminationDropdown.SelectedItem as Employee).EmployeeID
					, DateTimePickerExamination.Value
					, (ExaminationTypeDropdown.SelectedItem as ExaminationType).ExaminationTypeID
					, Convert.ToDecimal(PriceExaminationDisplay.Text));

				//Creates ExaminationAsync, so the user can continoue to use the program
				await _examinationService.CreateExaminationAsync(newExamination);

				//Shows a message that the creation has been completed
				ErrorMessageExamination.Visible = true;
				ErrorMessageExamination.Text = "Behandling er oprettet";
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
			ExaminationTypeDropdown.DisplayMember = "Description";
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
			if (pet.EmployeeID != null) // If pet have a primary vet - codes executes
			{
				EmployeeExaminationDropdown.DataSource = VeterinarianListBuilder.GetVeterinariansWithPrimaryFirst(_employees, pet.EmployeeID);
            }
		}

		private void UpdateDiscountStatus()
		{
			try
			{
				// Checks if selected Customer is Private and ExaminationTag is 2 which is Operation
				if ((CustomerExaminationDropdown.SelectedItem as Customer).Type == "Privat"
					&& ExaminationTypeDropdown.SelectedItem as ExaminationType != null
					&& (ExaminationTypeDropdown.SelectedItem as ExaminationType).ExaminationTag.ExaminationTagID == 2)
				{
					DiscountLabel.Visible = true;
					DiscountNumericUpDown.Visible = true;
				}
				else
				{
					DiscountLabel.Visible = false;
					DiscountNumericUpDown.Visible = false;
					DiscountNumericUpDown.Value = 0;
					PriceExaminationDisplay.Text = _basePriceForExamination.ToString();
				}
			}
			catch (Exception)
			{
				throw new ArgumentException("Fejl i Display af rabat");
			}

		}

		private void DiscountNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			if (PriceExaminationDisplay.Text != null && _basePriceForExamination != null)
			{
				PriceExaminationDisplay.Text = (_basePriceForExamination * ((100 - DiscountNumericUpDown.Value) / 100)).ToString();
			}
		}
	}
}
