﻿using System;
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
        public int QuantityInOrder { get; private set; }
        public decimal TotalPrice { get; private set; }
        public List<ProductLine> ProductLines { get; }
        public string ProductInfo { get {return $"{Name} [{NumberInStock} på lager] - {SalesPricePerUnit} kr. [EAN: {EAN}"; } } // This will only be used for a WinForms listbox
        public string ProductInOrderInfo { get { return $"{QuantityInOrder}x {Name} - {TotalPrice} kr. [max. {NumberInStock}]"; } } // This will only be used for a WinForms listbox

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
        public void UpdateQuantityInOrder()
        {
            QuantityInOrder += 1;
        }
        public void UpdateTotalPriceOfProductInOrder()
        {
            TotalPrice = QuantityInOrder * SalesPricePerUnit;
        }
        public void RemoveQuantityInOrder()
        {
            QuantityInOrder = 0;
        }
        public void RemoveTotalOrderPrice()
        {
            TotalPrice = 0;
        }
    }
}
