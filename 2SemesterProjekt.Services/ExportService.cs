using _2SemesterProjekt.Domain.Interfaces;
using _2SemesterProjekt.Domain.Interfaces.RepositoryInterfaces;
using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProjekt.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Services
{
    public class ExportService : IExportService
    {
        public async Task ExportToTxtAsync(string txtData, string fileName)
        {
            await File.WriteAllTextAsync(fileName, txtData);
            // Creates a textfile.
        }

        public async Task ExportStockStatusToTxtAsync(IEnumerable<Product> products, string fileName)
        {
            string productList = ""; // Info about the products will get saved here.
            decimal stockWorth = 0; // The worth of the stock will get saved here.
            foreach (var product in products)
            {
                if (product.MinNumberInStock > product.NumberInStock)
                {
                    productList += $"(VAREN HAR RAMT MINIMUMSBEHOLDNING)\n" +
                                  $"Varenummer: {product.EAN},\n" +
                                  $"Produktnavn: {product.Name},\n" +
                                  $"Pris pr. styk: {product.SalesPricePerUnit},\n" +
                                  $"Antal på lager: {product.NumberInStock},\n" +
                                  $"Minimumsantal: {product.MinNumberInStock}\n\n" +
                                  "******************************************\n\n";

                }
                else
                {
                    productList += $"Varenummer: {product.EAN},\n" +
                                  $"Produktnavn: {product.Name},\n" +
                                  $"Pris pr. styk: {product.SalesPricePerUnit},\n" +
                                  $"Antal på lager: {product.NumberInStock},\n" +
                                  $"Minimumsantal: {product.MinNumberInStock}\n\n" +
                                  "******************************************\n\n";
                }
                stockWorth += product.NumberInStock * product.SalesPricePerUnit;
            }

            string txtData = productList.Insert(0, $"Værdi af lagerbeholdning: {stockWorth}\n\n");
            // The Insert()-method inserts the string at index 0 in productList.

            await ExportToTxtAsync(txtData, fileName);
            // Calls the file creation method.
        }

        public async Task ExportInvoiceToTxtAsync(IExport invoice, string fileName)
        {
            // Calls the file creation method.
            await ExportToTxtAsync(invoice.GetExportDetails(), fileName);
        }
    }
}
