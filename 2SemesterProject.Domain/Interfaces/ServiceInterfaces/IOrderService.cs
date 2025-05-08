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
        public Task CreateOrderWithCustomerIDAsync(int customerID, decimal totalPrice);
        public Task CreateOrderAsync(decimal totalPrice);
    }
}
