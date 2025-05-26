using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using Microsoft.Extensions.DependencyInjection;
using _2SemesterProjekt.Pages.UserControls.MainPageWallpaperControl;

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

        private async void submitButton_Click(object sender, EventArgs e)
        {
            string displayMessage = CheckIfInformationIsValid();

            if (displayMessage != null)
            {
                MessageBox.Show($"{displayMessage}", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
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

                    await _productService.CreateProductAsync(product);
                    MessageBox.Show($"{product.Name} er blevet oprettet i databasen.", "Produkt oprettet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Controls.Clear();
                    this.Controls.Add(new MainPageWallpaper());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                Convert.ToDecimal(textBoxPurchasePrice.Text);
                Convert.ToDecimal(textBoxSalesPrice.Text);
            }
            catch
            {
                errorMessage = "Indtast venligst et gyldigt varenummer, salgspris eller indkøbspris.";
            }

            return errorMessage;
        }

        private void textBoxEAN_TextChanged(object sender, EventArgs e)
        {
            textBoxEAN.BackColor = SystemColors.Window;
        }

        private void textBoxProductName_TextChanged(object sender, EventArgs e)
        {
            textBoxProductName.BackColor = SystemColors.Window;
        }

        private void textBoxPurchasePrice_TextChanged(object sender, EventArgs e)
        {
            textBoxPurchasePrice.BackColor = SystemColors.Window;
        }

        private void textBoxSalesPrice_TextChanged(object sender, EventArgs e)
        {
            textBoxSalesPrice.BackColor = SystemColors.Window;
            submitButton.Image = Properties.Resources.SaveButton;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new MainPageWallpaper());
        }
    }
}
