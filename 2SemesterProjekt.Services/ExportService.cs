using _2SemesterProject.Domain.Interfaces.RepositoryInterfaces;
using _2SemesterProject.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Services
{
    public class ExportService : IExportService
    {
        private readonly IProductService _productService;
        public ExportService(IProductService productService)
        {
            _productService = productService;
        }
        public async void ExportToTxtAsync(string txtData, string fileName)
        {
            File.WriteAllText(fileName, txtData);
        }
        public async void CreateTxtFileAsync(string exportType, string fileName)
        {
            if (exportType == "StockStatus")
            {
                var products = await _productService.GetAllProductsAsync();
                string productList = ""; // Info about the products will get saved here.
                decimal stockWorth = 0; // The worth of the stock will get saved here.
                foreach (var product in products)
                {
                    if (product.MinNumberInStock > product.NumberInStock)
                    {
                        productList += $"(VAREN HAR RAMT MINIMUMSBEHOLDNING)\n" +
                                      $"Varenummer: {product.EAN},\n" +
                                      $"Produktnavn: {product.Name},\n" +
                                      $"Pris pr. styk: {product.PricePerUnit},\n" +
                                      $"Antal på lager: {product.NumberInStock},\n" +
                                      $"Minimumsantal: {product.MinNumberInStock}\n\n" +
                                      "******************************************\n\n";

                    }
                    else
                    {
                        productList += $"Varenummer: {product.EAN},\n" +
                                      $"Produktnavn: {product.Name},\n" +
                                      $"Pris pr. styk: {product.PricePerUnit},\n" +
                                      $"Antal på lager: {product.NumberInStock},\n" +
                                      $"Minimumsantal: {product.MinNumberInStock}\n\n" +
                                      "******************************************\n\n";
                    }
                    stockWorth += product.NumberInStock * product.PricePerUnit;
                }

                string txtData = productList.Insert(0, $"Værdi af lagerbeholdning: {stockWorth}\n\n");
                // The Insert()-method inserts the string at index 0 in productList.

                ExportToTxtAsync(txtData, fileName);
            }
        }
        public async Task<bool> CheckIfTxtCanBeCreated(string exportType)
        {
            IEnumerable<dynamic> txtDataSource = new List<dynamic>();
            if (exportType == "StockStatus")
            {
                txtDataSource = await _productService.GetAllProductsAsync();
            }
            if (txtDataSource != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
