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
        private ExaminationCard ExaminationCard;
        //public Examination Examination { get; set; }
        //private Medicine Medicine;
        public MedicineUserControl(FlowLayoutPanel konsultationPanel, ExaminationCard examinationCard)
        {
            InitializeComponent();
            _konsultationPanel = konsultationPanel;
            ExaminationCard = examinationCard;
            
            //Hardcode muligheder til ordinering af medicin:
            OrdineretDropdownBox.Items.AddRange(new string[] { "Ja", "Nej" });

            //PetNameTextBox.Text = ExaminationCard._examination.Pet.Name;

        }
        private void MedicineUserControl_Load(object sender, EventArgs e)
        {
            //PetNameTextBox.Text = ExaminationCard._examination.Pet.Name;
        }

        private void OrdineretDropdownBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectedValue = OrdineretDropdownBox.SelectedItem.ToString();

            if (selectedValue == "Ja" && ExaminationCard._examination.MedicineID != null)
            {
                PetNameTextBox.Text = ExaminationCard._examination.Pet.Name;
                MedicineDropdownBox.Text = ExaminationCard._examination.Medicine.Name;
                MedicineTypeTextBox.Text = ExaminationCard._examination.Medicine.Type;
                MedicineMiligramTextBox.Text = ExaminationCard._examination.Medicine.DoseMiligram.ToString();
                MedicineDosesPerDayTextBox.Text = ExaminationCard._examination.Medicine.DosesTake24Hours.ToString();
                MedicineNumberOfDaysTextBox.Text = ExaminationCard._examination.Medicine.DoseDurationDays.ToString();
            }
            else if (selectedValue == "Nej" && ExaminationCard._examination.MedicineID != null)
            {
                MessageBox.Show($"Der er ordineret medicin til {ExaminationCard._examination.Pet.Name}. Klik på 'ja'!");
            }
            else if (selectedValue == "Nej" && ExaminationCard._examination.MedicineID == null)
            {
                MessageBox.Show("Ingen medicin registreret.");
                MedicineDropdownBox.Enabled = false;
            }
        }
    }
}
