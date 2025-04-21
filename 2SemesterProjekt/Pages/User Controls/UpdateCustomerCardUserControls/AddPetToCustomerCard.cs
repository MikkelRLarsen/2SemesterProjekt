using _2SemesterProjekt.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2SemesterProjekt.Pages.User_Controls.UpdateCustomerCardUserControls
{
	public partial class AddPetToCustomerCard : UserControl
	{
		public AddPetToCustomerCard(PetDTO pet)
		{
			InitializeComponent();
			petNameTextBox.Text = pet.PetName;
			petSpeciesTextBox.Text = pet.PetSpecies;
		}

		public AddPetToCustomerCard() 
		{
			InitializeComponent();
		}
	}
}
