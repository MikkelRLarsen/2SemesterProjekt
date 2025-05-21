using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2SemesterProjekt.Domain.Models;

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

            if (displayMessage != null)
            {

            }
            else
            {
                Domain.Models.Product product = new Domain.Models.Product(
                                                textBoxProductName.Text,
                                                Convert.ToInt64(textBoxEAN.Text),
                                                textBoxProductType.Text,
                                                Convert.ToDecimal(textBoxPurchasePrice.Text),
                                                Convert.ToDecimal(textBoxSalesPrice.Text),
                                                Convert.ToInt32(numericNumberInStock.Value),
                                                Convert.ToInt32(numericMinInStock.Value)
                                                );

                _productService.CreateProductAsync(product);
            }
        }

        private string CheckIfInformationIsValid()
        {
            string errorMessage = null;
            if (string.IsNullOrWhiteSpace(textBoxEAN.Text) || string.IsNullOrWhiteSpace(textBoxProductName.Text))
            {
                errorMessage = "Indtast venligst alle informationerne.\n";
            }
            try
            {
                Convert.ToInt64(textBoxEAN.Text);
            }
            catch
            {
                errorMessage = "Indtast venligst et gyldigt tal.";
                textBoxEAN.BackColor = Color.IndianRed;
            }
            try
            {
                Convert.ToInt32(numericMinInStock.Value);
            }
            catch
            {
                errorMessage = "Indtast venligst et gyldigt tal.";
                numericMinInStock.BackColor = Color.IndianRed;
            }
            try
            {
                Convert.ToInt32(numericMinInStock.Value);
            }
            catch
            {
                errorMessage = "Indtast venligst et gyldigt tal.";
                numericNumberInStock.BackColor = Color.IndianRed;
            }
            try
            {
                Convert.ToDecimal(textBoxPurchasePrice.Text);
            }
            catch
            {
                errorMessage = "Indtast venligst et gyldigt tal.";
                textBoxPurchasePrice.BackColor = Color.IndianRed;
            }
            try
            {
                Convert.ToDecimal(textBoxSalesPrice.Text);
            }
            catch
            {
                errorMessage = "Indtast venligst et gyldigt tal.";
                textBoxSalesPrice.BackColor = Color.IndianRed;
            }

            return errorMessage;
        }
    }
}
