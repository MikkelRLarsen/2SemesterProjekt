using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2SemesterProject.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProjekt.Domain.Models;

namespace _2SemesterProjekt.Pages.UserControls.PetUserControl
{
    public enum PetCardType
    {
        WholePet,
        InactivePet
    }
    public partial class PetCard : UserControl
    {
        private PetPage _petPage;
        private PetCardType _petCardType;
        private IPetService _petService;
        public Pet Pet { get; }
        public Examination Examination { get; }

        public PetCard(PetPage petPage, Pet pet, PetCardType petCardType)
        {
            InitializeComponent();
            _petPage = petPage;
            Pet = pet;
            _petCardType = petCardType;
            CardSetup(); 
        }
        public PetCard(PetPage petPage, Examination examination, PetCardType petCardType)
        {
            InitializeComponent();
            _petPage = petPage;
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
                labelPetSpecies.Text = Pet.Species;
            }

            if (_petCardType == PetCardType.InactivePet)
            {
                // Changing ID to Date.
                label.Name = "Sidste besøg: ";
                labelPetID.Text = Examination.Date.ToString();
                
                labelPetName.Text = Pet.Name;
                labelPetOwner.Text = $"{Pet.Customer.FirstName} {Pet.Customer.LastName}";
                
                // Hiding the not needed labels:
                label2.Visible = false;
                labelPrimaryVet.Visible = false;
                label1.Visible = false;
                labelPetBirth.Visible = false;
                label3.Visible = false;
                labelPetSpecies.Visible = false;

                //   var inactivePets = await _petService.GetAllInactivesAsync();
                //foreach (var examination in inactivePets)
                //    {
                //        labelPetName.Text = examination.Pet.Name.ToString();
                //        labelPetOwner.Text = examination.Pet.Customer.FirstName + examination.Pet.Customer.LastName.ToString();
                //        labelPrimaryVet.Text = examination.Date.ToString();
                //    }
            }
        }

        private async void PetCard_Click(object sender, EventArgs e)
        {
            if (_petPage.PetCard != null)
            {
                _petPage.PetCard.BackColor = SystemColors.Window;
            }

            _petPage.PetCard = this;
            this.BackColor = SystemColors.ActiveBorder;
        }
    }
}
