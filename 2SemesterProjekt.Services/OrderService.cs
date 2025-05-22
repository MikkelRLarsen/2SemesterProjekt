using _2SemesterProjekt.Domain.Interfaces.RepositoryInterfaces;
using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProjekt.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Linq.Expressions;
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

        public async Task<int> CreateOrderAsync(decimal totalPrice/*, decimal totalPriceWithDiscount*/)
        {
            //if (totalPriceWithDiscount != -1) // If the totalPriceWithDiscount field doesn't remain its default value
            //{
            //    Order order = new Order(
            //    DateTime.Now,
            //    totalPriceWithDiscount);
            //    return await _orderRepository.CreateOrderAsync(order);
            //}
            //else
            //{
                Order order = new Order(
                DateTime.Now,
                totalPrice);
                return await _orderRepository.CreateOrderAsync(order);
            //}
        }

        public async Task<int> CreateOrderWithCustomerIDAsync(int customerID, decimal totalPrice)
        {
            Order order = new Order(
            customerID,
            DateTime.Now,
            totalPrice);
            return await _orderRepository.CreateOrderAsync(order);
        }
    }
}
