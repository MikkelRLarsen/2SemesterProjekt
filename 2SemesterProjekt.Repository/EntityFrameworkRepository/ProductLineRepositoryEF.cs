using _2SemesterProjekt.Domain.Interfaces.RepositoryInterfaces;
using _2SemesterProjekt.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Repository.EntityFrameworkRepository
{
    public class ProductLineRepositoryEF : IProductLineRepository
    {
        private readonly EntityFramework _db;
        public ProductLineRepositoryEF(EntityFramework db)
        {
            _db = db;
        }

        public async Task CreateProductLinesAsync(ProductLine productLine)
        {
            await _db.AddAsync(productLine);
            await _db.SaveChangesAsync();
        }
    }
}
