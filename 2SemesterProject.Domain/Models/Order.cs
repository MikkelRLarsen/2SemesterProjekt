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
        public Customer Customer { get; }

        public Order(int? customerID, DateTime orderDate, decimal totalPrice)
        {
            CustomerID = customerID;
            OrderDate = orderDate;
            TotalPrice = totalPrice;
        }
        public Order(DateTime orderDate, decimal totalPrice)
        {
            OrderDate = orderDate;
            TotalPrice = totalPrice;
        }
    }
}
