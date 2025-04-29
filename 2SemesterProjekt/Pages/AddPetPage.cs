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
using _2SemesterProject.Domain.Interfaces.RepositoryInterfaces;

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
                int customerId = _customerService.GetCustomerIDByPhoneNumber(customerPhoneNumber);
                if (customerId == 0)
                {
                    NotificationMessage("Kunden med dette telefonnummer findes ikke i systemet.");
                }
                else {
                    NotificationMessage(_petService.CreatePet(petNameTextbox.Text, petSpeciesTextbox.Text, petBirthdaySelector.Value, customerId));
                }
            }
        }

        private void NotificationMessage(string typeOfMsg)
        {
            MessageBox.Show(typeOfMsg, "Information", MessageBoxButtons.OK);
        }
    }
}
