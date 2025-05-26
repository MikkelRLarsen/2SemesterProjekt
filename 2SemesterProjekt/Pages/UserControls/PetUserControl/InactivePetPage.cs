using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProjekt.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2SemesterProjekt.Pages.UserControls.PetUserControl
{
    public partial class InactivePetPage : UserControl
    {
        private readonly IExaminationService _examinationService;
        private List<PetCard> AllInactivePetCards { get; set; } = new List<PetCard>();
        public InactivePetPage()
        {
            InitializeComponent();
            _examinationService = ServiceProviderSingleton.GetServiceProvider().GetService<IExaminationService>()!;
        }

        private void InactivePetPage_Load(object sender, EventArgs e)
        {
            Task.Run(() => ShowInactivePetsAsync()); // New thread calling the method below.
        }

        private async void ShowInactivePetsAsync()
        {
            // If any, loads the inactive-pet-information onto PetCard.
            try
            {
                var listOfPets = await _examinationService.GetAllInactivesAsync();
                foreach (var examination in listOfPets)
                {
                    AllInactivePetCards.Add(new PetCard(examination, PetCardType.InactivePet));
                }
            }
            catch
            {
                MessageBox.Show("Der findes ingen inaktive kæledyr.");
            }
        }

        private void findAllButton_Click(object sender, EventArgs e)
        {
            LoadAndShowInactivePets(AllInactivePetCards);
        }

        private void LoadAndShowInactivePets(List<PetCard> allInactivePets)
        {
            flowPanel.Controls.Clear();
            flowPanel.Controls.AddRange(allInactivePets.ToArray());
        }
    }
}
