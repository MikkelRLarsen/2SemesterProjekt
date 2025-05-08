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

            _db.Orders.Add(order);
            
            _db.Entry(order).GetDatabaseValues();
            _db.SaveChanges();

            return order.OrderID;
        }
        public Task CreateOrderAsync(decimal totalPrice)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetOrderID()
        {
            throw new NotImplementedException();
        }
    }
}
