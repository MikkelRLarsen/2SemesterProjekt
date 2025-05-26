using _2SemesterProjekt.Domain.Models;

namespace _2SemesterProjekt.Pages.UserControls.ProductUserControl
{
    public partial class ProductCard : UserControl
    {
        // Product that represents data in the card
        public Product _productData;

        // References to UI panels for adding and removing product cards
        private FlowLayoutPanel _addProductPanel;
        private FlowLayoutPanel _cartItemsPanel;

        // References to parent pages for order and cart
        private CreateOrderPage _orderPage;
        private CustomerCartPage _cartPage;

        // Enum indicating the current mode of the card (add or remove)
        private CardMode _cardMode;

        public enum CardMode
        {
            AddToCart,
            RemoveFromCart
        }

        // For CreateOrderPage
        public ProductCard(
            CreateOrderPage createOrderPage,
            CustomerCartPage customerCartPage,
            FlowLayoutPanel layoutPanel,
            Product product,
            CardMode cardMode
            )
        {
            _orderPage = createOrderPage;
            _cartPage = customerCartPage;
            _addProductPanel = layoutPanel;
            _productData = product;
            _cardMode = cardMode;
            _cartItemsPanel = _cartPage.GetFlowLayoutPanelFromCustomerCart();
            _productData.SetNumberInStockOnOrderPage();
            InitializeComponent();
            InitializeUIDesign();
        }

        // For find product
        public ProductCard(Product product)
        {
            _productData = product;
            
        }
        public ProductCard()
        {

        }

        /// <summary>
        /// Sets up the UI based on card-type
        /// </summary>
        private void InitializeUIDesign()
        {
            if (_cardMode == CardMode.AddToCart)
            {
                cardButton.Image = Properties.Resources.AddToCartButton;
                amountUpDown.Maximum = _productData.NumberInStock;
            }
            else
            {
                cardButton.Image = Properties.Resources.RemoveFromCartButton;
                amountUpDown.Maximum = _productData.QuantityInOrder;
            }

            productEANLabel.Text = _productData.EAN.ToString();
            productNameLabel.Text = _productData.Name;
            CenterLabelHorizontally(productNameLabel);
            productPurchasePriceLabel.Text = _productData.PurchasePricePerUnit.ToString();
            productSalesPriceLabel.Text = _productData.SalesPricePerUnit.ToString();
            inStockLabel.Text = _productData.NumberInStockOrderPage.ToString();
            minStockLabel.Text = _productData.MinNumberInStock.ToString();
            categoryLabel.Text = _productData.Type;
        }

        /// <summary>
        /// Centers the productname label
        /// </summary>
        private void CenterLabelHorizontally(Label label)
        {
            int formWidth = this.Width;
            int labelX = (formWidth - label.Width) / 2;
            label.Location = new Point(labelX, label.Location.Y);
        }

        private void cardButton_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(amountUpDown.Value);

            if (quantity <= 0)
            {
                if (_cardMode == CardMode.AddToCart)
                {
                    MessageBox.Show("Indtast et tal over 0 for at tilføje til kurven.", "Ugyldigt input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Indtast et tal over 0 for at fjerne fra kurven.", "Ugyldigt input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                return; // Stopper videre kørsel
            }

            // Based on card-type (add or remove)
            if (_cardMode == CardMode.AddToCart)
            {
                AddProductToCart(quantity);
            }
            else
            {
                RemoveProductFromCart(quantity);
            }

            amountUpDown.Value = 0;
        }

        /// <summary>
        /// Adds the product to the cart based on given amount
        /// </summary>
        private void AddProductToCart(int quantity)
        {
            // Updates the model for later order creation
            _productData.AddQuantityToOrder(quantity);
            int newStock = _productData.NumberInStockOrderPage;
            inStockLabel.Text = newStock.ToString();
            inStockLabel.Refresh();
            _productData.UpdateTotalPriceOfProductInOrder();

            // Checks if the card already exists in the cart, if not => create and add new card
            if (_cartPage._productsInCart.Any(p => p.ProductID == _productData.ProductID) == false)
            {
                AddProductCardToCart();
            }
            else
            {
                UpdateCartProductCard(quantity);
            }

            // Removes card from the add-panel if the product is out of stock
            if (newStock == 0)
            {
                _addProductPanel.Controls.Remove(this);
            }

            _orderPage.IncrementItemsInCart(quantity);
            amountUpDown.Maximum = newStock;
            _orderPage.Refresh();
        }

        /// <summary>
        /// Removes the product from the cart based on given amount
        /// </summary>
        private void RemoveProductFromCart(int quantity)
        {
            _productData.RemoveQuantityFromOrder(quantity);
            _productData.UpdateTotalPriceOfProductInOrder();
            int newStock = _productData.NumberInStockOrderPage;
            inStockLabel.Text = newStock.ToString();
            inStockLabel.Refresh();

            // Checks if the card was removed earlier to re-add it to the add-panel
            if (_orderPage._allProductCards.Any(p => p._productData.ProductID == _productData.ProductID) == false)
            {
                AddNewAddProductCard();
            }

            // Find the corresponding cart product cart
            var cartProductCard = _cartPage._cartProductCards
                .First(c => c.ProductCard._productData.ProductID == _productData.ProductID);

            // Removes card from the cart-panel if the product is fully removed
            if (_productData.QuantityInOrder == 0)
            {
                _cartPage._cartProductCards.Remove(cartProductCard);
                _cartItemsPanel.Controls.Remove(cartProductCard);
                _cartPage._productsInCart.Remove(_productData);
            }

            _orderPage.DecreaseItemsInCart(quantity);
            cartProductCard.UpdateAmountLabel();
            cartProductCard.UpdateAmountUpDown(quantity);
            _productData.SetNumberInStockOnOrderPage();
            inStockLabel.Refresh();

            UpdateInStockLabelInAddProductCard(quantity);
        }

        /// <summary>
        /// Creates and adds a new product card
        /// </summary>
        private void AddProductCardToCart()
        {
            _orderPage._order.Add(_productData);
            _cartPage._productsInCart.Add(_productData);

            // Create a new product card in "RemoveFromCart" mode to represent the product in the cart
            var productCard = new ProductCard(_orderPage, _cartPage, _addProductPanel, _productData, CardMode.RemoveFromCart);

            // Wrap the ProductCard in a UI component that handles how it is displayed inside the cart panel
            var wrappedCard = new InCartProductCard(productCard, _productData, _cartItemsPanel);

            _cartPage._cartProductCards.Add(wrappedCard);
        }

        public void UpdateInStockLabel(Product product)
        {
            inStockLabel.Text = product.NumberInStockOrderPage.ToString();
            inStockLabel.Refresh();
        }

        /// <summary>
        /// Updates quantity and in-stock label on an existing product card in cart
        /// </summary>
        private void UpdateCartProductCard(int quantity)
        {
            _orderPage._order.Remove(_productData);
            _orderPage._order.Add(_productData);
            var card = _cartPage._cartProductCards
                .First(c => c.ProductCard._productData.ProductID == _productData.ProductID);

            var labelInSpecificCard = card.Controls
                // Get all panel controls inside the current cart card wrapper
                .OfType<Panel>()
                // Find the panel named "cardPanel" that contains the actual product card
                .First(p => p.Name == "cardPanel")
                .Controls
                // Get the product card control inside the panel
                .OfType<ProductCard>()
                // Find the product card that matches the current product by product id
                .First(c => c._productData.ProductID == _productData.ProductID)
                .Controls
                // Get all label controls inside the ProductCard
                .OfType<Label>()
                // Find the label named "inStockLabel" that displays number in stock
                .First(l => l.Name == "inStockLabel");

            labelInSpecificCard.Text = _productData.NumberInStockOrderPage.ToString();

            card.UpdateAmountLabel();
            card.UpdateAmountUpDown(quantity);
        }

        /// <summary>
        /// Adds a new card to the add-panel
        /// </summary>
        private void AddNewAddProductCard()
        {
            var newCard = new ProductCard(
                _orderPage,
                _cartPage,
                _addProductPanel,
                _productData,
                CardMode.AddToCart
            );

            _addProductPanel.Controls.Add(newCard);
        }

        /// <summary>
        /// Updates in-stock label in the add-panel
        /// </summary>
        private void UpdateInStockLabelInAddProductCard(int quantity)
        {
            var addToOrderCard = _orderPage._allProductCards
                .First(c => c._productData.ProductID == _productData.ProductID);

            var labelInSpecificCard = addToOrderCard.Controls
                // Get all label controls inside the ProductCard
                .OfType<Label>()
                // Find the label named "inStockLabel" that displays number in stock
                .First(l => l.Name == "inStockLabel");

            labelInSpecificCard.Text = (_productData.NumberInStock + quantity).ToString();
        }

        private void cardButton_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void cardButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
