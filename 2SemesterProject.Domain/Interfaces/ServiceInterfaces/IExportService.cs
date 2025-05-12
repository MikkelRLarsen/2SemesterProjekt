using _2SemesterProjekt.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces
{
    public interface IExportService
    {
        public void ExportToTxtAsync(string exportType, string fileName);
        public void ExportStockStatusToTxtAsync(IEnumerable<Product> products, string fileName);
        public void ExportInvoiceToTxtAsync(Examination examination, string fileName);
    }
}
