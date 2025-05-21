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
    public partial class ProductCardUpdated : UserControl
    {
        public Domain.Models.Product _product; // Holds Product data
        private FlowLayoutPanel _layoutPanel;
        private CreateOrderPage _createOrderPage;

        public ProductCardUpdated(CreateOrderPage createOrderPage, FlowLayoutPanel layoutPanel, Domain.Models.Product product)
        {
            _createOrderPage = createOrderPage;
            _layoutPanel = layoutPanel;
            _product = product;
            InitializeComponent();
            InitializeUIDesign();
        }

        public ProductCardUpdated(Domain.Models.Product product)
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
            productNumberInStockLabel.Text = _product.NumberInStock.ToString();
            productMinInStockLabel.Text = _product.MinNumberInStock.ToString();
            productCategoryLabel.Text = _product.Type;
        }

        private void pictureBox_DoubleClick(object sender, EventArgs e)
        {
            var dialogBox = new AmountDialogBox(_product, _product.NumberInStock);

            if (dialogBox.ShowDialog() == DialogResult.OK)
            {
                _product.AddQuantityToOrder(dialogBox.Amount); // Update quantity
                _product.DecreaseInStock(dialogBox.Amount); // Update in stock
                _product.UpdateTotalPriceOfProductInOrder(); // Update total price

                _createOrderPage._order.Add(_product); // Add to order

                if (_product.NumberInStock == 0)
                {
                    _layoutPanel.Controls.Remove(this);
                }

                _createOrderPage.IncrementItemsInCart(dialogBox.Amount);

                productNumberInStockLabel.Text = _product.NumberInStock.ToString();
            }
        }
    }
}
