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
        public Task ExportToTxtAsync(string exportType, string fileName);
        public Task ExportStockStatusToTxtAsync(IEnumerable<Product> products, string fileName);
        public Task ExportInvoiceToTxtAsync(Invoice invoiceExamination, string fileName);
    }
}
