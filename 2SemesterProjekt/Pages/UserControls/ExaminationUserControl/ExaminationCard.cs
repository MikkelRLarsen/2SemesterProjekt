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
		// private readonly Examination _examination;

		private readonly KonsultationPage _examinationPage;
		public Examination _examination { get; }

		public ExaminationCard(Examination examination, KonsultationPage examinationPage)
		{
			_examination = examination;
			_examinationPage = examinationPage;
			InitializeComponent();
			InitializeUIDesign();
		}

		private void InitializeUIDesign()
		{
			// Sets all information on Card based on Examination
			PetNameLabel.Text = _examination.Pet.Name;
			PetSpeciesLabel.Text = _examination.Pet.Species;
			BirthdayLabel.Text = _examination.Pet.Birthday.ToShortDateString();

			ExaminationLabel.Text = _examination.ExaminationType.Description;
			DateLabel.Text = _examination.Date.ToShortDateString();
			StatusLabel.Text = DateTime.Now > _examination.Date ? "Fuldført" : "Kommende";

			CustomerNameLabel.Text = _examination.Pet.Customer.FirstName;
			CustomerPhoneNumberLabel.Text = _examination.Pet.Customer.PhoneNumber.ToString();

			EmployeeNameLabel.Text = _examination.Employee.FirstName;

			PetPicture.Image = GetImage(_examination.Pet.Species);
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

		private async void ExaminationCard_Click(object sender, EventArgs e)
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
