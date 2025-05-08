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
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public async Task CreateOrderAsync(decimal totalPrice)
        {
            await _orderRepository.CreateOrderAsync(totalPrice);
        }

        public async Task<int> CreateOrderWithCustomerIDAsync(int customerID, decimal totalPrice)
        {
            return await _orderRepository.CreateOrderWithCustomerIDAsync(customerID, totalPrice);
        }
    }
}
