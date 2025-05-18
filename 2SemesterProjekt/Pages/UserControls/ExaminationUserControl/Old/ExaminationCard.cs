using _2SemesterProjekt.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2SemesterProjekt.Pages.UserControls.ExaminationUserControl
{
	public partial class ExaminationCard : UserControl
	{
		public Examination Examination { get; }

        private KonsultationPage _examinationPage;

        public ExaminationCard(Examination examination, KonsultationPage examinationPage)
        {
            Examination = examination;
            _examinationPage = examinationPage;
            InitializeComponent();
            InitializeUIDesign();
        }

        private void InitializeUIDesign()
        {
            // Sets all information on Card based on Examination
            PetNameLabel.Text = Examination.Pet.Name;
            PetSpeciesLabel.Text = Examination.Pet.Species.Name;
            BirthdayLabel.Text = Examination.Pet.Birthday.ToShortDateString();

            ExaminationLabel.Text = Examination.ExaminationType.Description;
            DateLabel.Text = Examination.Date.ToShortDateString();
            StatusLabel.Text = DateTime.Now > Examination.Date ? "Fuldført" : "Kommende";

            CustomerNameLabel.Text = Examination.Pet.Customer.FirstName;
            CustomerPhoneNumberLabel.Text = Examination.Pet.Customer.PhoneNumber.ToString();

            EmployeeNameLabel.Text = Examination.Employee.FirstName;

            if (Examination.Date > DateTime.Now) // Brugervenlighed: Status er ikke beskrivende nok til medicin med ja/nej/ukendt tilknyttet.
            {
                MedicineStatusLabel.Text = "Ukendt";
            }
            else if (Examination.Medicine?.MedicineID != null)
            {
                MedicineStatusLabel.Text = "Ja";
            }
            else
            {
                MedicineStatusLabel.Text = "Nej";
            }

            PetPicture.Image = GetImage(Examination.Pet.Species.Name);

        }

        private void CollapsePictureBox_Click(object sender, EventArgs e)
        {
            // Not Yet Implemented. Might be implemented in later Sprint
            //Expand or Collapse the Card to show more or less information
        }

        private void collapseTimer_Tick(object sender, EventArgs e)
        {
            // Not Yet Implemented. Might be implemented in later Sprint
            // For later use. Expand the UserControl
        }

        /// <summary>
        /// Finds matching image for pet species in resources
        /// </summary>
        private Image GetImage(string speciesName)
        {
            var image = (Image)Properties.Resources.ResourceManager.GetObject(speciesName)!;

            return image;
        }

        private void ExaminationCard_Click(object sender, EventArgs e)
        {
            if (_examinationPage.ExaminationCard != null) // protects against null reference exceptions the first time it's clicked
            {
                _examinationPage.ExaminationCard.BackColor = SystemColors.Window; // If a card was previously selected, reset its background color
            }

            _examinationPage.ExaminationCard = this; // Set the currently clicked card as the new selected card

            this.BackColor = SystemColors.ActiveBorder; 
        }
    }
}
