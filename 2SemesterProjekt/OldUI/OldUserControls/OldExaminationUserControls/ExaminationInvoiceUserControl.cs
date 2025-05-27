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
using _2SemesterProjekt.Pages.UserControls.UIModels;
using Microsoft.Extensions.DependencyInjection;

namespace _2SemesterProjekt.Pages.UserControls.ExaminationUserControl
{
    public partial class ExaminationInvoiceUserControl : UserControl
    {
        private ExaminationInvoice _invoice;
        private ExaminationCard ExaminationCard;
        private readonly IExaminationService _examinationService;
        public ExaminationInvoiceUserControl(ExaminationCard examinationCard)
        {
            InitializeComponent();
            ExaminationCard = examinationCard;
            _examinationService = ServiceProviderSingleton.GetServiceProvider().GetService<IExaminationService>()!;
        }

        private void ExaminationInvoice_Load(object sender, EventArgs e)
        {
			_invoice = ExaminationInvoice.FromExamination(ExaminationCard.Examination); // Converts Examination to an editable invoice

            pageNameLabel.Text = $"Faktura for {_invoice.PetName}"; // Page title
            pageNameLabel.Location = new Point((this.Width - pageNameLabel.Width) / 2, pageNameLabel.Location.Y); // Sets page title in middle of page

            // Adds the invoice information
            customerNameTextbox.Text = $"{_invoice.CustomerName}";
            petNameTextBox.Text = _invoice.PetName;
            dateTextBox.Text = _invoice.Date;
            examinationTextBox.Text = _invoice.ExaminationDescription;
            totalPriceTextBox.Text = _invoice.TotalPrice.ToString();

            // Adds the cagebooking info if added
            if (!string.IsNullOrEmpty(_invoice.CageBookingInfo))
            {
                labelCageBooking.Visible = true;
                cageBookingTextBox.Visible = true;
                cageBookingTextBox.Text = _invoice.CageBookingInfo;
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            // Sets the changed information for the invoice
            var invoice = new ExaminationInvoice(
				customerNameTextbox.Text,
				petNameTextBox.Text,
				examinationTextBox.Text,
				dateTextBox.Text,
				cageBookingTextBox.Text,
				totalPriceTextBox.Text.ToString()
            );

			// Creates savefile dialog to make user chose være they wan't to save file
			SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Tekstfil|*.txt";
            saveFileDialog.FileName = $"Faktura for {invoice.ExaminationDescription.ToLower()} af {invoice.PetName}.txt";
            saveFileDialog.Title = "Gem din tekstfil";

            // Execute if user presses OK
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _examinationService.ExportInvoiceToTxtAsync(invoice, saveFileDialog.FileName);
                MessageBox.Show($"Faktura for {invoice.PetName} er oprettet", "Information", MessageBoxButtons.OK);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                this.Parent.Controls.Remove(this); // Clear existing content (Parent is PetPage)
            }
        }
    }
}
