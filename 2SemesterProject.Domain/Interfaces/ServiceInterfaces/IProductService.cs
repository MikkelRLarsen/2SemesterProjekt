using _2SemesterProjekt.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces
{
    public interface IProductService
    {
        public Task<IEnumerable<Product>> GetAllProductsAsync();
        public Task ExportStockStatusToTxtAsync(string fileName);
        public Task<IEnumerable<Product>> GetAllProductsInStockAsync();
        public Task UpdateSeveralProductsAsync(IEnumerable<Product> products);
        public Task CreateProductAsync(Product product);
    }
}
