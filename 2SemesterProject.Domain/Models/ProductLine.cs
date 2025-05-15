using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Domain.Models
{
    public class ProductLine
    {
        public int ProductLineID { get; private set; }
        public int ProductID { get; private set; }
        public int OrderID { get; private set; }
        public int Quantity { get; private set; }
        public decimal Price { get; private set; }
        public Order Order { get; }
        public Product Product { get; }

        public ProductLine(int productID, int orderID, int quantity, decimal price)
        {
            ProductID = productID;
            OrderID = orderID;
            Quantity = quantity;
            Price = price;
        }
    }
}
