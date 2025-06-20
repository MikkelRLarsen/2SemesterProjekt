﻿using System.Data;
using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProjekt.Domain.Models;
using _2SemesterProjekt.Pages.UserControls.MainPageWallpaperControl;
using Microsoft.Extensions.DependencyInjection;

namespace _2SemesterProjekt.Pages.UserControls.ProductUserControl
{
    public partial class CustomerCartPage : UserControl
    {
        public List<Product> _productsInCart;
        public List<InCartProductCard> _cartProductCards;
        private Panel _mainPagePanel;
        private Customer _customer;
        private CreateOrderPage _createOrderPage;

        private readonly IOrderService _orderService;
        private readonly ICustomerService _customerService;
        private readonly IProductLineService _productLineService;
        private readonly IProductService _productService;

        public CustomerCartPage(List<Product> order, Panel mainPagePanel, CreateOrderPage createOrderPage)
        {
            InitializeComponent();
            _mainPagePanel = mainPagePanel;
            _productsInCart = order;
            _cartProductCards = new List<InCartProductCard>();
            _createOrderPage = createOrderPage;

            _orderService = ServiceProviderSingleton.GetServiceProvider().GetService<IOrderService>()!;
            _customerService = ServiceProviderSingleton.GetServiceProvider().GetService<ICustomerService>()!;
            _productLineService = ServiceProviderSingleton.GetServiceProvider().GetService<IProductLineService>()!;

            IServiceScope scope = ServiceProviderSingleton.GetServiceProvider().CreateScope();
            _productService = scope.ServiceProvider.GetService<IProductService>()!; /* This ensure that the Listbox gets the newest
                                                                                    * data everytime the user wants to create an order.*/
        }

        private void CustomerCartPage_Load(object sender, EventArgs e)
        {

            foreach (var productCard in _cartProductCards)
            {
                flowPanel.Controls.Add(productCard);
            }

            UpdateTotalPrice();
        }

        public void ReloadCustomerCart(List<Product> updatedOrder)
        {
            flowPanel.Controls.Clear();

            foreach (var product in updatedOrder)
            {
                product.SetNumberInStockOnOrderPage(); // Updates stock label on this page
            }

            _productsInCart = updatedOrder; // Updates the list of orders

            foreach (var productCard in _cartProductCards)
            {
                productCard.UpdateCardPanel();
                flowPanel.Controls.Add(productCard);
            }

            UpdateTotalPrice();
        }

        private async void createOrderButton_Click(object sender, EventArgs e)
        {
            // Checks if the added quantities of each product can be added to the order.
            bool orderCanBeCreated = await _orderService.CheckIfOrderCanBeCreated(_productsInCart.ToList());

            if (orderCanBeCreated == false) // Quantity in order > quantity in stock
            {
                DialogResult messageBoxError = MessageBox.Show("Ordren kan ikke oprettes, da der ikke kan tilføjes det ønskede antal af en/nogle af produkterne til ordren. Tjek venligst lagerbeholdning.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (discountNumericUpDown.Value >= 60) // Discount warning box
            {
                DialogResult messageBoxResult = MessageBox.Show("Indtastet rabat er over 60%. Er du sikker på, at du vil fortsætte?", "Advarsel", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (messageBoxResult == DialogResult.No)
                {
                    return;
                }
            }

            if (_customer == null) // The user didn't enter a customer's phone number.
            {
                await CreateOrderWithoutCustomerInfo();
            }

            if (_customer != null) // An order will be created with a customerID.
            {
                await CreateOrderWithCustomerInfo();
            }

            _cartProductCards = new List<InCartProductCard>();
            LoadAndShowProductCards(_cartProductCards);
        }

        private async void searchForCustomerButton_Click(object sender, EventArgs e)
        {
            Customer customer = null;

            if (string.IsNullOrWhiteSpace(customerPhoneNumberTextbox.Text) || customerPhoneNumberTextbox.Text.Length <= 7 || customerPhoneNumberTextbox.Text.Length >= 9)
            {
                DialogResult messageBoxError = MessageBox.Show("Invalidt telefonnummer. Prøv igen", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int phoneNumber = Convert.ToInt32(customerPhoneNumberTextbox.Text);
                customer = await _customerService.GetCustomerByPhoneNumberAsync(phoneNumber);
            }
            // retrieve customer by phone number
            if (customer == null) // Customer with this phone number doesn't exist in the DB
            {
                customerNameLabel.Text = "Kunne ikke finde kunden.";
                customerNameLabel.Visible = true;
                customerAddressLabel.Visible = false;
                customerEmailLabel.Visible = false;
                _customer = null;
            }
            else // Customer with this phone number exists
            {
                customerNameLabel.Text = $"{customer.FirstName} {customer.LastName}";
                customerAddressLabel.Text = $"{customer.Address}";
                customerEmailLabel.Text = $"{customer.Email}";
                customerNameLabel.Visible = true;
                customerAddressLabel.Visible = true;
                customerEmailLabel.Visible = true;
                _customer = customer;
            }
        }

        private void customerPhoneNumberTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // The user is only able to enter numbers in the textbox.
            }
        }

        private async Task CreateOrderWithoutCustomerInfo()
        {
            DialogResult messageBoxResult = MessageBox.Show("Du har ikke tilføjet en kunde, som findes i systemet. Vil du stadigvæk fortsætte?", "Advarsel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (messageBoxResult == DialogResult.No)
            {
                return;
            }
            else // An order will be created without a customerID.
            {
                // Creates an order and returns the ID.
                int orderID = await _orderService.CreateOrderAsync(Convert.ToDecimal(totalPriceTextBox.Text));

                // Creates product lines associated with the order for each product in the order.
                await _productLineService.CreateProductLinesAsync(orderID, _productsInCart.ToList());

                // Updates the stock status of each product in the order.
                await _productService.UpdateSeveralProductsAsync(_productsInCart.ToList());
                DialogResult messageBoxConfirmation = MessageBox.Show($"Ordren er blevet oprettet.\n Ordre #{orderID}\n Anonym kunde", "Ordre oprettet", MessageBoxButtons.OK, MessageBoxIcon.Information);

                foreach(var product in _productsInCart)
                {
                    product.ResetQuantityInOrder();
                }

                // Empties the current order list

                _cartProductCards.Clear();
                _productsInCart.Clear();
                _createOrderPage.EmptyItemsInCart();

                _mainPagePanel.Controls.Remove(this);
                _mainPagePanel.Controls.Remove(_createOrderPage);
                _mainPagePanel.Controls.Add(new MainPageWallpaper());
            }
        }

        private async Task CreateOrderWithCustomerInfo()
        {
            // Creates an order associated with the customer and returns the ID.
            int orderID = await _orderService.CreateOrderWithCustomerIDAsync(_customer.CustomerID, Convert.ToDecimal(totalPriceTextBox.Text));

            // Creates product lines associated with the order for each product in the order.
            await _productLineService.CreateProductLinesAsync(orderID, _productsInCart.ToList());

            // Updates the stock status of each product in the order.
            await _productService.UpdateSeveralProductsAsync(_productsInCart.ToList());

            DialogResult messageBoxConfirmation = MessageBox.Show($"Ordren er blevet oprettet.\n Ordre #{orderID}\n {_customer.FirstName} {_customer.LastName} \n {_customer.PhoneNumber} \n {_customer.Address}", "Ordre oprettet", MessageBoxButtons.OK, MessageBoxIcon.Information);

            foreach (var product in _productsInCart)
            {
                product.ResetQuantityInOrder();
            }

            // Clears the current order list
            _cartProductCards.Clear();
            _productsInCart.Clear();
            _createOrderPage.EmptyItemsInCart();

            _mainPagePanel.Controls.Remove(this);
            _mainPagePanel.Controls.Remove(_createOrderPage);
            _mainPagePanel.Controls.Add(new MainPageWallpaper());
        }

        private void discountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            totalPriceTextBox.Text = (Convert.ToDecimal(totalPriceTextBox.Text) * ((100 - discountNumericUpDown.Value) / 100)).ToString();
            UpdateTotalPrice();
        }

        /// <summary>
        /// Calculates total price without discount
        /// </summary>
        private decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0;

            foreach (var product in _productsInCart)
            {
                totalPrice += product.TotalPrice;
            }

            return totalPrice;
        }

        /// <summary>
        /// Updates total price textbox based on products and discount
        /// </summary>
        public void UpdateTotalPrice()
        {
            decimal basePrice = CalculateTotalPrice();
            decimal discount = discountNumericUpDown.Value;
            decimal finalPrice = basePrice * ((100 - discount) / 100);

            totalPriceTextBox.Text = finalPrice.ToString("0.00");
        }

        private async void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            _createOrderPage.UpdateProductCards();
        }

        public FlowLayoutPanel GetFlowLayoutPanelFromCustomerCart()
        {
            return flowPanel;
        }

        public async void LoadAndShowProductCards(IEnumerable<InCartProductCard> productCardsToBeLoaded)
        {
            // Clears the panel and then adds the wanted ProductCards
            flowPanel.Controls.Clear();
            flowPanel.Controls.AddRange(productCardsToBeLoaded.ToArray());
        }

        private void productSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxProduct.Text == string.Empty)
                {
                    LoadAndShowProductCards(_cartProductCards);
                }
                else
                {
                    // Search by name
                    IEnumerable<InCartProductCard> inCartProductCards = _cartProductCards
                        .Where(p => p.ProductCard._productData.Name.Contains(textBoxProduct.Text, StringComparison.OrdinalIgnoreCase));

                    LoadAndShowProductCards(inCartProductCards);

                    // No hits - show user
                    if (flowPanel.Controls.Count == 0)
                    {
                        MessageBox.Show($"Ingen hits på \"{textBoxProduct.Text}\"", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    textBoxProduct.Text = string.Empty;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------//
        // META-VALIDATION METHODS (FOR THE INDIVIDUEL USER CONTROL BOXES):
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------//

        private void textBoxProduct_Enter(object sender, EventArgs e)
        {
            // Removes placeholder text from textbox
            textBoxProduct.ForeColor = SystemColors.WindowText;
            textBoxProduct.Text = string.Empty;
        }

        private void textBoxProduct_Leave(object sender, EventArgs e)
        {
            // Adds placeholder text to textbox
            if (textBoxProduct.Text == String.Empty)
            {
                textBoxProduct.ForeColor = SystemColors.InactiveCaption;
                textBoxProduct.Text = "Søg på produktnavn";
            }
        }

        private void productSearchButton_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void productSearchButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void createOrderButton_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void createOrderButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void cancelButton_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void cancelButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void searchForCustomerButton_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void searchForCustomerButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void textBoxProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                productSearchButton_Click(sender, e);
            }
        }
    }
}
