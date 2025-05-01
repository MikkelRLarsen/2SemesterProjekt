using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProject.Domain.Models
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
    }
}
