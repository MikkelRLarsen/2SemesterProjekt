using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2SemesterProjekt.Domain.Models;
using _2SemesterProjekt.Pages.UserControls.UserControlInterfaces;

namespace _2SemesterProjekt.Pages.UserControls.ExaminationUserControl
{
    public partial class ExaminationCardUpdated : UserControl
    {
        public Examination Examination { get; }
        private readonly IExaminationCardHost _host;

        public ExaminationCardUpdated(Examination examination, IExaminationCardHost host)
        {
            Examination = examination;
            _host = host;
            InitializeComponent();
            InitializeUIDesign();
            AddMoveHandlers(this);
        }

		private void AddMoveHandlers(Control control)
		{
            control.Click += pictureBox_Click;

			// Add the same handler to each of the control.Controls.
			foreach (Control child in control.Controls)
			{
				AddMoveHandlers(child);
			}
		}

		private void InitializeUIDesign()
        {
            // Sets all information on Card based on Examination
            petNameLabel.Text = Examination.Pet.Name;
            petSpeciesLabel.Text = Examination.Pet.Species.Name;
            birthdayLabel.Text = Examination.Pet.Birthday.ToShortDateString();

            examinationLabel.Text = Examination.ExaminationType.Description;
            dateLabel.Text = Examination.Date.ToShortDateString();
            statusLabel.Text = DateTime.Now > Examination.Date ? "Fuldført" : "Kommende";

            customerNameLabel.Text = $"{Examination.Pet.Customer.FirstName} {Examination.Pet.Customer.LastName}";
            customerPhoneNumberLabel.Text = Examination.Pet.Customer.PhoneNumber.ToString();

            employeeNameLabel.Text = Examination.Employee.FirstName;

            if (Examination.Date > DateTime.Now) // Brugervenlighed: Status er ikke beskrivende nok til medicin med ja/nej/ukendt tilknyttet.
            {
                medicineStatusLabel.Text = "Ukendt";
            }
            else if (Examination.MedicinePrescriptions.Count > 0)
            {
                medicineStatusLabel.Text = "Ja";
            }
            else
            {
                medicineStatusLabel.Text = "Nej";
            }

            petPicture.Image = GetImage(Examination.Pet.Species.Name);
        }

        /// <summary>
        /// Finds matching image for pet species in resources
        /// </summary>
        private Image GetImage(string speciesName)
        {
            var image = (Image)Properties.Resources.ResourceManager.GetObject(speciesName)!;

            return image;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            _host.OnCardSelected(this);
        }

        public void SetSelected(bool selected)
        {
            if (selected == true)
            {
                pictureBox.Image = Properties.Resources.CardExaminationSelected;
            }
            else
            {
                pictureBox.Image = Properties.Resources.CardExamination;
            }
        }
    }
}
