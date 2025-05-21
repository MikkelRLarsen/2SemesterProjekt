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

namespace _2SemesterProjekt.Pages.UserControls.MedicineUserControl
{
	public partial class SeeMedicinDetails : UserControl
	{
		private readonly FindMedicinPage _findMedicinPage;
		private readonly Panel _panel;
		public SeeMedicinDetails(Examination examination, FindMedicinPage previousPage, Panel panel)
		{
			InitializeComponent();

			PetNameTextBox.Text = examination.Pet.Name;
			MedicinNameTextBox.Text = examination.Medicine.Name;
			MedicinTypeTextBox.Text = examination.Medicine.Type;
			DoseAmountTextBox.Text = examination.Medicine.DoseMiligram.ToString();
			DosePrDayTextBox.Text = examination.Medicine.DosesTake24Hours.ToString();

			DateTime startDate = (DateTime)examination.Medicine.StartDate;
			StartDateTextBox.Text = startDate.ToShortDateString();
			EndDateTextBox.Text = startDate.AddDays(examination.Medicine.DoseDurationDays).ToShortDateString();

			_findMedicinPage = previousPage;
			_panel = panel;
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			_panel.Controls.Clear();
			_panel.Controls.Add(_findMedicinPage);
		}
	}
}
