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
        public async Task<string> ExportStockStatusToTxt()
        {
            var products = await _productRepository.ExportStockStatusToTxt();
            if (products == null)
            {
                return "Error";
            }
            else
            {
                string productList = "";
                decimal stockWorth = 0;
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
                
                return stockList;
            }
        }
    }
}
