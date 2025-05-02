using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
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
        private readonly IExportService _exportService;
        public ProductPage()
        {
            InitializeComponent();
            _productService = ServiceProviderSingleton.GetServiceProvider().GetService<IProductService>();
            _exportService = ServiceProviderSingleton.GetServiceProvider().GetService<IExportService>();
            buttonFlowPanel.Controls.Add(new ButtonPanel("Eksporter til .txt", "", Color.MediumSeaGreen, ExportToTxt_Click));
        }

        private async void ExportToTxt_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Tekstfil|*.txt";
            saveFileDialog.FileName = $"Lagerbeholdning.txt";
            saveFileDialog.Title = "Gem din tekstfil";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _productService.ExportStockStatusToTxtAsync(saveFileDialog.FileName);
                NotificationMessage("Filen er blevet oprettet.");
            }
            
        }
        private void NotificationMessage(string typeOfMsg)
        {
            MessageBox.Show(typeOfMsg, "Information", MessageBoxButtons.OK);
        }
    }
}
