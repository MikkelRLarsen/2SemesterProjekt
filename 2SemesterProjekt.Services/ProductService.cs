using _2SemesterProject.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProject.Domain.Interfaces.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<string> ExportStockStatusToTxtAsync()
        {
            var products = await _productRepository.ExportStockStatusToTxt(); // Retrieves a list of products in the DB
            if (products == null)
            {
                return "Error"; // Returned to the UI so it can generate an error message.
            }
            else
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

                string stockList = productList.Insert(0, $"Værdi af lagerbeholdning: {stockWorth}\n\n");
                // The Insert()-method inserts the string at index 0 in productList.
                
                return stockList;
            }
        }
    }
}
