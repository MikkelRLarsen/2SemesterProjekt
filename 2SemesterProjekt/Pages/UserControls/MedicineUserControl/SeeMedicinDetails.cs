using _2SemesterProjekt.Domain.Models;
using _2SemesterProjekt.Pages.UserControls.ExaminationUserControl;
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
		private readonly Examination _examination;
		private List<MedicineCard> _medicineCards = new List<MedicineCard>();
		public SeeMedicinDetails(Examination examination, FindMedicinPage previousPage, Panel panel)
		{
			InitializeComponent();

			_examination = examination;
			_findMedicinPage = previousPage;
			_panel = panel;
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			_panel.Controls.Clear();
			_panel.Controls.Add(_findMedicinPage);
		}

		private void customerSearchButton_Click(object sender, EventArgs e)
		{
			try
			{
				// Finds all examination where Examination.Pet.Customers phonenumber == input phonenumber
				IEnumerable<MedicineCard> allMedicineCardsWithMedicineName = _medicineCards
																					.Where();

				// If there wasn't any examination with customer phonenumber
				if (allMedicineCardsWithMedicineName.Count() == 0)
				{
					throw new ArgumentException("Kunden er ikke registeret i databasen eller ikke har nogen kæledyr");
				}

				// Adds all relevant MedicineCard to flowpanel and display them
				LoadAndShow(_medicineCards);

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private async Task SeeMedicinDetails_Load(object sender, EventArgs e)
		{
			foreach (MedicinePrescription medicinePrescription in _examination.MedicinePrescriptions)
			{
				_medicineCards.Add(new MedicineCard(medicinePrescription));
			}

			LoadAndShow(_medicineCards);
		}

		private void LoadAndShow(IEnumerable<MedicineCard> medicineCards)
		{
			flowPanel.Controls.Clear();
			flowPanel.Controls.AddRange(medicineCards.ToArray());
		}
	}
}
