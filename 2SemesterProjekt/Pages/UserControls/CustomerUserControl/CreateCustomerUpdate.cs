using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProjekt.Domain.Models;
using _2SemesterProjekt.Pages.UserControls.MainPageWallpaperControl;
using _2SemesterProjekt.Services;
using Microsoft.Extensions.DependencyInjection;

namespace _2SemesterProjekt.Pages.UserControls.CustomerUserControl
{
    public partial class CreateCustomerUpdate : UserControl
    {
        private readonly ICustomerService _customerService;
        private readonly Panel _mainPagePanel;

        public CreateCustomerUpdate(Panel mainPagePanel)
        {
            InitializeComponent();

            _mainPagePanel = mainPagePanel;
            // Get the customer service from the service provider
            _customerService = ServiceProviderSingleton.GetServiceProvider().GetService<ICustomerService>()!;

            // Add content for dropdown
            var customerTypes = _customerService.GetCustomerTypes();
            comboBoxType.DataSource = customerTypes;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            _mainPagePanel.Controls.Remove(this);
            _mainPagePanel.Controls.Add(new MainPageWallpaper());
        }

        //private void customerSearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    // Allow only letters, control keys (backspace), and separators (space)
        //    if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
        //    {
        //        e.Handled = true;
        //    }
        //    // Resets textbox after error message
        //    textBoxFirstName.ForeColor = SystemColors.WindowText;
        //    textBoxFirstName.BackColor = SystemColors.Window;
        //}

        private void textBoxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only letters, control keys (backspace), and separators (space)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            // Resets textbox after error message
            textBoxLastName.ForeColor = SystemColors.WindowText;
            textBoxLastName.BackColor = SystemColors.Window;
        }

        private void textBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Resets textbox after error message
            textBoxEmail.ForeColor = SystemColors.WindowText;
            textBoxEmail.BackColor = SystemColors.Window;
        }

        private void textBoxAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Resets textbox after error message
            textBoxAddress.ForeColor = SystemColors.WindowText;
            textBoxAddress.BackColor = SystemColors.Window;
        }

        private void textBoxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            // Resets textbox after error message
            textBoxPhoneNumber.ForeColor = SystemColors.WindowText;
            textBoxPhoneNumber.BackColor = SystemColors.Window;
        }

        private async void submitButton_Click(object sender, EventArgs e)
        {
            string displayMessage = string.Empty;

            // Validate first and last name: only letters
            if (string.IsNullOrWhiteSpace(textBoxFirstName.Text) || !textBoxFirstName.Text.All(char.IsLetter))
            {
                textBoxFirstName.ForeColor = Color.White;
                textBoxFirstName.BackColor = Color.LightCoral;
                displayMessage += "Fornavn må kun indeholde bogstaver.\n";
            }

            if (string.IsNullOrWhiteSpace(textBoxLastName.Text) || !textBoxLastName.Text.All(char.IsLetter))
            {
                textBoxLastName.ForeColor = Color.White;
                textBoxLastName.BackColor = Color.LightCoral;
                displayMessage += "Efternavn må kun indeholde bogstaver.\n";
            }

            // Validate email: "@" and "." in correct order.
            int atIndex = textBoxEmail.Text.IndexOf('@');
            int dotIndex = textBoxEmail.Text.LastIndexOf('.');
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text) || atIndex <= 0 || dotIndex <= atIndex + 1 || dotIndex == textBoxEmail.Text.Length - 1)
            {
                textBoxEmail.ForeColor = Color.White;
                textBoxEmail.BackColor = Color.LightCoral;
                displayMessage += "Indtast en gyldig e-mailadresse.\n";
            }

            // Validate address: only letters and digits.
            if (string.IsNullOrWhiteSpace(textBoxAddress.Text) || textBoxAddress.Text.All(char.IsLetterOrDigit))
            {
                textBoxAddress.ForeColor = Color.White;
                textBoxAddress.BackColor = Color.LightCoral;
                displayMessage += "Adressen må kun indeholde bogstaver, tal og mellemrum.\n";
            }

            // Validate phonenumber: only numbers and 8-digit long.
            if (!Int32.TryParse(textBoxPhoneNumber.Text, out int phoneNumber) || textBoxPhoneNumber.Text[0] == '0' || phoneNumber < 10000000 || phoneNumber > 99999999)
            {
                textBoxPhoneNumber.ForeColor = Color.White;
                textBoxPhoneNumber.BackColor = Color.LightCoral;
                displayMessage += "Telefonnummer skal være et helt 8-cifret tal.\n";
            }

            if (displayMessage == string.Empty) // If there is no errors, then create customer
            {
                try
                {
                    var customer = new Customer(
                       textBoxFirstName.Text, // FirstName
                       textBoxLastName.Text, // LastName
                       textBoxEmail.Text,    // Email
                       textBoxAddress.Text,  // Address
                       comboBoxType.Text,    // Type
                    phoneNumber           // PhoneNumber
                    );

                    await _customerService.CreateCustomerAsync(customer); // Creates the customer in DB

                    MessageBox.Show($"{textBoxFirstName.Text} er oprettet i systemet", "Kunde oprettet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}", "Fejl i oprettelse", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // Show error to user in UI
            {
                MessageBox.Show(displayMessage, "Fejl i indtastning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
