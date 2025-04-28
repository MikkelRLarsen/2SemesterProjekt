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
        private readonly ICustomerService _customerService;
        public AddPetPage()
        {
            InitializeComponent();
            petBirthdaySelector.MaxDate = DateTime.Today;
            _petService = ServiceProviderSingleton.GetServiceProvider().GetService<IPetService>();
            _customerService = ServiceProviderSingleton.GetServiceProvider().GetService<ICustomerService>();
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
            if (!Int32.TryParse(ownerPhoneNumberTextbox.Text, out int phoneNumber))
            {
                NotificationMessage("Telefonnummeret er ikke gyldigt!");
            }
            else
            {
                int customerPhoneNumber = Convert.ToInt32(ownerPhoneNumberTextbox.Text);
                NotificationMessage(_petService.CreatePet(petNameTextbox.Text, petSpeciesTextbox.Text, petBirthdaySelector.Value, customerPhoneNumber));
            }
        }

        private void NotificationMessage(string typeOfMsg)
        {
            MessageBox.Show(typeOfMsg, "Information", MessageBoxButtons.OK);
        }
    }
}
