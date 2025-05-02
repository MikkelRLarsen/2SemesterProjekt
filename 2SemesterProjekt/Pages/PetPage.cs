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
using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using Microsoft.Extensions.DependencyInjection;
using _2SemesterProjekt.Services;
using _2SemesterProjekt.Pages.UserControls.PetUserControl;
using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;

namespace _2SemesterProjekt.Pages
{
    public partial class PetPage : UserControl
    {
        private IPetService _petService;
        private ICustomerService _customerService;
        public PetCard PetCard { get; set; }

        public PetPage()
        {
            InitializeComponent();
            buttonFlowPanel.Controls.Add(new ButtonPanel("Tilføj kæledyr", Color.MediumSeaGreen, ShowPetCreation));
            buttonFlowPanel.Controls.Add(new ButtonPanel("Redigér kæledyr", Color.Goldenrod, ShowPetUpdate));
            _petService = ServiceProviderSingleton.GetServiceProvider().GetService<IPetService>()!;
        }
        private void ShowPetCreation(object sender, EventArgs e)
        {
            this.Controls.Clear(); // Clear existing content
            this.Controls.Add(new AddPetUserControl()); // Load the new page
        }

        private void ShowPetUpdate(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new UpdatePetUserControl(PetCard));
        }

        private async void PetPage_Load(object sender, EventArgs e)
        {
            var listOfPets = await _petService.GetAllPetsAsync();
            foreach (var pet in listOfPets)
            {
                flowLayoutPanel1.Controls.Add(new PetCard(this, pet));
            }
        }
    }
}
