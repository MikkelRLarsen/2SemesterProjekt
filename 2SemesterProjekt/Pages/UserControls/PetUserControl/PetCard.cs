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
        private InactivePetPage _inactivePetPage;
        private readonly ChangePetPage _changePage;
        private readonly PetCardType _petCardType;
        private readonly IPetService _petService;
        public Pet Pet { get; }
        public Examination Examination { get; }

        /// <summary>
        /// Creates the whole PetCard for active pets.
        /// </summary>
        /// <param name="petPage"></param>
        /// <param name="pet"></param>
        /// <param name="petCardType"></param>
        public PetCard(Pet pet, PetCardType petCardType)
        {
            InitializeComponent();
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

        /// <summary>
        /// Change pet contructor
        /// </summary>
        public PetCard(ChangePetPage changePetPage, Pet pet, PetCardType petCardType)
        {
            InitializeComponent();
            _changePage = changePetPage;
            Pet = pet;
            _petCardType = petCardType;
            AddMoveHandlers(this);
            CardSetup();
        }

        private void AddMoveHandlers(Control control)
        {
            control.Click += pictureBox_Click;
            control.MouseEnter += pictureBox_MouseEnter;
            control.MouseLeave += pictureBox_MouseLeave;

            // Add the same handler to each of the control.Controls.
            foreach (Control child in control.Controls)
            {
                AddMoveHandlers(child);
            }
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
                this.Click += pictureBox_Click;
            }

            if (_petCardType == PetCardType.InactivePet)
            {
                // Changing ID to Date.
                label.Text = "Sidste besøg: ";
                labelPetID.Location = new Point(label.Location.X + 160, label.Location.Y);
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

                this.Click -= pictureBox_Click;
            }

            profilePicture.Image = GetImage(Pet.Species.Name);
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
            if (_changePage != null)
            {
                if (_changePage.PetCard != null) // protects against null reference exceptions the first time it's clicked
                {
                    _changePage.PetCard.pictureBox.Image = Properties.Resources.CardExamination; // If a card was previously selected, reset its background color
                }

                // Finds the changebutton in changepage to manipulate the picture
                PictureBox changeButton = _changePage.Controls.OfType<PictureBox>().First(p => p.Name == "pictureBox2");

                changeButton.Image = Properties.Resources.ChangeButton;

                _changePage.PetCard = this; // Set the currently clicked card as the new selected card

                this.pictureBox.Image = Properties.Resources.CardExaminationSelected;
            }
        }

        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
