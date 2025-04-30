using _2SemesterProject.Domain.Interfaces.RepositoryInterfaces;
using _2SemesterProject.Domain.Models;
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
        public async Task<IEnumerable<Product>> ExportStockStatusToTxt()
        {
            return await _db.Products.ToListAsync();
        }
    }
}
