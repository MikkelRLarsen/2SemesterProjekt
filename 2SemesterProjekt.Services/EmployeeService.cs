using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProjekt.Domain.Models;

namespace _2SemesterProjekt.Services
{
    class EmployeeService : IEmployeeService
    {
        public Task<IEnumerable<Employee>> GetAllEmployeeAsync()
        {
            throw new NotImplementedException();
        }
        public Employee GetEmployeeById(int employeeId)
        {
            throw new NotImplementedException();
        }
        public void UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
        public void DeleteEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
        public void CreateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
