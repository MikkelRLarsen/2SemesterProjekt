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
using Microsoft.Extensions.DependencyInjection;

namespace _2SemesterProjekt.Pages.UserControls.ExaminationUserControl
{
    public partial class UpdateExaminationPage : UserControl
    {
        private readonly IExaminationService _examinationService;
        private readonly IEmployeeService _employeeService;
        private readonly Examination _examination;
        private readonly ChangeExaminationPage _changeExaminationPage;
        private readonly Panel _mainPagePanel;

        public UpdateExaminationPage(Examination examination, ChangeExaminationPage changeExaminationPage, Panel mainPagePanel)
        {
            InitializeComponent();
            _examination = examination;
            _changeExaminationPage = changeExaminationPage;
            _mainPagePanel = mainPagePanel;

            _examinationService = ServiceProviderSingleton.GetServiceProvider().GetService<IExaminationService>()!;
            _employeeService = ServiceProviderSingleton.GetServiceProvider().GetService<IEmployeeService>()!;
            
        }

        private async void UpdateExaminationPage_Load(object sender, EventArgs e)
        {
            /// Customer of the chosen examination:
            customerSearchTextBox.Text = _examination.Pet.Customer.FirstName;

            /// Pet of the chosen examination:
            
            petDropdown.Enabled = true;
            petDropdown.DataSource = _examination.Pet.Customer.Pets;

            employeeDropdown.DataSource = (await GetListOfEmployeeWithExaminationEmployeeFirst(_examination)).ToList();
            employeeDropdown.DisplayMember = "FirstName";

            DateTimePickerExamination.Value = _examination.Date;
            DateTimePickerExamination.MinDate = DateTime.UtcNow;



            ExaminationTypeDropdown.Text = _examination.ExaminationType.Description;
            PriceExaminationDisplay.Text = _examination.Price.ToString();
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

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Creates a new examinations with updated information, which validates the information
                Examination examinationWithupdatedInformation = new Examination(
                        _examination.PetID,
                        (employeeDropdown.SelectedItem as Employee).EmployeeID,
                        DateTimePickerExamination.Value,
                        _examination.ExaminationTypeID,
                        _examination.Price,
                        _examination.CageBookingID);

                DialogResult messageBoxResult = MessageBox.Show("Er du sikker på, at denne konsultationstid skal ændres?", "Advarsel", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (messageBoxResult != DialogResult.Yes)
                {
                    return;
                }

                // Validates information again and sets the new properties
                _examination.UpdateExaminationProperties(examinationWithupdatedInformation);

                // Updates Examination in Database
                _examinationService.UpdateExamination(_examination);

                MessageBox.Show("Konsultationen er blevet opdateret", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Finds the index of the ExaminationCard to replace
                int index = _changeExaminationPage.AllExaminationCards.FindIndex(exCard => exCard.Examination.ExaminationID == _examination.ExaminationID);

                // Replaces ExaminationCard with a new one with the updated information
                _changeExaminationPage.AllExaminationCards[index] = new ExaminationCardUpdated(_examination, _changeExaminationPage);

                // Set the selected ExaminationCard to null, so its no longer highligted
                _changeExaminationPage.ExaminationCard = null;

                // Return to show all pets
                _changeExaminationPage.LoadAndShowExaminationCards(_changeExaminationPage.AllExaminationCards);
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
    }
}
