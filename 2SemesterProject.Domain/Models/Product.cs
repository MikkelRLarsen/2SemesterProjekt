using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Domain.Models
{
    public class Product
    {
        public int ProductID { get; init; }
        public string Name { get; private set; }
        public long EAN { get; private set;}
        public string Type { get; private set; }
        public decimal PricePerUnit { get; private set; }
        public int NumberInStock { get; private set; }
        public int MinNumberInStock { get; private set; }

        public Product(string name, long eAN, string type, decimal pricePerUnit, int numberInStock, int minNumberInStock)
        {
            Name = name;
            EAN = eAN;
            Type = type;
            PricePerUnit = pricePerUnit;
            NumberInStock = numberInStock;
            MinNumberInStock = minNumberInStock;
        }
    }
}
