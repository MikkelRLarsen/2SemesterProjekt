using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProjekt.Domain.Models;
using _2SemesterProjekt.Pages.UserControls.MainPageWallpaperControl;
using _2SemesterProjekt.Pages.UserControls.UIModels;
using Microsoft.Extensions.DependencyInjection;

namespace _2SemesterProjekt.Pages.UserControls.ExaminationUserControl
{
    public partial class CreateExaminationPage : UserControl
    {
        ICustomerService _customerService;
        IEmployeeService _employeeService;
        IExaminationService _examinationService;
        ICageService _cageService;
        private IEnumerable<Employee> _employees;
        private decimal? _basePriceForExamination;
        private bool _cageBookingIsChecked;
        private Panel _mainPagePanel;
        private Customer _customer;

        public CreateExaminationPage(Panel mainPagePanel)
        {
            InitializeComponent();
            _mainPagePanel = mainPagePanel;
        }

        private void CreateExaminationUserControlUpdate_Load(object sender, EventArgs e)
        {
            ServiceProvider allServices = ServiceProviderSingleton.GetServiceProvider();

            _customerService = allServices.GetService<ICustomerService>()!;
            _employeeService = allServices.GetService<IEmployeeService>()!;
            _examinationService = allServices.GetService<IExaminationService>()!;
            _cageService = allServices.GetService<ICageService>()!;

            SetAllDisplayMembers();
            DateTimePickerExamination.MinDate = DateTime.Now;
        }

        private async void customerSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Wait cursor (hourglass)
                Cursor = Cursors.WaitCursor;
                customerSearchButton.Enabled = false;

                _customer = await _customerService.GetCustomerByPhoneNumberAsync(Convert.ToInt32(customerSearchTextBox.Text));

                petDropdown.Enabled = true;

                // Show only next box if the Customer has Pets
                if (_customer.Pets != null)
                {
                    petDropdown.DataSource = _customer.Pets;
                }

                FilterEmployeeList();
                UpdateDiscountStatus();
                UpdateCageBookingCheckbox();
                customerSearchTextBox.Text = $"{_customer.FirstName} {_customer.LastName}";
                customerSearchButton.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }

            // Wait cursor (hourglass)
            Cursor = Cursors.Default;
            customerSearchButton.Enabled = true;
        }

        private async void petDropdown_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ExaminationTypeDropdown.DataSource = await _examinationService.GetAllExaminationTypesAsync();
            ExaminationTypeDropdown.Enabled = true;

            FilterEmployeeList();
            UpdateCageBookingCheckbox();
        }

        private void ExaminationTypeDropdown_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _basePriceForExamination = (ExaminationTypeDropdown.SelectedItem as ExaminationType).BasePrice;
            PriceExaminationDisplay.Text = _basePriceForExamination.ToString();

            DateTimePickerExamination.Enabled = true;
            UpdateCageBookingCheckbox();
            UpdateDiscountStatus();
        }

        private async void DateTimePickerExamination_ValueChanged(object sender, EventArgs e)
        {
            if (DateTimePickerExamination.Enabled == true)
            {
                employeeDropdown.Enabled = true;

                _employees = await _employeeService.GetAllEmployeeWithTypeAsync("Dyrlæge");

                employeeDropdown.DataSource = _employees;
            }
        }

        private void employeeDropdown_SelectionChangeCommitted(object sender, EventArgs e)
        {
            submitButton.Enabled = true;
            submitButton.Image = Properties.Resources.SaveButton;
            submitButton.BackColor = Color.MediumAquamarine;
        }

        private async void submitButton_Click(object sender, EventArgs e)
        {
            //Resets ErrorMessage when retrying
            string displayMessage = string.Empty;

            // Creates a messagebox if Discount is higher then 60% to confirm the booking of examination
            if (discountNumericUpDown.Value >= 60)
            {
                DialogResult resultFromMessageBox = MessageBox.Show("Er du sikker på at du vil forsætte?", "Valgt rabat er over 60%", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                // If the user press No then abort booking
                if (resultFromMessageBox == DialogResult.No)
                {
                    return;
                }
            }

            try
            {
                CageBooking? cageBooking = null;
                Pet chosenPet = (petDropdown.SelectedItem as Pet)!;
                Employee chosenEmployee = (employeeDropdown.SelectedItem as Employee)!;
                ExaminationType chosenExaminationType = (ExaminationTypeDropdown.SelectedItem as ExaminationType)!;
                DateTime chosenExaminationDate = DateTimePickerExamination.Value;

                if (_cageBookingIsChecked == true) // Create Cage Booking
                {
                    // Validate the cagebooking before creating examination - to ensure no errors is thrown before the creation
                    DateTime estimatedEndOfCageBooking = DateTimePickerExamination.Value.AddDays(Convert.ToDouble(numericUpDownCageBooking.Value));

                    // Gets the available cage for the chosen pet => throws error if nothing is available
                    Cage availableCage = await _cageService.GetAvailableCageAsync(chosenPet, chosenExaminationDate, estimatedEndOfCageBooking);

                    // Creates estimated totalprice for the cage
                    decimal totalPrice = await _cageService.GetTotalPriceForCageAsync(
                        availableCage,
                        chosenExaminationDate,
                        estimatedEndOfCageBooking
                    );

                    // Creates cageBooking to validate information
                    cageBooking = new CageBooking(
                        chosenExaminationDate.Date,
                        estimatedEndOfCageBooking.Date,
                        totalPrice,
                        availableCage.CageID
                    );

                    // Then creates/updates cagebooking
                    await _cageService.CreateCageBookingAsync(cageBooking);

                    // Creates the new Examination as a local variable to run validate Information.
                    Examination newExamination = new Examination(
                            chosenPet.PetID,
                            chosenEmployee.EmployeeID,
                            chosenExaminationDate,
                            chosenExaminationType.ExaminationTypeID,
                            Convert.ToDecimal(PriceExaminationDisplay.Text),
                            cageBooking.CageBookingID
                    );


                    // First creates examination
                    await _examinationService.CreateExaminationAsync(newExamination);

                    // Connects cagebooking to examination
                    newExamination.SetCageBookingID(cageBooking.CageBookingID);

                    // Add the new examination to AllExaminationCard on KonsultationPage, so it shows when reloaded
                    //_konsultationPage.AllExaminationCards.Add(new ExaminationCard(newExamination, _konsultationPage));

                    // Return to show all pets
                    //_konsultationPage.LoadAndShowExaminationCards(_konsultationPage.AllExaminationCards);
                }
                else // Don't create cagebooking
                {
                    // Creates the new Examination as a local variable to run validate Information.
                    Examination newExamination = new Examination(
                            chosenPet.PetID,
                            chosenEmployee.EmployeeID,
                            chosenExaminationDate,
                            chosenExaminationType.ExaminationTypeID,
                            Convert.ToDecimal(PriceExaminationDisplay.Text),
                            null
                    );

                    await _examinationService.CreateExaminationAsync(newExamination);

                    // Add the new examination to AllExaminationCard on KonsultationPage, so it shows when reloaded
                    //_konsultationPage.AllExaminationCards.Add(new ExaminationCard(newExamination, _konsultationPage));

                    // Return to show all pets
                    //_konsultationPage.LoadAndShowExaminationCards(_konsultationPage.AllExaminationCards);
                }

                //Shows a message that the creation has been completed
                displayMessage = "Behandling er oprettet";
                MessageBox.Show(displayMessage);
            }
            catch (Exception ex)
            {
                //Shows error message if an error happend
                MessageBox.Show($"{ex}");
            }
        }

        /// <summary>
        /// Set DisplayMembers foreach Combobox/Dropdown
        /// </summary>
        private void SetAllDisplayMembers()
        {
            petDropdown.DisplayMember = "Name";
            employeeDropdown.DisplayMember = "FirstName";
            ExaminationTypeDropdown.DisplayMember = "Description";
        }

        /// <summary>
        /// Returns user back to prior page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            //_konsultationPanel.Controls.Clear();
            _mainPagePanel.Controls.Remove(this);
            _mainPagePanel.Controls.Add(new MainPageWallpaper());

        }

        private void PriceExaminationDisplay_TextChanged(object sender, EventArgs e)
        {
            PriceExaminationDisplay.BackColor = Color.White;
            PriceExaminationDisplay.ForeColor = Color.Black;
        }

        private void UpdateDiscountStatus()
        {
            try
            {
                // Checks if selected Customer is Private and ExaminationTag is 2 which is Operation
                if (_customer.Type == "Privat"
                    && ExaminationTypeDropdown.SelectedItem as ExaminationType != null
                    && (ExaminationTypeDropdown.SelectedItem as ExaminationType).ExaminationTag.ExaminationTagID == 2)
                {
                    discountNumericUpDown.Enabled = true;
                }
                // Checks if selected Customer is Erhverv
                else if (_customer.Type == "Erhverv")
                {
                    discountNumericUpDown.Visible = true;
                    discountNumericUpDown.Enabled = true;
                    discountLabel.Visible = true;
                }

                else
                {
                    discountNumericUpDown.Visible = false;
                    discountNumericUpDown.Enabled = false;
                    discountNumericUpDown.Value = 0;
                    PriceExaminationDisplay.Text = _basePriceForExamination.ToString();
                }
            }
            catch (Exception)
            {
                throw new ArgumentException("Fejl i Display af rabat");
            }
        }

        private void discountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (PriceExaminationDisplay.Text != null && _basePriceForExamination != null)
            {
                PriceExaminationDisplay.Text = (_basePriceForExamination * ((100 - discountNumericUpDown.Value) / 100)).ToString();
            }
        }

        private void UpdateCageBookingCheckbox()
        {
            if (ExaminationTypeDropdown.SelectedItem != null)
            {
                if ((ExaminationTypeDropdown.SelectedItem as ExaminationType)!.ExaminationTag.DescriptionTag == "Operation" &&
                    ((petDropdown.SelectedItem as Pet)!.SpeciesID == 1 || // ID 1 = dog
                    (petDropdown.SelectedItem as Pet)!.SpeciesID == 2)) // ID 2 = cat
                {
                    cageBookingLabel.Visible = true;
                    cageBookingCheckBox.Visible = true;
                    cageBookingNumberOfDaysLabel.Visible = true;
                    numericUpDownCageBooking.Visible = true;
                }
                else
                {
                    cageBookingLabel.Visible = false;
                    cageBookingCheckBox.Visible = false;
                    cageBookingNumberOfDaysLabel.Visible = false;
                    numericUpDownCageBooking.Visible = false;
                }
            }
        }

        private void FilterEmployeeList()
        {
            if (_employees != null)
            {
                var filteredList = _employees
                        .Where(em => em.EmployeeID != (petDropdown.SelectedItem as Pet).EmployeeID)
                        .Prepend(_employees.First(e => e.EmployeeID == (petDropdown.SelectedItem as Pet).EmployeeID));
            }
        }

        private void customerSearchButton_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void customerSearchButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void cancelButton_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void cancelButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void submitButton_MouseEnter(object sender, EventArgs e)
        {
            if (submitButton.Enabled == true)
            {
                Cursor = Cursors.Hand;
            }
        }

        private void submitButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void cageBookingCheckBox_Click(object sender, EventArgs e)
        {
            _cageBookingIsChecked = !_cageBookingIsChecked;

            if (_cageBookingIsChecked == true)
            {
                cageBookingCheckBox.Image = Properties.Resources.CheckBoxClicked;
            }
            else
            {
                cageBookingCheckBox.Image = Properties.Resources.CheckBox;
            }
        }

        private void cageBookingCheckBox_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void cageBookingCheckBox_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void customerSearchTextBox_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(customerSearchTextBox.Text) && !Int32.TryParse(customerSearchTextBox.Text, out int _))
            {
                customerSearchTextBox.Text = string.Empty;
                customerSearchButton.Enabled = true;
            }
        }

        private void customerSearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // The user is only able to enter numbers in the textbox.
            }
        }

        // AUTO FILL-IN BEGIN:
        // ProcessCmdKey is a method in the Control class (inherited by UserControl and Form)
        // that intercepts keyboard commands before they are sent to the focused control.
        // This makes it ideal for global shortcuts, like Ctrl+F, regardless of which control has focus.
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.F))
            {
                TriggerAutoCustomerSearchFillIn();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        private async void TriggerAutoCustomerSearchFillIn()
        {
            ///Customer phonenumber to fill in:
            customerSearchTextBox.Text = "12345678";
        }// AUTO FILL-IN END:
    }
}
