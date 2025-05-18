using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2SemesterProjekt.Domain.Models;
using _2SemesterProjekt.Pages.UserControls.UserControlInterfaces;

namespace _2SemesterProjekt.Pages.UserControls.ProductUserControl
{
    public partial class InCartProductCardUpdated : UserControl
    {
        public Domain.Models.Product _product; // Holds Product data
        private readonly FlowLayoutPanel _flowLayout;
        private readonly CustomerCartPage _customerCartPage;
        private readonly CreateOrderPage _createOrderPage;

        public InCartProductCardUpdated(Domain.Models.Product product, FlowLayoutPanel flowLayout, CustomerCartPage customerCartPage, CreateOrderPage createOrderPage)
        {
            _product = product;
            _flowLayout = flowLayout;
            _createOrderPage = createOrderPage;
            _customerCartPage = customerCartPage;
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
            amountLabel.Text = _product.QuantityInOrder.ToString();
        }

        private void pictureBox_DoubleClick(object sender, EventArgs e)
        {
            var dialogBox = new AmountDialogBox(_product, _product.QuantityInOrder);

            if (dialogBox.ShowDialog() == DialogResult.OK)
            {
                _product.RemoveQuantityFromOrder(dialogBox.Amount); // Update quantity
                _product.IncreaseInStock(dialogBox.Amount); // Update in stock
                _customerCartPage.UpdateTotalPrice();

                if (_product.QuantityInOrder == 0)
                {
                    _customerCartPage._order.Remove(_product);
                    _flowLayout.Controls.Remove(this);
                }

                inStockLabel.Text = _product.NumberInStock.ToString();
                amountLabel.Text = _product.QuantityInOrder.ToString();
                _createOrderPage.DecreaseItemsInCart(this);
            }
        }
    }
}
