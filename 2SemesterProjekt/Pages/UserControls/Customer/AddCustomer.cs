using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2SemesterProject.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProject.Domain.Models;
using Microsoft.Extensions.DependencyInjection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;

namespace _2SemesterProjekt
{
    public partial class AddCustomer : UserControl
    {
        private readonly ICustomerService _customerService;
        private readonly string[] _customerTypes = { "Privat", "Erhverv" };

        public AddCustomer()
        {
            InitializeComponent();

            // Get the customer service from the service provider
            _customerService = ServiceProviderSingleton.GetServiceProvider().GetService<ICustomerService>()!;

            // Add buttons
            panelCancel.Controls.Add(new ButtonPanel("Annuller", Color.IndianRed, CancelButton_Click));
            panelCreate.Controls.Add(new ButtonPanel("Tilføj kunde", Color.MediumSeaGreen, CreateButton_Click));

            // Add content for dropdown
            comboBoxType.DataSource = _customerTypes;
        }

        // Eventhandler for cancel button
        private void CancelButton_Click(object? sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new CustomerPage());
        }


        private void textBoxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only letters, control keys (backspace), and separators (space)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            // Resets textbox after error message
            textBoxFirstName.ForeColor = SystemColors.WindowText;
            textBoxFirstName.BackColor = SystemColors.Window;
        }

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

        private void CreateButton_Click(object? sender, EventArgs e)
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

            // Validate phonenumber: 8-digit long.
            int customerPhoneNumber = 0;
            if (textBoxPhoneNumber.Text != string.Empty)
            {
                customerPhoneNumber = Convert.ToInt32(textBoxPhoneNumber.Text);
            }

            if (customerPhoneNumber < 10000000 || customerPhoneNumber > 99999999)
            {
                textBoxPhoneNumber.ForeColor = Color.White;
                textBoxPhoneNumber.BackColor = Color.LightCoral;
                displayMessage += "Telefonnummer skal være et 8-cifret tal.\n";
            }

            if (displayMessage == string.Empty) // If there is no errors, then create customer
            {
                var customer = new Customer(
                    textBoxFirstName.Text, // FirstName
                    textBoxLastName.Text,  // LastName
                    textBoxEmail.Text,     // Email
                    textBoxAddress.Text,   // Address
                    comboBoxType.Text,     // Type
                    customerPhoneNumber // PhoneNumber
                );

                bool isCreationSuccessful = _customerService.CreateCustomer(customer); // Checks if the customer already is in DB

                if (isCreationSuccessful)
                {
                    MessageBox.Show($"{customer.FirstName} er oprettet i systemet", "Kunnde oprettet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"{customer.FirstName} findes allerede!", "Kunde findes allerede", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // Show error to user
            {
                MessageBox.Show(displayMessage, "Fejl i indtastning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
