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

namespace _2SemesterProjekt.Pages.UserControls.PetUserControl
{
    public partial class PetCard : UserControl
    {
        private PetPage _petPage;
        public PetCard(PetPage petPage, Pet pet)
        {
            InitializeComponent();
            _petPage = petPage;

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
