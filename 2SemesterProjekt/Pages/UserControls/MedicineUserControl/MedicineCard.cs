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
	public partial class MedicineCard : UserControl
	{
		private MedicinePrescription _medicinePresription;
		public MedicineCard(MedicinePrescription medicinePrescription)
		{
			InitializeComponent();
			_medicinePresription = medicinePrescription;
		}

		private void MedicineCard_Load(object sender, EventArgs e)
		{
			petPicture.Image = GetImage(_medicinePresription.Examination.Pet.Species.Name);
			PetNameLabel.Text = _medicinePresription.Examination.Pet.Name;
			ExaminationLabel.Text = _medicinePresription.Examination.ExaminationType.Description;

			MedicineNameLabel.Text = _medicinePresription.MedicineDetails.MedicineType.Name;
			MedicineTypeLabel.Text = _medicinePresription.MedicineDetails.MedicineType.Type;
			MedicineFormatLabel.Text = _medicinePresription.MedicineDetails.MedicineFormat.Format;

			StartDateLabel.Text = _medicinePresription.StartDate.ToShortDateString();
			EndDateLabel.Text = _medicinePresription.StartDate.AddDays(_medicinePresription.DoseDuration).ToShortDateString();
			DoseAmountLabel.Text = _medicinePresription.MedicineDetails.DoseAmount.ToString();
			DosePrDayLabel.Text = _medicinePresription.MedicineDetails.Doses24Hours.ToString();
		}

		/// <summary>
		/// Finds matching image for pet species in resources
		/// </summary>
		private Image GetImage(string speciesName)
		{
			var image = (Image)Properties.Resources.ResourceManager.GetObject(speciesName)!;

			return image;
		}
	}
}
