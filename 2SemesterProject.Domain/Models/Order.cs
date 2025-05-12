using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Domain.Models
{
    public class Order
    {
        public int OrderID { get; private set; }
        public int? CustomerID { get; private set; }
        
        public DateTime OrderDate { get; private set; }
        public decimal TotalPrice { get; private set; }
        public List<ProductLine> ProductLines { get; }
        public Customer Customer { get; }

        public Order(int? customerID, DateTime orderDate, decimal totalPrice)
        {
            CustomerID = customerID;
            OrderDate = orderDate;
            TotalPrice = totalPrice;

            CustomerValid();
            PriceValid();
        }
        public Order(DateTime orderDate, decimal totalPrice)
        {
            OrderDate = orderDate;
            TotalPrice = totalPrice;

            PriceValid();
        }

        protected void CustomerValid()
        {
            if (CustomerID == 0)
            {
                throw new ArgumentException("CustomerID is 0");
            }
        }

        protected void PriceValid()
        {
            if (TotalPrice < 0)
            {
                throw new ArgumentException("TotalPrice is a negative number");
            }
        }
    }
}
