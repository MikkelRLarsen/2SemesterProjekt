using _2SemesterProject.Domain.Interfaces.ServiceInterfaces;
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
        public ProductPage()
        {
            InitializeComponent();
            _productService = ServiceProviderSingleton.GetServiceProvider().GetService<IProductService>();
            buttonFlowPanel.Controls.Add(new ButtonPanel("Eksporter til .txt", "", Color.MediumSeaGreen, ExportToTxt_Click));
        }

        private async void ExportToTxt_Click(object sender, EventArgs e)
        {
            string txtValue = await _productService.ExportStockStatusToTxt(); // Retrieves a list of products in the DB
            if (txtValue == "Error")
            {
                NotificationMessage("Der opstod en fejl: Tekstfilen kunne ikke oprettes.");
            }
            if (txtValue != "Error" || txtValue != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Tekstfil|*.txt";
                saveFileDialog.FileName = $"Lagerbeholdning.txt";
                saveFileDialog.Title = "Gem din tekstfil";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, txtValue);
                    NotificationMessage($"Tekstfilen er blevet oprettet og gemt.");
                }
            }
        }
        private void NotificationMessage(string typeOfMsg)
        {
            MessageBox.Show(typeOfMsg, "Information", MessageBoxButtons.OK);
        }
    }
}
