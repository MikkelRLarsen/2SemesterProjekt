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

        public Task<bool> CheckIfOrderCanBeCreated(List<Product> order)
        {
            foreach (Product product in order)
            {
                if (product.QuantityInOrder > product.NumberInStock)
                {
                    return Task.FromResult(false);
                }
            }
            return Task.FromResult(true);
        }

        public async Task<int> CreateOrderAsync(decimal totalPrice)
        {
            return await _orderRepository.CreateOrderAsync(totalPrice);
        }

        public async Task<int> CreateOrderWithCustomerIDAsync(int customerID, decimal totalPrice)
        {
            return await _orderRepository.CreateOrderWithCustomerIDAsync(customerID, totalPrice);
        }
    }
}
