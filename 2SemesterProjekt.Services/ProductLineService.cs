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
    public class ProductLineService : IProductLineService
    {
        private readonly IProductLineRepository _productLineRepository;
        public ProductLineService(IProductLineRepository productRepository)
        {
            _productLineRepository = productRepository;
        }

        public async Task CreateProductLinesAsync(int orderID, List<Product> products)
        {
            await _productLineRepository.CreateProductLinesAsync(orderID, products);
        }
    }
}
