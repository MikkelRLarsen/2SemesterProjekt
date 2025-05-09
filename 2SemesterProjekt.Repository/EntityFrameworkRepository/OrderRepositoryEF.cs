using _2SemesterProjekt.Domain.Interfaces.RepositoryInterfaces;
using _2SemesterProjekt.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Repository.EntityFrameworkRepository
{
    public class OrderRepositoryEF : IOrderRepository
    {
        private readonly EntityFramework _db;
        public OrderRepositoryEF(EntityFramework db)
        {
            _db = db;
        }
        public async Task<int> CreateOrderWithCustomerIDAsync(int customerID, decimal totalPrice)
        {
            Order order = new Order(
                customerID,
                DateTime.Now,
                totalPrice);

            await _db.Orders.AddAsync(order);
            
            _db.Entry(order).GetDatabaseValues();
            await _db.SaveChangesAsync();

            return order.OrderID;
        }
        public async Task<int> CreateOrderAsync(decimal totalPrice)
        {
            Order order = new Order(
                DateTime.Now,
                totalPrice);

            await _db.Orders.AddAsync(order);

            _db.Entry(order).GetDatabaseValues();
            await _db.SaveChangesAsync();

            return order.OrderID;
        }
    }
}
