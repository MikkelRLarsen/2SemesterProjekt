using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Domain.Models
{
    public class ProductLine
    {
        public int ProductLineID { get; set; }
        public int ProductID { get; set; }
        public int OrderID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
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
