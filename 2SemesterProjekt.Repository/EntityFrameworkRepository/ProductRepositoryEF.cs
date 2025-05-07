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
            return await _db.Products.FirstOrDefaultAsync(pr => pr.EAN == eAN);
        }
    }
}
