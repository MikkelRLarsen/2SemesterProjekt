using _2SemesterProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProject.Domain.Interfaces.ServiceInterfaces
{
    public interface IProductService
    {
        public Task<IEnumerable<Product>> GetAllProductsAsync();
        public void ExportAllProductsToTxtAsync(string fileName);
    }
}
