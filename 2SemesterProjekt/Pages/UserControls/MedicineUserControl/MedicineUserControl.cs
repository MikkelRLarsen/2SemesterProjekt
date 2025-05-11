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

namespace _2SemesterProjekt.Pages.UserControls.MedicineUserControl
{
    public partial class MedicineUserControl : UserControl
    {
        FlowLayoutPanel _konsultationPanel;
        public ExaminationCard ExaminationCard;
        //public Examination Examination { get; set; }
        //private Medicine Medicine;
        public MedicineUserControl(FlowLayoutPanel konsultationPanel, ExaminationCard examinationCard)
        {
            InitializeComponent();
            _konsultationPanel = konsultationPanel;
            ExaminationCard = examinationCard;

            // Display general information:
            PetNameLabel.Text = ExaminationCard._examination.Pet.Name;

            // Display status along with different kinds of information based on status:
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
            }
        }

        private void ManualDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = ManualDateTimePicker.Value;
            int durationDays = ExaminationCard._examination.Medicine.DoseDurationDays;
            DateTime endDate = startDate.AddDays(durationDays - 1);
            ActualMedicineStartDateLabel.Text = startDate.ToShortDateString();
            ActualMedicineEndDateLabel.Text = endDate.ToShortDateString();

            // Set the manually picked date as the new start date:
            ExaminationCard._examination.Date = startDate;
        }
    }
}
