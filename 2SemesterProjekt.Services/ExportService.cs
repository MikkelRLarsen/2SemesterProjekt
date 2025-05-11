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
        public async void ExportToTxtAsync(string txtData, string fileName)
        {
            File.WriteAllText(fileName, txtData);
            // Creates a textfile.
        }

        public async void ExportStockStatusToTxtAsync(IEnumerable<Product> products, string fileName)
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
            // Calls the file creation method.
        }

        public async void ExportInvoiceToTxtAsync(Examination examination, string fileName)
        {
            string invoice = $"FAKTURA FOR {examination.ExaminationType.Description.ToUpper()} AF {examination.Pet.Name.ToUpper()}\n" +
                             $"Kundenavn: {examination.Pet.Customer.FirstName} {examination.Pet.Customer.LastName}\n" +
                             $"Kæledyr: {examination.Pet.Name}\n" +
                             $"Udført behandling: {examination.ExaminationTypeID} {examination.ExaminationType.Description} {examination.Price}\n" +
                             $"Udført den: {examination.Date}\n" +
                             $"Totalpris: {examination.Price}\n" +
                             $"Betalingsbetingelser: Netto 7 dage {DateTime.Now.AddDays(7)}\n\n" +
                             $"Beløbet indbetales på bankkonto:\n" +
                             $"Bank / Reg.nr. 1234 / Kontonr. 12345678";

            ExportToTxtAsync(invoice, fileName);
        }
    }
}
