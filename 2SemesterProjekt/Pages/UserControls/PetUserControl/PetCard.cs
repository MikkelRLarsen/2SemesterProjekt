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
using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProjekt.Domain.Models;

namespace _2SemesterProjekt.Pages.UserControls.PetUserControl
{
    /// <summary>
    /// Allows the creation of different kinds of PetCards via multiple constructors.
    /// </summary>
    public enum PetCardType
    {
        WholePet,
        InactivePet
    }
    public partial class PetCard : UserControl
    {
        private FindPetPage _petPage;
        private PetCardType _petCardType;
        private IPetService _petService;
        private InactivePetPage _inactivePetPage;
        public Pet Pet { get; }
        public Examination Examination { get; }
        
        /// <summary>
        /// Creates the whole PetCard for active pets.
        /// </summary>
        /// <param name="petPage"></param>
        /// <param name="pet"></param>
        /// <param name="petCardType"></param>
        public PetCard(FindPetPage petPage, Pet pet, PetCardType petCardType)
        {
            InitializeComponent();
            _petPage = petPage;
            Pet = pet;
            _petCardType = petCardType;
            CardSetup(); 
        }
        
        public PetCard(InactivePetPage inactivePetPage, Examination examination, PetCardType petCardType)
        {
            InitializeComponent();
            _inactivePetPage = inactivePetPage;
            Pet = examination.Pet;
            Examination = examination;
            _petCardType = petCardType;
            CardSetup();
        }

        private async void CardSetup()
        {
            if (_petCardType == PetCardType.WholePet)
            {
                labelPetID.Text = Pet.PetID.ToString();
                labelPetName.Text = Pet.Name;
                labelPetOwner.Text = $"{Pet.Customer.FirstName} {Pet.Customer.LastName}";

                if (Pet.Employee == null)
                {
                    labelPrimaryVet.Text = "Ikke valgt";
                }
                else
                {
                    labelPrimaryVet.Text = Pet.Employee.FirstName;
                }

                labelPetBirth.Text = Pet.Birthday.ToString("dd-MM-yyyy");
                labelPetSpecies.Text = Pet.Species.Name;
                this.Click += PetCard_Click;
            }

            if (_petCardType == PetCardType.InactivePet)
            {
                // Changing ID to Date.
                label.Text = "Sidste besøg: ";
                labelPetID.Location = new Point (label.Location.X + 160, label.Location.Y);
                labelPetID.Text = Examination.Date.ToString("dd-MM-yyyy");

                labelPetName.Text = Examination.Pet.Name;
                labelPetOwner.Text = $"{Examination.Pet.Customer.FirstName} {Examination.Pet.Customer.LastName}";
                
                // Hiding the not needed labels:
                label2.Visible = false;
                labelPrimaryVet.Visible = false;
                label1.Visible = false;
                labelPetBirth.Visible = false;
                label3.Visible = false;
                labelPetSpecies.Visible = false;
            }

			profilePicture.Image = GetImage(Pet.Species.Name);
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
