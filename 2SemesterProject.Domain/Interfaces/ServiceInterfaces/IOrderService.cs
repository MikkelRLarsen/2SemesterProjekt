using _2SemesterProjekt.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces
{
    public interface IOrderService
    {
        public Task<int> CreateOrderWithCustomerIDAsync(int customerID, decimal totalPrice);
        public Task<int> CreateOrderAsync(decimal totalPrice);
        //public Task<bool> CheckIfOrderCanBeCreated(List<Product> order);
    }
}
