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
using _2SemesterProjekt.Pages.UserControls.UserControlInterfaces;
using Microsoft.Extensions.DependencyInjection;

namespace _2SemesterProjekt.Pages.UserControls.ExaminationUserControl
{
    public partial class RemoveExaminationPage : UserControl, IExaminationCardHost
    {
        private readonly IExaminationService _examinationService;
        private readonly Panel _mainPagePanel;
        public ExaminationCardUpdated ExaminationCard { get; set; }
        public List<ExaminationCardUpdated> AllExaminationCards { get; set; } = new List<ExaminationCardUpdated>();

        public RemoveExaminationPage(Panel mainPagePanel)
        {
            InitializeComponent();
            _mainPagePanel = mainPagePanel;
            _examinationService = ServiceProviderSingleton.GetServiceProvider().GetService<IExaminationService>();
        }

        private void RemoveExaminationPage_Load(object sender, EventArgs e)
        {
            Task.Run(() => FindAndSetAllExaminationsAsync());
        }

        private async void FindAndSetAllExaminationsAsync()
        {
            IEnumerable<Examination> allExaminations = await _examinationService.GetAllExaminationsAsync();

            foreach (var examination in allExaminations)
            {
                AllExaminationCards.Add(new ExaminationCardUpdated(examination, this));
            }

            findAllButton.Image = Properties.Resources.FindAllButton;
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
            // Wait cursor (hourglass)
            Cursor = Cursors.WaitCursor;
            findAllButton.Enabled = false;

            LoadAndShowExaminationCards(AllExaminationCards);
            
            // Wait cursor (pointer)
            Cursor = Cursors.Default;
            findAllButton.Enabled = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (this.ExaminationCard != null)
            {
                ExaminationDeletion(this.ExaminationCard);
            }
            else
            {
                MessageBox.Show("Vælg venligst den konsultationstid, der skal slettes.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ExaminationDeletion(ExaminationCardUpdated examinationCard)
        {
            if (!await _examinationService.CheckIfExaminationCanBeDeleted(examinationCard.Examination.Date))
            {
                DialogResult messageBoxWarning = MessageBox.Show("Du kan ikke slette ældre konsultationstider!", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult messageBoxResult = MessageBox.Show("Er du sikker på, at denne konsultationstid skal slettes?", "Advarsel", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (messageBoxResult == DialogResult.Yes)
            {
                // Call examination deletion method from service
                await _examinationService.DeleteExaminationAsync(examinationCard.Examination);
                MessageBox.Show("Konsultationstiden er blevet slettet.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Removes ExaminationCard from allExaminations
                AllExaminationCards.Remove(examinationCard);

                // Set the selected ExaminationCard to null, so its no longer highlighted
                this.ExaminationCard = null;
                deleteButton.Image = Properties.Resources.DeleteButtonGreyedOut;

                // Return to show all pets
                LoadAndShowExaminationCards(AllExaminationCards);
            }
        }

        public void OnCardSelected(ExaminationCardUpdated selectedCard)
        {
            if (ExaminationCard != null)
            {
                ExaminationCard.SetSelected(false);
            }

            ExaminationCard = selectedCard;
            ExaminationCard.SetSelected(true);

            deleteButton.Image = Properties.Resources.DeleteButton;
        }

        private void textBoxCustomerPhoneNumberOrName_Click(object sender, EventArgs e)
        {
            if (textBoxCustomerPhoneNumberOrName.Text == "Søg på navn eller telefonnummer")
            {
                textBoxCustomerPhoneNumberOrName.Text = string.Empty;
                textBoxCustomerPhoneNumberOrName.ForeColor = SystemColors.WindowText;
            }
        }
    }
}
