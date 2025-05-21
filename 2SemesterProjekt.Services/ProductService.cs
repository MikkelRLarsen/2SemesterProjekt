using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProjekt.Domain.Interfaces.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2SemesterProjekt.Domain.Models;

namespace _2SemesterProjekt.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IExportService _exportService;

        public ProductService(IProductRepository productRepository, IExportService exportService)
        {
            _productRepository = productRepository;
            _exportService = exportService;
        }
        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _productRepository.GetAllProductsAsync(); // Retrieves a list of products from the DB
        }

        public async Task ExportStockStatusToTxtAsync(string fileName)
        {
            var productList = await _productRepository.GetAllProductsAsync(); // Retrieves a list of products
            await _exportService.ExportStockStatusToTxtAsync(productList, fileName); /* The productList gets passed into the called method,
                                                                                * which will then be added to a textfile. */
        }

        public async Task<IEnumerable<Product>> GetAllProductsInStockAsync()
        {
            return await _productRepository.GetAllProductsInStockAsync(); // Retrieves a list of products in stock from the DB
        }

        public async Task UpdateSeveralProductsAsync(IEnumerable<Product> products)
        {
            await _productRepository.UpdateSeveralProductsQuantityAsync(products); // Updates the stock quantity of several products in the DB
        }

        public async Task CreateProductAsync(Product product)
        {
            Product checkIfProductExists = await GetProductByEANAsync(product.EAN);

            if (checkIfProductExists != null)
            {
                throw new ArgumentException("The product with the given EAN already exists.");
            }
            else
            {
                await _productRepository.CreateProductAsync(product);
            }
        }

        public async Task<Product> GetProductByEANAsync(long eAN)
        {
            return await _productRepository.GetProductByEANAsync(eAN);
        }
    }
}
