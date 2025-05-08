using _2SemesterProjekt.Domain.Interfaces.RepositoryInterfaces;
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

        public Task CreateOrderAsync(decimal totalPrice)
        {
            throw new NotImplementedException();
        }

        public Task CreateOrderWithCustomerIDAsync(int customerID, decimal totalPrice)
        {
            throw new NotImplementedException();
        }
    }
}
