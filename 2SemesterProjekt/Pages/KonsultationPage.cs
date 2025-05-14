using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2SemesterProjekt.Pages.UserControls.ExaminationUserControl;
using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProjekt.Services;
using Microsoft.Extensions.DependencyInjection;
using _2SemesterProjekt.Domain.Models;
using _2SemesterProjekt.Pages.UserControls.MedicineUserControl;
using _2SemesterProjekt.Pages.UserControls.PetUserControl;
using System.Runtime.CompilerServices;

namespace _2SemesterProjekt.Pages
{
    public partial class KonsultationPage : UserControl
    {
        private readonly IExaminationService _examinationService;
        public ExaminationCard ExaminationCard { get; set; }
        public LinkedList<ExaminationCard> AllExaminationCards { get; set; } = new LinkedList<ExaminationCard>();

        public KonsultationPage()
        {
            InitializeComponent();
            _examinationService = ServiceProviderSingleton.GetServiceProvider().GetService<IExaminationService>();
        }

		private void CreateExamination_Click(object sender, EventArgs e)
		{
			ExaminationFlowPanel.Controls.Clear();
			ExaminationFlowPanel.Controls.Add(new CreateExaminationUserControl(ExaminationFlowPanel));
		}

        private void Medicine_Click(object sender, EventArgs e)
        {
            if (this.ExaminationCard != null)
            {
                ExaminationFlowPanel.Controls.Clear();
                ExaminationFlowPanel.Controls.Add(new MedicineUserControl(ExaminationFlowPanel, this.ExaminationCard));
            }
        }

		private void DeleteExamination_Click(object sender, EventArgs e)
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

		private async void ExaminationDeletion(ExaminationCard examinationCard)
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

                AllExaminationCards.Remove(examinationCard);
				LoadAndShowExaminationCards(AllExaminationCards);
            }
        }

		private void KonsultationPage_Load(object sender, EventArgs e)
		{
			CRUDPanel.Controls.Add(new ButtonPanel("Find", Color.MediumAquamarine, FindExamination_Click));
			CRUDPanel.Controls.Add(new ButtonPanel("Opret", Color.MediumSeaGreen, CreateExamination_Click));
			CRUDPanel.Controls.Add(new ButtonPanel("Ændre", Color.Maroon, UpdateExamination_Click));
			CRUDPanel.Controls.Add(new ButtonPanel("Slet", Color.IndianRed, DeleteExamination_Click));
            CRUDPanel.Controls.Add(new ButtonPanel("Opret faktura", Color.MediumBlue, CreateInvoice_Click));
			CRUDPanel.Controls.Add(new ButtonPanel("Medicin", Color.MediumPurple, Medicine_Click));


			Task.Run(() => FindAndSetAllExaminationsAsync());
		}

        private async void UpdateExamination_Click(object sender, EventArgs e)
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

			ExaminationFlowPanel.Controls.Clear();
			ExaminationFlowPanel.Controls.Add(new UpdateExaminationUserControl(this.ExaminationCard.Examination, this));
		}

        private async void FindAndSetAllExaminationsAsync()
        {
			IEnumerable<Examination> allExaminations = await _examinationService.GetAllExaminationsAsync();

			foreach (var examination in allExaminations)
			{
                AllExaminationCards.AddLast(new ExaminationCard(examination, this));
			}
		}

        private async void FindExamination_Click(object sender, EventArgs e)
        {
            try
            {
                // Checks if phonenumber is valid
                if (ValidPhoneNumberTextBox() == true)
                {
					// Finds all examination where Examination.Pet.Customers phonenumber == input phonenumber
					IEnumerable<ExaminationCard> allExaminationWithCustomerPhonenumber = AllExaminationCards.Where(ex => ex.Examination.Pet.Customer.PhoneNumber == Convert.ToInt32(textBoxCustomerPhoneNumber.Text));

                    // If there wasn't any examination with customer phonenumber
                    if (allExaminationWithCustomerPhonenumber.Count() == 0)
                    {
                        throw new ArgumentException("Kunden er ikke registeret i databasen eller ikke har nogen kæledyr");
                    }

					// Addeds all relevant examination to flowpanel and display them
					LoadAndShowExaminationCards(allExaminationWithCustomerPhonenumber);
                }

				else // If ValidPhoneNumberTextBox == False
				{
					// Addeds all examination to flowpanel and display them
					LoadAndShowExaminationCards(AllExaminationCards);
                }

                textBoxCustomerPhoneNumber.Text = string.Empty;
                textBoxCustomerPhoneNumber.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool ValidPhoneNumberTextBox()
        {
            // If User haven't input any text into TextBox and will therefore return false -> Retrieves all Customers
            if (textBoxCustomerPhoneNumber.Text == String.Empty)
            {
                return false;
            }
            // Validate phonenumber: only numbers and 8-digit long.
            if (!Int32.TryParse(textBoxCustomerPhoneNumber.Text, out int phoneNumber) || textBoxCustomerPhoneNumber.Text[0] == '0' || phoneNumber < 10000000 || phoneNumber > 99999999)
            {
                textBoxCustomerPhoneNumber.ForeColor = Color.White;
                textBoxCustomerPhoneNumber.BackColor = Color.LightCoral;
                throw new ArgumentException("Telefonnummer skal være et helt 8-cifret tal");
            }
            else
            {
                return true;
            }
        }

        public async void LoadAndShowExaminationCards(IEnumerable<ExaminationCard> examinationCardsToBeLoaded)
		{
            // Clears the panel and then adds the wanted ExaminationCards
			ExaminationFlowPanel.Controls.Clear();
            ExaminationFlowPanel.Controls.AddRange(examinationCardsToBeLoaded.ToArray());
		}

        private async void CreateInvoice_Click(object sender, EventArgs e)
        {
            string displayMessage = string.Empty;

            if (this.ExaminationCard == null)
            {
                displayMessage += "Vælg en konsultation hvis du vil oprette en faktura";
            }
            else if (DateTime.Now < ExaminationCard.Examination.Date)
            {
                displayMessage += "Du kan ikke oprette en faktura for en ikke fuldført konsultation";
            }

            if (displayMessage == string.Empty)
            {
                var createInvoiceControl = new ExaminationInvoice(ExaminationCard!);
                this.Controls.Add(createInvoiceControl); // Load the new page
                createInvoiceControl.BringToFront();
            }
            else
            {
                MessageBox.Show(displayMessage, "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
