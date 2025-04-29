using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace _2SemesterProjekt.Pages
{
    public partial class PetPage: UserControl
    {
        public PetPage()
        {
            InitializeComponent();
            buttonFlowPanel.Controls.Add(new ButtonPanel("Tilføj kæledyr", "AddCustomer.png", Color.MediumSeaGreen, ShowPetCreation));
        }
        private void ShowPetCreation(object sender, EventArgs e)
        {
            this.Controls.Clear(); // Clear existing content
            this.Controls.Add(new AddPetPage()); // Load the new page
        }
    }
}
