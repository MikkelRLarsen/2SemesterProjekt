using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2SemesterProjekt.Pages.UserControls.ExaminationUserControl
{
    public partial class ExaminationInvoice : UserControl
    {
        private ExaminationCard ExaminationCard;
        public ExaminationInvoice(ExaminationCard examinationCard)
        {
            InitializeComponent();
            ExaminationCard = examinationCard;
        }

        private void ExaminationInvoice_Load(object sender, EventArgs e)
        {
            pageNameLabel.Text = $"Faktura for {ExaminationCard.Examination.Pet.Name}";
            pageNameLabel.Location = new Point((this.Width - pageNameLabel.Width) / 2, pageNameLabel.Location.Y);
            customerNameTextbox.Text = $"{ExaminationCard.Examination.Pet.Customer.FirstName} {ExaminationCard.Examination.Pet.Customer.LastName}";
            petNameTextBox.Text = ExaminationCard.Examination.Pet.Name;
            dateTextBox.Text = ExaminationCard.Examination.Date.ToString("dd-MM-yyyy");
            examinationTextBox.Text = ExaminationCard.Examination.ExaminationType.Description;
            
            if (ExaminationCard.Examination.CageBookingID == 0)
            {
                totalPriceTextBox.Text = (ExaminationCard.Examination.Price + ExaminationCard.Examination.CageBooking.TotalPrice).ToString();
                labelCageBooking.Visible = true;
                cageBookingTextBox.Visible = true;
                cageBookingTextBox.Text = $"{ExaminationCard.Examination.CageBooking.StartDate} til {ExaminationCard.Examination.CageBooking.EndDate}";
            }
            else
            {
                totalPriceTextBox.Text = ExaminationCard.Examination.Price.ToString();
            }
        }
    }
}
