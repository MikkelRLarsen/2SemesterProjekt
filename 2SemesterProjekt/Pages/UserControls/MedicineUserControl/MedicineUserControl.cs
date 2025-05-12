using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2SemesterProjekt.Pages.UserControls.ExaminationUserControl;
using _2SemesterProjekt.Domain.Models;
using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProjekt.Services;
using Microsoft.Extensions.DependencyInjection;

namespace _2SemesterProjekt.Pages.UserControls.MedicineUserControl
{
    public partial class MedicineUserControl : UserControl
    {
        private readonly IMedicineService _medicineService;

        FlowLayoutPanel _konsultationPanel;
        public ExaminationCard ExaminationCard;
        
        public MedicineUserControl(FlowLayoutPanel konsultationPanel, ExaminationCard examinationCard)
        {
            InitializeComponent();
            _konsultationPanel = konsultationPanel;
            ExaminationCard = examinationCard;
            
            _medicineService = ServiceProviderSingleton.GetServiceProvider().GetService<IMedicineService>()!;

            // Display general information:
            PetNameLabel.Text = ExaminationCard._examination.Pet.Name;
            

            // Display status (ja/nej/ukendt) along with different kinds of information based on status:
            if (ExaminationCard._examination.Date > DateTime.Now)
            {
                MedicineStatusLabel.Text = "Ukendt";
                ActualMedicineNameLabel.Text = "Ukendt";
                ActualMedicineTypeLabel.Text = "Ukendt";
                ActualMedicineMilligramLabel.Text = "Ukendt";
                ActualMedicineDosesPerDayLabel.Text = "Ukendt";
                ActualMedicineNumberOfDaysLabel.Text = "Ukendt";
                ActualMedicineStartDateLabel.Text = "Ukendt";
                ActualMedicineEndDateLabel.Text = "Ukendt";
                ManualDateTimePicker.Enabled = false;
                ChangeStartDateButton.Enabled = false;
            }
            else if (ExaminationCard._examination.Medicine?.MedicineID != null)
            {
                MedicineStatusLabel.Text = "Ja";
                ActualMedicineNameLabel.Text = examinationCard._examination.Medicine.Name;
                ActualMedicineTypeLabel.Text = examinationCard._examination.Medicine.Type;
                ActualMedicineMilligramLabel.Text = examinationCard._examination.Medicine.DoseMiligram.ToString();
                ActualMedicineDosesPerDayLabel.Text = examinationCard._examination.Medicine.DosesTake24Hours.ToString();
                ActualMedicineNumberOfDaysLabel.Text = examinationCard._examination.Medicine.DoseDurationDays.ToString();
                ActualMedicineStartDateLabel.Text = examinationCard._examination.Date.ToShortDateString();
                // End date:
                DateTime startDate = examinationCard._examination.Date;
                int durationDays = examinationCard._examination.Medicine.DoseDurationDays;
                DateTime endDate = startDate.AddDays(durationDays - 1);
                ActualMedicineEndDateLabel.Text = endDate.ToShortDateString();
                // Manual date:
                ManualDateTimePicker.MinDate = examinationCard._examination.Date; // You cannot set a date in the past.
                ManualDateTimePicker.Value = examinationCard._examination.Date; // Default medicine start date is the date of the examination.
            }
            else
            {
                MedicineStatusLabel.Text = "Nej";
                ActualMedicineNameLabel.Text = "Ingen";
                ActualMedicineTypeLabel.Text = "";
                ActualMedicineMilligramLabel.Text = "";
                ActualMedicineDosesPerDayLabel.Text = "";
                ActualMedicineNumberOfDaysLabel.Text = "";
                ActualMedicineStartDateLabel.Text = "";
                ActualMedicineEndDateLabel.Text = "";
                ManualDateTimePicker.Enabled = false;
                ChangeStartDateButton.Enabled = false;
            }
        }
        /// <summary>
        /// Allows the user to set the start date for medicine manually and updates the user control with the new start and end dates.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManualDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (ExaminationCard._examination.Medicine != null)
            {
                DateTime startDate = ManualDateTimePicker.Value;
                int durationDays = ExaminationCard._examination.Medicine.DoseDurationDays;
                DateTime endDate = startDate.AddDays(durationDays - 1); // -1 to include the starting day.
                ActualMedicineStartDateLabel.Text = startDate.ToShortDateString();
                ActualMedicineEndDateLabel.Text = endDate.ToShortDateString();

                // Set the manually picked date as the new start date:
                ExaminationCard._examination.Medicine.UpdateMedicineStartDate(startDate);
            }
        }
        /// <summary>
        /// Saves the manually set start date to db.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ChangeStartDateButton_Click(object sender, EventArgs e)
        {
            await _medicineService.UpdateMedicineAsync(ExaminationCard._examination.Medicine);
            MessageBox.Show("Datoen for start af medicin er blevet ændret.");
            _konsultationPanel.Controls.Clear();
        }
    }
}
