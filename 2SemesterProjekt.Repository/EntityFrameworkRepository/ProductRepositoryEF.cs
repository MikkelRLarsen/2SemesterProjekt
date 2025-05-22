using _2SemesterProjekt.Domain.Interfaces.RepositoryInterfaces;
using _2SemesterProjekt.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Repository.EntityFrameworkRepository
{
    public class ProductRepositoryEF : IProductRepository
    {
        private readonly EntityFramework _db;

        public ProductRepositoryEF(EntityFramework db)
        {
            _db = db;
        }

        public async Task CreateProductAsync(Product product)
        {
            await _db.Products.AddAsync(product);
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _db.Products.ToListAsync();
        }
        public async Task<IEnumerable<Product>> GetAllProductsInStockAsync()
        {
            return await _db.Products
                .Where(pr => pr.NumberInStock > 0)
                .ToListAsync();
        }

        public async Task<Product> GetProductByEANAsync(long eAN)
        {
            Product product = await _db.Products.Where(pr => pr.EAN == eAN).FirstOrDefaultAsync();
            return product;
        }

        public async Task UpdateSeveralProductsQuantityAsync(IEnumerable<Product> products)
        {
            foreach (Product product in products)
            {
                int newNumberInStock = product.NumberInStock - product.QuantityInOrder; // Subtracts the quantity in order from the quantity in stock
                await _db.Products
                    .Where(pr => pr.ProductID == product.ProductID)
                    .ExecuteUpdateAsync(pr
                    => pr.SetProperty(pr => pr.NumberInStock, newNumberInStock)); // Sets the result of newNumberInStock as the products stock quantity.
            }
        }
    }
}
