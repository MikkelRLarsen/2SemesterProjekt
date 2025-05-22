using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProjekt.Domain.Models;
using Microsoft.Extensions.DependencyInjection;

namespace _2SemesterProjekt.Pages.UserControls.PetUserControl
{
	public partial class CreatePetPage : UserControl
	{

		private IPetService _petService;
		private ICustomerService _customerService;
		private IEmployeeService _employeeService;

		public CreatePetPage()
		{
			InitializeComponent();
		}

		private async void CreatePetPage_Load(object sender, EventArgs e)
		{
			_petService = ServiceProviderSingleton.GetServiceProvider().GetService<IPetService>()!;
			_customerService = ServiceProviderSingleton.GetServiceProvider().GetService<ICustomerService>()!;
			_employeeService = ServiceProviderSingleton.GetServiceProvider().GetService<IEmployeeService>()!;

			DateTimePickerBirthday.MaxDate = DateTime.Now;

			// Species dropdown load
			var petSpecies = await _petService.GetAllPetSpeciesAsync();
			ComboBoxPetSpecies.DataSource = petSpecies;
			ComboBoxPetSpecies.DisplayMember = "Name";

			// Veterinarians dropdown load
			var dropDownItems = new List<object> { "Ikke valgt" }; // Add not chosen option
			var veterinarians = await _employeeService.GetAllEmployeeWithTypeAsync("Dyrlæge");

			dropDownItems.AddRange(veterinarians);

			ComboBoxPetDoctor.DataSource = dropDownItems;
			ComboBoxPetDoctor.DisplayMember = "FirstName";

			ComboBoxPetDoctor.Format += ComboBoxPrimaryVeterinarian_Format!;
		}

		/// <summary>
		/// Goes through the list and displays employees first names
		/// </summary>
		private void ComboBoxPrimaryVeterinarian_Format(object sender, ListControlConvertEventArgs e)
		{
			if (e.ListItem is Employee employee) // Show first name if hit is employee
			{
				e.Value = employee.FirstName;
			}
			//else // Make the item to a string
			//{
			//	e.Value = e.ListItem!.ToString();
			//}
		}

		private void textBoxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true; // The user is only able to enter numbers in the textbox.
			}
		}

		private void ComboBoxPetDoctor_SelectionChangeCommitted(object sender, EventArgs e)
		{
			CheckAndEnableButton();
		}

		private void CheckAndEnableButton()
		{
			if (textBoxPetName.Text.Length == 0)
			{
				return;
			}

			if (textBoxPhoneNumber.Text.Length == 0)
			{
				return;
			}

			if (ComboBoxPetDoctor.SelectedIndex == 0)
			{
				return;
			}

			submitButton.Image = Properties.Resources.SaveButton;
		}

		private async void submitButton_Click(object sender, EventArgs e)
		{
			string displayMessage = string.Empty;

			// Validate phonenumber: only numbers and 8-digit long.
			if (!Int32.TryParse(textBoxPhoneNumber.Text, out int phoneNumber) || textBoxPhoneNumber.Text[0] == '0' || phoneNumber < 10000000 || phoneNumber > 99999999)
			{
				textBoxPhoneNumber.ForeColor = Color.White;
				textBoxPhoneNumber.BackColor = Color.LightCoral;
				displayMessage += "Telefonnummer skal være et helt 8-cifret tal.\n";
			}

			// Validate pet name input
			if (string.IsNullOrWhiteSpace(textBoxPetName.Text))
			{
				textBoxPetName.ForeColor = Color.White;
				textBoxPetName.BackColor = Color.LightCoral;
				displayMessage += "Indtast et gyldigt kæledyrsnavn.\n";
			}

			int customerId;
			try
			{
				customerId = (await _customerService.GetCustomerByPhoneNumberAsync(phoneNumber)).CustomerID; // Retrieves the customer's ID by using the entered phone number.
			}
			catch (Exception)
			{

				textBoxPhoneNumber.ForeColor = Color.White;
				textBoxPhoneNumber.BackColor = Color.LightCoral;
				displayMessage += "Kunden med dette telefonnummer findes ikke i systemet.";
				customerId = 0; //Place holder value
			}


			var selectedVet = ComboBoxPetDoctor.SelectedItem as Employee;

			if (displayMessage == string.Empty)
			{
				try
				{
					var pet = new Pet(
						customerId,
						textBoxPetName.Text,
						(ComboBoxPetSpecies.SelectedItem as Species).SpeciesID,
						DateTimePickerBirthday.Value,
						selectedVet?.EmployeeID
					); /* Instantiating a Pet object with
                      the retrieved customer ID and the
                      text inside the textboxes.*/

					if (_petService.CheckIfPetExists(pet)) // Error message if the pet already exists
					{
						displayMessage += "Kæledyret findes allerede i databasen.";
					}
					else //If not, the pet will be saved to the DB through the service and a success message will appear.
					{
						await _petService.CreatePetAsync(pet); // The newly instantiated Pet object gets added to the DB.
						displayMessage += $"{pet.Name} er blevet tilføjet til systemet.";
						//_petPage.RefreshPetList(); // Refresh PetPages petlist to reflect changes
						//_petPage.Controls.Remove(this); // Clear existing content
					}
				}
				catch (Exception ex)
				{
					displayMessage += $"{ex}";
				}
			}

			MessageBox.Show(displayMessage, "Information", MessageBoxButtons.OK);
		}

		// AUTO FILL-IN BEGIN!
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		// ProcessCmdKey is a method in the Control class (inherited by UserControl and Form)
		// that intercepts keyboard commands before they are sent to the focused control.
		// This makes it ideal for global shortcuts, like Ctrl+F, regardless of which control has focus.
		{
			if (keyData == (Keys.Control | Keys.F))
			{
				TriggerAutoPetFillIn();
				return true;
			}

			return base.ProcessCmdKey(ref msg, keyData);
		}
		private async void TriggerAutoPetFillIn()
		{
			/// Phone number to fill in:
			textBoxPhoneNumber.Text = "12345678";

			/// Pet species to fill in:
			var petSpecies = await _petService.GetAllPetSpeciesAsync();
			ComboBoxPetSpecies.DataSource = petSpecies;
			var speciesToSelect = petSpecies.FirstOrDefault(s => s.Name == "Kat");
			if (speciesToSelect != null)
			{
				ComboBoxPetSpecies.SelectedItem = speciesToSelect;
			}

			/// Pet name to fill in:
			textBoxPetName.Text = "Kjartan";

			/// Pet birthday to fill in:
			DateTimePickerBirthday.Value = DateTime.Today.AddDays(-1);

			/// Pet doctor to fill in:
			var petDoctor = await _employeeService.GetAllEmployeeWithTypeAsync("Dyrlæge");
			ComboBoxPetDoctor.DataSource = petDoctor;
			var doctorToSelect = petDoctor.FirstOrDefault(e => e.FirstName == "Peter");
			if (doctorToSelect != null)
			{
				ComboBoxPetDoctor.SelectedItem = doctorToSelect;
			}
			CheckAndEnableButton();
        }// AUTO FILL-IN END!
    }
}
