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
        public void CreateTxtFileAsync(string exportType, string fileName);
        public Task<bool> CheckIfTxtCanBeCreated(string exportType);
    }
}
