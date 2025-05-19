using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProjekt.Domain.Models;
using _2SemesterProjekt.Services;
using Microsoft.Extensions.DependencyInjection;
using _2SemesterProjekt.Pages.UserControls.ExaminationUserControl;
using System.Text.RegularExpressions;

namespace _2SemesterProjekt.Pages.UserControls.CustomerUserControl
{
    public partial class UpdateCustomerUserControl : UserControl
    {
        private readonly ICustomerService _customerService;
        private readonly CustomerCard _customerCard;
        private readonly CustomerPage _customerPage;
        private readonly Customer _customer;


        public UpdateCustomerUserControl(CustomerPage customerPage, Customer customer)
        {
            InitializeComponent();
            _customerPage = customerPage;
            _customer = customer;

            _customerService = ServiceProviderSingleton.GetServiceProvider().GetService<ICustomerService>()!;

            panelCancel.Controls.Add(new ButtonPanel("Annuller", "", Color.IndianRed, CancelButton_Click));
            panelCreate.Controls.Add(new ButtonPanel("Bekræft", "", Color.MediumSeaGreen, ConfirmButton_Click));
        }

        private void UpdateCustomerUserControl_Load(object sender, EventArgs e)
        {
            textBoxFirstName.Text = _customer.FirstName;
            textBoxLastName.Text = _customer.LastName;
            textBoxEmail.Text = _customer.Email;
            textBoxAddress.Text = _customer.Address;
            textBoxPhoneNumber.Text = _customer.PhoneNumber.ToString();
        }

        private void CancelButton_Click(object? sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                this.Parent.Controls.Remove(this); // Clear existing content (Parent is CustomerPage)
            }
        }

        private async void ConfirmButton_Click(object? sender, EventArgs e)
        {
            try
            {
                Customer updatedCustomer = new Customer(
                textBoxFirstName.Text,
                textBoxLastName.Text,
                textBoxEmail.Text,
                textBoxAddress.Text,
                _customer.Type, // Not used - you are not able to change customer type.
                int.Parse(textBoxPhoneNumber.Text)
                );

            DialogResult messageBoxResult = MessageBox.Show("Er du sikker på, at denne kunde skal ændres?", "Advarsel", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (messageBoxResult != DialogResult.Yes)
            {
                return;
            }
                _customer.UpdateCustomerProperties(updatedCustomer);
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                return;
            }

            _customerService.UpdateCustomer(_customer);

            MessageBox.Show("Kunden blev opdateret", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            int index = _customerPage.AllCustomerCards.FindIndex(cusCard => cusCard.Customer.CustomerID == _customer.CustomerID);

            // Replaces ExaminationCard with a new one with the updated information
            _customerPage.AllCustomerCards[index] = new CustomerCard(_customer, _customerPage);

            // Set the selected ExaminationCard to null, so its no longer highligted
            _customerPage.CustomerCard = null;
            
            _customerPage.LoadAndShowCustomerCards(_customerPage.AllCustomerCards);
            
            this.Parent.Controls.Remove(this); // Clear existing content (Parent is CustomerPage)
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------//
        // BELOW ARE META-VALIDATION METHODS (FOR THE INDIVIDUEL USER CONTROL BOXES):
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Only numbers allowed in textBoxPhoneNumber.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // The user is only able to enter numbers in the textbox.
            }
            // Resets textbox after error message
            textBoxPhoneNumber.ForeColor = SystemColors.WindowText;
            textBoxPhoneNumber.BackColor = SystemColors.Window;
        }
    }
}
