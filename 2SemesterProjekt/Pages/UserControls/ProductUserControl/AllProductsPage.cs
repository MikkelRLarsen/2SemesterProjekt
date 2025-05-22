using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProjekt.Pages.UserControls.Product;
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
    public partial class AllProductsPage : UserControl
    {
        private readonly IProductService _productService;
        private List<ProductCardUpdated> _allProductCards = new List<ProductCardUpdated>();
        public AllProductsPage()
        {
            InitializeComponent();
            _productService = ServiceProviderSingleton.GetServiceProvider().GetService<IProductService>();
        }
        private async void ProductPage_Load(object sender, EventArgs e)
        {

            Task.Run(() => GetAllProductsAsync());
        }

        private async void GetAllProductsAsync()
        {
            IEnumerable<Domain.Models.Product> allProducts = await _productService.GetAllProductsAsync();

            foreach (Domain.Models.Product product in allProducts)
            {
                _allProductCards.Add(new ProductCardUpdated(product));
            }
        }
        private void findAllButton_Click(object sender, EventArgs e)
        {
            ViewAllProducts();
        }

        private void ViewAllProducts()
        {
            flowPanel.Controls.Clear();
            flowPanel.Controls.AddRange(_allProductCards.ToArray());
        }

        private async void ExportToTxtButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Tekstfil|*.txt";
            saveFileDialog.FileName = $"Lagerbeholdning.txt";
            saveFileDialog.Title = "Gem din tekstfil";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                await _productService.ExportStockStatusToTxtAsync(saveFileDialog.FileName);
                NotificationMessage("Filen er blevet oprettet.");
            }
        }

        private void NotificationMessage(string typeOfMsg)
        {
            MessageBox.Show(typeOfMsg, "Information", MessageBoxButtons.OK);
        }
    }
}
