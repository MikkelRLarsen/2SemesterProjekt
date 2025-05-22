using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProjekt.Domain.Models;
using _2SemesterProjekt.Services;
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

namespace _2SemesterProjekt.Pages
{
    public partial class ProductPage : UserControl
    {
        private readonly IProductService _productService;
        public List<OldProductCard> AllProductCards { get; set; } = new List<OldProductCard>();
        public ProductPage()
        {
            InitializeComponent();
            _productService = ServiceProviderSingleton.GetServiceProvider().GetService<IProductService>();            
        }

        private async void ProductPage_Load(object sender, EventArgs e)
        {
            buttonFlowPanel.Controls.Add(new ButtonPanel("Vis produkter", Color.Goldenrod, ViewAllProducts));
            buttonFlowPanel.Controls.Add(new ButtonPanel("Opret ordre", Color.MediumSeaGreen, CreateOrder));
            buttonFlowPanel.Controls.Add(new ButtonPanel("Eksporter til .txt", Color.MediumSlateBlue, ExportToTxt_Click));

            Task.Run(() => GetAllProductsAsync());
        }

        private async void GetAllProductsAsync()
        {
            IEnumerable<Product> allProducts = await _productService.GetAllProductsAsync();

            foreach (Product product in allProducts)
            {
                AllProductCards.Add(new OldProductCard(product));
            }
        }

        private void ViewAllProducts(object sender, EventArgs e)
        {
            productFlowPanel.Controls.Clear();
            productFlowPanel.Controls.AddRange(AllProductCards.ToArray());
        }

        private void CreateOrder(object sender, EventArgs e)
        {
            productFlowPanel.Controls.Clear(); // Clear existing content
           // productFlowPanel.Controls.Add(new CreateOrder(productFlowPanel)); // Load the new page - From old branch before UI update
        }

        private async void ExportToTxt_Click(object sender, EventArgs e)
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
