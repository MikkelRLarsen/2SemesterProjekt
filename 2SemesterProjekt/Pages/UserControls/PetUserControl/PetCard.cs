using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2SemesterProjekt.Domain.Models;

namespace _2SemesterProjekt.Pages.UserControls.PetUserControl
{
	public partial class PetCard : UserControl
	{
		private PetPage _petPage;
		public Pet Pet { get; }

		public PetCard(PetPage petPage, Pet pet)
		{
			InitializeComponent();
			_petPage = petPage;
			Pet = pet;

			labelPetID.Text = pet.PetID.ToString();
			labelPetName.Text = pet.Name;
			labelPetOwner.Text = $"{pet.Customer.FirstName} {pet.Customer.LastName}";

			if (pet.Employee == null)
			{
				labelPrimaryVet.Text = "Ikke valgt";
			}
			else
			{
				labelPrimaryVet.Text = pet.Employee.FirstName;
			}

			labelPetBirth.Text = pet.Birthday.ToString("dd-MM-yyyy");
			labelPetSpecies.Text = pet.Species;

			profilePicture.Image = GetImage(pet.Species);
		}

		private async void PetCard_Click(object sender, EventArgs e)
		{
			if (_petPage.PetCard != null) // protects against null reference exceptions the first time it's clicked
			{
				_petPage.PetCard.BackColor = SystemColors.Window; // If a card was previously selected, reset its background color
			}

			_petPage.PetCard = this; // Set the currently clicked card as the new selected card

			this.BackColor = SystemColors.ActiveBorder;
		}

		private Image GetImage(string speciesName)
		{
			var image = (Image)Properties.Resources.ResourceManager.GetObject(speciesName)!;

			return image;
		}
	}
}
