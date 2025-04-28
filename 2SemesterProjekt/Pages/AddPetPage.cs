using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2SemesterProject.Domain.Models;
using _2SemesterProject.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using _2SemesterProject.Domain.Interfaces.ServiceInterfaces;

namespace _2SemesterProjekt.Pages
{
    public partial class AddPetPage : UserControl
    {
        private readonly IPetService _petService;
        public AddPetPage()
        {
            InitializeComponent();
            petBirthdaySelector.MaxDate = DateTime.Today;
            _petService = ServiceProviderSingleton.GetServiceProvider().GetService<IPetService>();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Controls.Clear(); // Clear existing content
            this.Controls.Add(new ProductPage()); // Load the new page
        }

        private void ownerPhoneNumberTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(ownerPhoneNumberTextbox.Text);
            }
            catch
            {
                NotificationMessage("Invalid Phone Number");
            }
            Pet newPet = new Pet(0, 0, petNameTextbox.Text, petSpeciesTextbox.Text, petBirthdaySelector.Value);
            NotificationMessage(_petService.CreatePet(newPet, Convert.ToInt32(ownerPhoneNumberTextbox.Text)));
        }

        private void NotificationMessage(string typeOfMsg)
        {
            if (typeOfMsg == "Invalid Phone Number")
            {
                // Invalid telefonnummer.
            }
            else if (typeOfMsg == "Customer Not Found")
            {
                // Kunden findes ikke i systemet.
            }
            else if (typeOfMsg == "Pet Already In DB")
            {
                // Kæledyret tilhørende kunden findes allerede i systemet.
            }
            else if (typeOfMsg == "Pet Added To DB")
            {
                // Kæledyret er blevet tilføjet til systemet!
            }
        }
    }
}
