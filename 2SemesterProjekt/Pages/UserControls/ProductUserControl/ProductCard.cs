using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2SemesterProjekt.Domain.Models;
using _2SemesterProjekt.Pages;

namespace _2SemesterProjekt
{
    public partial class ProductCard : UserControl
    {
        private Product _product; // Holds Product data

        public ProductCard(Product product)
        {
            _product = product;
            InitializeComponent();
            InitializeUIDesign();
        }

        private void InitializeUIDesign()
        {
            productEANLabel.Text = _product.EAN.ToString();
            productNameLabel.Text = _product.Name;
            productPurchasePriceLabel.Text = _product.PurchasePricePerUnit.ToString();
            productSalesPriceLabel.Text = _product.SalesPricePerUnit.ToString();
            inStockLabel.Text = _product.NumberInStock.ToString();
            minStockLabel.Text = _product.MinNumberInStock.ToString();
            categoryLabel.Text = _product.Type;
        }
    }
}
