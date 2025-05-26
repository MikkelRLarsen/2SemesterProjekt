using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProjekt.Domain.Models;
using Microsoft.Extensions.DependencyInjection;

namespace _2SemesterProjekt.Pages.UserControls.CustomerUserControl
{
    public partial class UpdateCustomerPage : UserControl
    {
        private readonly ICustomerService _customerService;
        private readonly ChangeCustomerPage _customerPage;
        private readonly Customer _customer;

        public UpdateCustomerPage(ChangeCustomerPage customerPage, Customer customer)
        {
            InitializeComponent();
            _customerPage = customerPage;
            _customer = customer;

            _customerService = ServiceProviderSingleton.GetServiceProvider().GetService<ICustomerService>()!;
        }

        private void UpdateCustomerPage_Load(object sender, EventArgs e)
        {
            textBoxFirstName.Text = _customer.FirstName;
            textBoxLastName.Text = _customer.LastName;
            textBoxEmail.Text = _customer.Email;
            textBoxAddress.Text = _customer.Address;
            textBoxPhoneNumber.Text = _customer.PhoneNumber.ToString();
            comboBoxType.Text = _customer.Type;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                this.Parent.Controls.Remove(this); // Clear existing content (Parent is CustomerPage)
            }
        }

        private async void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                Customer updatedCustomer = new Customer(
                Regex.Replace(textBoxFirstName.Text.Trim(), @"\s+", " "), // Removes unnecessary spaces, but still allows you to type space.
                Regex.Replace(textBoxLastName.Text.Trim(), @"\s+", " "),
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

            await _customerService.UpdateCustomerAsync(_customer);

            MessageBox.Show("Kunden blev opdateret", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int index = _customerPage.AllCustomerCards.FindIndex(cusCard => cusCard.Customer.CustomerID == _customer.CustomerID);

            // Replaces ExaminationCard with a new one with the updated information
            _customerPage.AllCustomerCards[index] = new CustomerCard(_customerPage ,_customer);

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

        private void submitButton_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void submitButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void cancelButton_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void cancelButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}

