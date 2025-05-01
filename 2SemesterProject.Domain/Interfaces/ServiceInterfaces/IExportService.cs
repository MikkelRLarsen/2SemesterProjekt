using _2SemesterProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProject.Domain.Interfaces.ServiceInterfaces
{
    public interface IExportService
    {
        public void ExportToTxtAsync(string exportType, string fileName);
        public void ExportAllProductsToTxtAsync(IEnumerable<Product> products, string fileName);
    }
}
