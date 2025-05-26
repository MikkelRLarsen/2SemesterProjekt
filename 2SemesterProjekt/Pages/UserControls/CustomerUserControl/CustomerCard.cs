using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2SemesterProjekt.Domain.Models;
using _2SemesterProjekt.Pages.UserControls.CustomerUserControl;

namespace _2SemesterProjekt
{
    public partial class CustomerCard : UserControl
    {
        public Customer Customer { get; private set; } // Holds Customer data
        private readonly ChangeCustomerPage _changePage;

        // For find customer
        public CustomerCard(Customer customer)
        {
            InitializeComponent();
            Customer = customer;
            InitializeUIDesign();
            AddMoveHandlers(this);
        }

        // For update customer
        public CustomerCard(ChangeCustomerPage changePage, Customer customer)
        {
            InitializeComponent();
            Customer = customer;
            _changePage = changePage;
            InitializeUIDesign();
            AddMoveHandlers(this);
        }

        private void InitializeUIDesign()
        {
            customerIdLabel.Text = Customer.CustomerID.ToString();
            customerNameLabel.Text = $"{Customer.FirstName} {Customer.LastName}";
            customerPhoneNumberLabel.Text = Customer.PhoneNumber.ToString();
            customerEmailLabel.Text = Customer.Email;
            customerAddressLabel.Text = Customer.Address;
        }

        private void AddMoveHandlers(Control control)
        {
            control.Click += pictureBox_Click;
            control.MouseEnter += pictureBox_MouseEnter;
            control.MouseLeave += pictureBox_MouseLeave;

            // Add the same handler to each of the control.Controls.
            foreach (Control child in control.Controls)
            {
                AddMoveHandlers(child);
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (_changePage != null)
            {
                if (_changePage.CustomerCard != null) // protects against null reference exceptions the first time it's clicked
                {
                    _changePage.CustomerCard.pictureBox.Image = Properties.Resources.CardExamination; // If a card was previously selected, reset its background color
                }

                // Finds the changebutton in changepage to manipulate the picture
                PictureBox changeButton = _changePage.Controls.OfType<PictureBox>().First(p => p.Name == "changeButton");

                changeButton.Image = Properties.Resources.ChangeButton;

                _changePage.CustomerCard = this; // Set the currently clicked card as the new selected card

                this.pictureBox.Image = Properties.Resources.CardExaminationSelected;
            }
        }

        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
