using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Domain.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int? CustomerID { get; set; }
        
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public List<ProductLine> ProductLines { get; }

        public Order(int orderID, int? customerID, DateTime orderDate, decimal totalPrice)
        {
            OrderID = orderID;
            CustomerID = customerID;
            OrderDate = orderDate;
            TotalPrice = totalPrice;
        }
        public Order(int orderID, DateTime orderDate, decimal totalPrice)
        {
            OrderID = orderID;
            OrderDate = orderDate;
            TotalPrice = totalPrice;
        }
    }
}
