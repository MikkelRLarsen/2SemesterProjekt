using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2SemesterProjekt.Pages.UserControls.ProductUserControl
{
    public partial class CreateProductPage : UserControl
    {
        private readonly IProductService _productService;
        public CreateProductPage()
        {
            InitializeComponent();

            _productService = ServiceProviderSingleton.GetServiceProvider().GetService<IProductService>()!;
        }

        private void textBoxEAN_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only numbers are allowed
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxPurchasePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only numbers are allowed
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxSalesPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only numbers are allowed
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxNumberInStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only numbers are allowed
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxMinInStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only numbers are allowed
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string displayMessage = CheckIfInformationIsValid();
            
            if (displayMessage == null)
            {

            }
            else
            {
                //display message here if error
            }
        }

        private string CheckIfInformationIsValid()
        {
            string errorMessage = null;
            if (string.IsNullOrWhiteSpace(textBoxEAN.Text) || string.IsNullOrWhiteSpace(textBoxProductName.Text) || string.IsNullOrWhiteSpace(textBoxProductType.Text) || string.IsNullOrWhiteSpace(textBoxPurchasePrice.Text) || string.IsNullOrWhiteSpace(textBoxSalesPrice.Text) || string.IsNullOrWhiteSpace(textBoxNumberInStock.Text) || string.IsNullOrWhiteSpace(textBoxMinInStock.Text))
            {
                errorMessage += "Indtast venligst alle informationerne.\n";
            }
            try
            {
                Convert.ToInt64(textBoxEAN.Text);
                Convert.ToInt32(textBoxMinInStock.Text);
            }

            return errorMessage;
        }
    }
}
