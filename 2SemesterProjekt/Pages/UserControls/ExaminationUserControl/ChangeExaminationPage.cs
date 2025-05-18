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
using Microsoft.Extensions.DependencyInjection;

namespace _2SemesterProjekt.Pages.UserControls.ExaminationUserControl
{
    public partial class ChangeExaminationPage : UserControl
    {
        private readonly IExaminationService _examinationService;
        private readonly Panel _mainPagePanel;
        public ExaminationCardUpdated ExaminationCard { get; set; }
        public List<ExaminationCardUpdated> AllExaminationCards { get; set; } = new List<ExaminationCardUpdated>();

        public ChangeExaminationPage(Panel mainPagePanel)
        {
            InitializeComponent();
            _mainPagePanel = mainPagePanel;
            _examinationService = ServiceProviderSingleton.GetServiceProvider().GetService<IExaminationService>();
        }

        private void UpdateExaminationPage_Load(object sender, EventArgs e)
        {
            Task.Run(() => FindAndSetAllExaminationsAsync());
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (this.ExaminationCard == null)
            {
                MessageBox.Show("Vælg venligst den konsultationstid, der skal ændres.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.ExaminationCard.Examination.Date < DateTime.Now)
            {
                DialogResult messageBoxWarning = MessageBox.Show("Du kan ikke ændre en fuldført konsultationstid!", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _mainPagePanel.Controls.Clear();
            _mainPagePanel.Controls.Add(new UpdateExaminationPage(this.ExaminationCard.Examination, this));
        }

        private async void FindAndSetAllExaminationsAsync()
        {
            IEnumerable<Examination> allExaminations = await _examinationService.GetAllExaminationsAsync();

            foreach (var examination in allExaminations)
            {
                AllExaminationCards.Add(new ExaminationCardUpdated(examination, this));
            }
        }

        private void customerSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Checks if phonenumber is valid
                if (ValidPhoneNumberTextBox() == true)
                {
                    // Finds all examination where Examination.Pet.Customers phonenumber == input phonenumber
                    IEnumerable<ExaminationCardUpdated> allExaminationWithCustomerPhonenumber = AllExaminationCards
                                                                                                    .Where(ex => ex.Examination.Pet.Customer.PhoneNumber == Convert.ToInt32(textBoxCustomerPhoneNumberOrName.Text));

                    // If there wasn't any examination with customer phonenumber
                    if (allExaminationWithCustomerPhonenumber.Count() == 0)
                    {
                        throw new ArgumentException("Kunden er ikke registeret i databasen eller ikke har nogen kæledyr");
                    }

                    // Adds all relevant examination to flowpanel and display them
                    LoadAndShowExaminationCards(allExaminationWithCustomerPhonenumber);
                }

                textBoxCustomerPhoneNumberOrName.Text = string.Empty;
                textBoxCustomerPhoneNumberOrName.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidPhoneNumberTextBox()
        {
            // If User haven't input any text into TextBox and will therefore return false -> Retrieves all Customers
            if (textBoxCustomerPhoneNumberOrName.Text == String.Empty)
            {
                return false;
            }
            // Validate phonenumber: only numbers and 8-digit long.
            if (!Int32.TryParse(textBoxCustomerPhoneNumberOrName.Text, out int phoneNumber) || textBoxCustomerPhoneNumberOrName.Text[0] == '0' || phoneNumber < 10000000 || phoneNumber > 99999999)
            {
                textBoxCustomerPhoneNumberOrName.ForeColor = Color.White;
                textBoxCustomerPhoneNumberOrName.BackColor = Color.LightCoral;
                throw new ArgumentException("Telefonnummer skal være et helt 8-cifret tal");
            }
            else
            {
                return true;
            }
        }

        public async void LoadAndShowExaminationCards(IEnumerable<ExaminationCardUpdated> examinationCardsToBeLoaded)
        {
            // Clears the panel and then adds the wanted ExaminationCards
            flowPanel.Controls.Clear();
            flowPanel.Controls.AddRange(examinationCardsToBeLoaded.ToArray());
        }

        private void findAllButton_Click(object sender, EventArgs e)
        {
            LoadAndShowExaminationCards(AllExaminationCards);
        }
    }
}
