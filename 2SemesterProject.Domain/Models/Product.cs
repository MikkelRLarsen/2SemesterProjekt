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
        public decimal PurchasePricePerUnit { get; private set; }
        public decimal SalesPricePerUnit { get; private set; }
        public int NumberInStock { get; private set; }
        public int MinNumberInStock { get; private set; }
        public int NumberInStockOrderPage { get; private set; }
        public int QuantityInOrder { get; private set; }
        public decimal TotalPrice { get; private set; }
        public List<ProductLine> ProductLines { get; }
        

        public Product(string name, long eAN, string type, decimal purchasePricePerUnit, decimal salesPricePerUnit, int numberInStock, int minNumberInStock)
        {
            Name = name;
            EAN = eAN;
            Type = type;
            PurchasePricePerUnit = purchasePricePerUnit;
            SalesPricePerUnit = salesPricePerUnit;
            NumberInStock = numberInStock;
            MinNumberInStock = minNumberInStock;
        }
        public void SetNumberInStockOnOrderPage()
        {
            if (QuantityInOrder == 0)
            {
                NumberInStockOrderPage = NumberInStock;
            }
        }
        public void AddQuantityToOrder(int amount)
        {
            QuantityInOrder += amount;
            NumberInStockOrderPage -= amount;
        }
        public void RemoveQuantityFromOrder(int amount)
        { 
            QuantityInOrder -= amount;
            NumberInStockOrderPage += amount;
        }
        public void ResetQuantityInOrder()
        {
            QuantityInOrder = 0;
        }
        public void UpdateTotalPriceOfProductInOrder()
        {
            TotalPrice = QuantityInOrder * SalesPricePerUnit;
        }
    }
}
