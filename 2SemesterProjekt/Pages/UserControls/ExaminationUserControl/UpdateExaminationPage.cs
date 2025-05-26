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
using _2SemesterProjekt.Services;
using Microsoft.Extensions.DependencyInjection;

namespace _2SemesterProjekt.Pages.UserControls.ExaminationUserControl
{
    public partial class UpdateExaminationPage : UserControl
    {
        private readonly IExaminationService _examinationService;
        private readonly IEmployeeService _employeeService;
        private readonly ICageService _cageService;
        private readonly Examination _examination;
        private readonly ChangeExaminationPage _changeExaminationPage;
        private readonly Panel _mainPagePanel;
        private decimal? _basePriceForExamination;
        private bool _cageBookingIsChecked;
     
        public UpdateExaminationPage(Examination examination, ChangeExaminationPage changeExaminationPage, Panel mainPagePanel)
        {
            InitializeComponent();
            _examination = examination;
            _changeExaminationPage = changeExaminationPage;
            _mainPagePanel = mainPagePanel;

            ServiceProvider allServices = ServiceProviderSingleton.GetServiceProvider();
            _examinationService = allServices.GetService<IExaminationService>()!;
            _employeeService = allServices.GetService<IEmployeeService>()!;
            _cageService = allServices.GetService<ICageService>()!;
        }

        private async void UpdateExaminationPage_Load(object sender, EventArgs e)
        {
            /// Customer of the chosen examination:
            customerSearchTextBox.Text = _examination.Pet.Customer.FirstName;

            /// Pet of the chosen examination (+ the customer's other pets):
            petDropdown.Enabled = true;
            petDropdown.DataSource = _examination.Pet.Customer.Pets;
            petDropdown.DisplayMember = "Name";
            petDropdown.SelectedItem = _examination.Pet;

            /// Examination of the chosen examination and its price (+ all the other examinations and their prices):
            ExaminationTypeDropdown.Enabled = true;
            var allExaminationTypes = await _examinationService.GetAllExaminationTypesAsync();
            ExaminationTypeDropdown.DataSource = allExaminationTypes.ToList();
            ExaminationTypeDropdown.DisplayMember = "Description";
            ExaminationTypeDropdown.SelectedItem = _examination.ExaminationType;
            /// Price - also changes dynamically when new examinationType is chosen via Eventhandler: ExaminationTypeDropdown_SelectionChangeCommitted.
            PriceExaminationDisplay.Text = _examination.Price.ToString();

            /// Date of the chosen examination (+ ability to change):
            DateTimePickerExamination.Enabled = true;
            DateTimePickerExamination.Value = _examination.Date;
            DateTimePickerExamination.MinDate = DateTime.UtcNow;

            /// Employee of the chosen examination (+ all the other employees):
            employeeDropdown.Enabled = true;
            employeeDropdown.DataSource = (await GetListOfEmployeeWithExaminationEmployeeFirst(_examination)).ToList();
            employeeDropdown.DisplayMember = "FirstName";

            /// Discount:
            UpdateDiscountStatus();

            /// Cage booking:
            UpdateCageBookingCheckbox();
            CageBookingStatus();

            /// Button (needs work):
            updateButton.Enabled = true;
            updateButton.Image = Properties.Resources.SaveButton;


        }

        private async Task<IEnumerable<Employee>> GetListOfEmployeeWithExaminationEmployeeFirst(Examination examination)
        {
            // Gets all PetDoctorsFromDatabase
            IEnumerable<Employee> allPetDocterFromDatabase = await _employeeService.GetAllEmployeeWithTypeAsync("Dyrlæge");

            // Creates a new IEnumerable without examinations employee
            var filteredList = allPetDocterFromDatabase.Where(em => em.EmployeeID != examination.EmployeeID);

            // Adds the Employee back, but first in the IEnumerable
            return filteredList.Prepend(examination.Employee);
        }

        private async void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                CageBooking? cageBooking = null;
                Pet chosenPet = (petDropdown.SelectedItem as Pet)!;
                Employee chosenEmployee = (employeeDropdown.SelectedItem as Employee)!;
                ExaminationType chosenExaminationType = (ExaminationTypeDropdown.SelectedItem as ExaminationType)!;
                DateTime chosenExaminationDate = DateTimePickerExamination.Value;

                if (_cageBookingIsChecked == true) /// Create Cage Booking
                {
                    /// User confirmation:
                    DialogResult messageBoxResult = MessageBox.Show("Er du sikker på, at denne konsultationstid skal ændres?", "Advarsel", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (messageBoxResult != DialogResult.Yes)
                    {
                        return;
                    }

                    /// Validate the cagebooking before creating examination - to ensure no errors is thrown before the creation
                    DateTime estimatedEndOfCageBooking = DateTimePickerExamination.Value.AddDays(Convert.ToDouble(numericUpDownCageBooking.Value));

                    /// Gets the available cage for the chosen pet => throws error if nothing is available
                    Cage availableCage = await _cageService.GetAvailableCageAsync(chosenPet, chosenExaminationDate, estimatedEndOfCageBooking);

                    /// Creates estimated totalprice for the cage
                    decimal totalPrice = await _cageService.GetTotalPriceForCage(
                        availableCage,
                        chosenExaminationDate,
                        estimatedEndOfCageBooking
                    );

                    /// Creates cageBooking to validate information
                    cageBooking = new CageBooking(
                        chosenExaminationDate.Date,
                        estimatedEndOfCageBooking.Date,
                        totalPrice,
                        availableCage.CageID
                    );

                    /// Updates cage booking in database:
                    await _cageService.CreateCageBookingAsync(cageBooking);

                    /// Creates a new examination with updated information, which validates the information
                    Examination examinationWithupdatedInformationYesCage = new Examination(
                        (petDropdown.SelectedItem as Pet).PetID,
                        (employeeDropdown.SelectedItem as Employee).EmployeeID,
                        DateTimePickerExamination.Value,
                        (ExaminationTypeDropdown.SelectedItem as ExaminationType).ExaminationTypeID,
                        Convert.ToDecimal(PriceExaminationDisplay.Text),
                        cageBooking.CageBookingID
                        );

                    /// Validates information again and sets the new properties
                    _examination.UpdateExaminationProperties(examinationWithupdatedInformationYesCage);

                    /// Updates examination in database:
                    await _examinationService.UpdateExamination(_examination);
                }
                else /// Update examination without cagebooking:
                {
                    /// User confirmation:
                    DialogResult messageBoxResult = MessageBox.Show("Er du sikker på, at denne konsultationstid skal ændres?", "Advarsel", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (messageBoxResult != DialogResult.Yes)
                    {
                        return;
                    }

                    Examination examinationWithupdatedInformationNoCage = new Examination(
                        (petDropdown.SelectedItem as Pet).PetID,
                        (employeeDropdown.SelectedItem as Employee).EmployeeID,
                        DateTimePickerExamination.Value,
                        (ExaminationTypeDropdown.SelectedItem as ExaminationType).ExaminationTypeID,
                        Convert.ToDecimal(PriceExaminationDisplay.Text),
                        null
                        );

                    /// Validates information again and sets the new properties
                    _examination.UpdateExaminationProperties(examinationWithupdatedInformationNoCage);

                    /// Updates Examination in Database
                    _examinationService.UpdateExamination(_examination);
                }

                MessageBox.Show("Konsultationen er blevet opdateret", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                /// Finds the index of the ExaminationCard to replace
                int index = _changeExaminationPage.AllExaminationCards.FindIndex(exCard => exCard.Examination.ExaminationID == _examination.ExaminationID);

                /// Replaces ExaminationCard with a new one with the updated information
                _changeExaminationPage.AllExaminationCards[index] = new ExaminationCardUpdated(_examination, _changeExaminationPage);

                /// Set the selected ExaminationCard to null, so its no longer highligted
                _changeExaminationPage.ExaminationCard = null;

                /// Return to show all pets
                _changeExaminationPage.LoadAndShowExaminationCards(_changeExaminationPage.AllExaminationCards);

                /// Return to ChangeExaminationPage after completed update:
                _mainPagePanel.Controls.Remove(this);
                _mainPagePanel.Controls.Add(_changeExaminationPage);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            _mainPagePanel.Controls.Remove(this);
            _mainPagePanel.Controls.Add(_changeExaminationPage);
        }

        /// <summary>
        /// Changes price when a different examination is chosen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExaminationTypeDropdown_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _basePriceForExamination = (ExaminationTypeDropdown.SelectedItem as ExaminationType).BasePrice;
            PriceExaminationDisplay.Text = _basePriceForExamination.ToString();
            UpdateCageBookingCheckbox();
        }

        /// <summary>
        /// Cage booking functionality shows up if examinationType is operation.
        /// </summary>
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
                    cageBookingCheckBox.Enabled = true;
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

        /// <summary>
        /// Functionality for the cage booking checkbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Sets the cage booking checkbox to clicked or not:
        /// </summary>
        private void CageBookingStatus()
        {
            if (_examination.CageBookingID != null)
            {
                cageBookingCheckBox.Image = Properties.Resources.CheckBoxClicked;

                int numberOfCageDays = (_examination.CageBooking.EndDate - _examination.CageBooking.StartDate).Days;
                numericUpDownCageBooking.Value = numberOfCageDays;
            }
            else
            {
                _cageBookingIsChecked = false;
                cageBookingCheckBox.Image = Properties.Resources.CheckBox;
            }
        }
        private void UpdateDiscountStatus()
        {
            try
            {
                // Checks if selected Customer is Private and ExaminationTag is 2 which is Operation
                if (_examination.Pet.Customer.Type == "Privat"
                    && ExaminationTypeDropdown.SelectedItem as ExaminationType != null
                    && (ExaminationTypeDropdown.SelectedItem as ExaminationType).ExaminationTag.ExaminationTagID == 2)
                {
                    discountNumericUpDown.Visible = true;
                    discountNumericUpDown.Enabled = true;
                    discountLabel.Visible = true;
                }
                // Checks if selected Customer is Erhverv
                else if (_examination.Pet.Customer.Type == "Erhverv")
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
    }
}
