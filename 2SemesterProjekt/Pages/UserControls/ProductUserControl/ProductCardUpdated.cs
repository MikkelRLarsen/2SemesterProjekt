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
        private CustomerCartPage _customerCartPage;
        private InCartProductCardUpdated _inCartWrapper;
        private ProductCardMode _mode;
        public enum ProductCardMode
        {
            AddToCart,
            RemoveFromCart
        }

        public ProductCardUpdated(
            CreateOrderPage createOrderPage,
            CustomerCartPage customerCartPage,
            FlowLayoutPanel layoutPanel,
            Domain.Models.Product product,
            ProductCardMode cardMode
            )
        {
            _createOrderPage = createOrderPage;
            _customerCartPage = customerCartPage;
            _layoutPanel = layoutPanel;
            _product = product;
            _mode = cardMode;

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

        private void pictureBox_DoubleClick(object sender, EventArgs e)
        {
            if (_mode == ProductCardMode.AddToCart)
            {
                var dialogBox = new AmountDialogBox(_product, _product.NumberInStock);

                if (dialogBox.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                _product.AddQuantityToOrder(dialogBox.Amount);
                _product.DecreaseInStock(dialogBox.Amount);
                _product.UpdateTotalPriceOfProductInOrder();

                if (!_customerCartPage._productCardsInOrder.Contains(this))
                {
                    _customerCartPage._order.Add(_product);

                    _customerCartPage._productCardsInOrder.Add(
                        new ProductCardUpdated(
                        _createOrderPage,
                        _customerCartPage,
                        _layoutPanel,
                        _product,
                        ProductCardUpdated.ProductCardMode.RemoveFromCart)
                    );
                }

                if (_product.NumberInStock == 0)
                {
                    _layoutPanel.Controls.Remove(this);
                }

                _createOrderPage.IncrementItemsInCart(dialogBox.Amount);
            }
            else if (_mode == ProductCardMode.RemoveFromCart)
            {
                var dialogBox = new AmountDialogBox(_product, _product.QuantityInOrder);

                if (dialogBox.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                _product.RemoveQuantityFromOrder(dialogBox.Amount);
                _product.IncreaseInStock(dialogBox.Amount);
                _product.UpdateTotalPriceOfProductInOrder();

                bool alreadyExistsInLayout = _layoutPanel.Controls
                    .OfType<ProductCardUpdated>()
                    .Any(pc => pc._product == _product && pc._mode == ProductCardMode.AddToCart);

                if (alreadyExistsInLayout == false)
                {
                    var newCard = new ProductCardUpdated(
                        _createOrderPage,
                        _customerCartPage,
                        _layoutPanel,
                        _product,
                        ProductCardMode.AddToCart
                    );

                    _layoutPanel.Controls.Add(newCard);
                }

                if (alreadyExistsInLayout == false)
                {
                    //alreadyExistsInLayout.inStockLabel.Text = _product.NumberInStock.ToString();
                }

                if (_product.QuantityInOrder == 0)
                {
                    _customerCartPage._productCardsInOrder.Remove(this);
                    _layoutPanel.Controls.Remove(this);
                    _customerCartPage._order.Remove(_product);
                }

                _createOrderPage.DecreaseItemsInCart(dialogBox.Amount);
                _inCartWrapper?.UpdateAmountLabel();
            }

            inStockLabel.Text = _product.NumberInStock.ToString();
        }

        public void SetInCartWrapper(InCartProductCardUpdated wrapper)
        {
            _inCartWrapper = wrapper;
        }
    }
}
