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
		public ExaminationCard(Examination examination)
		{
			InitializeComponent();
			InitializeUIDesign();
		}

		private void InitializeUIDesign()
		{
			PetNameLabel.Text = string.Empty;
			PetSpeciesLabel.Text = string.Empty;
			BirthdayLabel.Text = string.Empty;

			ExaminationLabel.Text = string.Empty;
			DateLabel.Text = string.Empty;
			StatusLabel.Text = string.Empty;

			CustomerNameLabel.Text = string.Empty;
			CustomerPhoneNumberLabel.Text = string.Empty;

			EmployeeNameLabel.Text = string.Empty;
		}

		private void CollapsePictureBox_Click(object sender, EventArgs e)
		{
			//Expand or Collapse the Card to show more or less information
		}

		private void collapseTimer_Tick(object sender, EventArgs e)
		{
			// For later use. Expand the UserControl
		}
	}
}
