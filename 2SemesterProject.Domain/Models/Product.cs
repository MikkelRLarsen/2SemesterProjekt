using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
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
        [NotMapped]
        public int QuantityInOrder { get; set; }
        [NotMapped]
        public decimal TotalPrice { get; set; }
        public List<ProductLine> ProductLines { get; }
        public string ProductInfo { get {return $"{Name} [{NumberInStock} på lager] - {PricePerUnit} kr. [EAN: {EAN}"; } }
        public string ProductInOrderInfo { get { return $"{QuantityInOrder}x {Name} - {TotalPrice} kr. [max. {NumberInStock}]"; } }

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
