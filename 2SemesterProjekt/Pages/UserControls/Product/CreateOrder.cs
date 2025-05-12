using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProjekt.Domain.Models;
using _2SemesterProjekt.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2SemesterProjekt.Pages.UserControls.Product
{
    public partial class CreateOrder : UserControl
    {
        FlowLayoutPanel _orderPanel;
        private readonly IProductService _productService;
        private readonly ICustomerService _customerService;
        private readonly IOrderService _orderService;
        private readonly IProductLineService _productLineService;

        private decimal _totalPrice; // The total price for the order is stored here.
        private decimal _totalPriceWithDiscount = -1; /* The total price for the order with an added discount is
                                                       * stored here. If there is no added discount, the default
                                                       * value remains -1. */

        private BindingList<Domain.Models.Product> _order; // Products in the order is stored here.
        private BindingList<Domain.Models.Product> _allProducts; // Products in stock is stored here.

        private Domain.Models.Product _selectedProduct; // Selected product in the allProductsListBox
        private Domain.Models.Product _selectedProductInOrder; // Selected product in the orderProductsListbox

        private Customer _customer; // The customer, whose ID will be associated with the order, is stored here.
        public CreateOrder(FlowLayoutPanel orderPanel)
        {
            InitializeComponent();
            _orderPanel = orderPanel;

            IServiceScope scope = ServiceProviderSingleton.GetServiceProvider().CreateScope();
            _productService = scope.ServiceProvider.GetService<IProductService>();

            //_productService = ServiceProviderSingleton.GetServiceProvider().GetService<IProductService>();
            _customerService = ServiceProviderSingleton.GetServiceProvider().GetService<ICustomerService>();
            _orderService = ServiceProviderSingleton.GetServiceProvider().GetService<IOrderService>();
            _productLineService = ServiceProviderSingleton.GetServiceProvider().GetService<IProductLineService>();

            _order = new BindingList<Domain.Models.Product>();
        }

        private async void CreateOrder_Load(object sender, EventArgs e)
        {
            _allProducts = new BindingList<Domain.Models.Product>((List<Domain.Models.Product>)await _productService.GetAllProductsInStockAsync()); // Add products in stock to list
            allProductsListBox.DataSource = _allProducts; // This listbox will show the products in stock
            allProductsListBox.DisplayMember = "ProductInfo";
            orderProductsListBox.DataSource = _order; // This listbox will show the products added to the order
            orderProductsListBox.DisplayMember = "ProductInOrderInfo";
        }

        private void customerPhoneNumberTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // The user is only able to enter numbers in the textbox.
            }
        }

        private async void getCustomerButton_Click(object sender, EventArgs e)
        {
            Customer customer = null;
            if (string.IsNullOrWhiteSpace(customerPhoneNumberTextbox.Text) || customerPhoneNumberTextbox.Text.Length <= 7)
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

        private async void createOrderButton_Click(object sender, EventArgs e)
        {
            bool continueOrderCreation = false;
            bool orderCanBeCreated = await _orderService.CheckIfOrderCanBeCreated(_order.ToList()); // Checks if the added quantities of each product can be added to the order.

            if (!orderCanBeCreated) // Quantity in order > quantity in stock
            {
                DialogResult messageBoxError = MessageBox.Show("Ordren kan ikke oprettes, da der ikke kan tilføjes det ønskede antal af en/nogle af produkterne til ordren. Tjek venligst lagerbeholdning.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else // Quantity in order < quantity in stock
            {
                continueOrderCreation = true;
            }

            while (continueOrderCreation)
            {
                if (discountNumericUpDown.Value >= 60) // Discount warning box
                {
                    DialogResult messageBoxResult = MessageBox.Show("Indtastet rabat er over 60%. Er du sikker på, at du vil fortsætte?", "Advarsel", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (messageBoxResult == DialogResult.No)
                    {
                        continueOrderCreation = false;
                        return;
                    }
                    else
                    {
                        continueOrderCreation = true;
                    }
                }
                if (_customer == null) // The user didn't enter a customer's phone number.
                {
                    DialogResult messageBoxResult = MessageBox.Show("Du har ikke tilføjet en kunde, som findes i systemet. Vil du stadigvæk fortsætte?", "Advarsel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (messageBoxResult == DialogResult.No)
                    {
                        continueOrderCreation = false;
                        return;
                    }
                    else // An order will be created without a customerID.
                    {
                        int orderID = await _orderService.CreateOrderAsync(_totalPrice, _totalPriceWithDiscount); // Creates an order and returns the ID.
                        await _productLineService.CreateProductLinesAsync(orderID, _order.ToList()); // Creates product lines associated with the order for each product in the order.
                        await _productService.UpdateSeveralProductsAsync(_order.ToList()); // Updates the stock status of each product in the order.
                        DialogResult messageBoxConfirmation = MessageBox.Show($"Ordren er blevet oprettet.\n Ordre #{orderID}\n Anonym kunde", "Ordre oprettet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Parent.Controls.Clear();
                        return;
                    }
                }
                if (_customer != null) // An order will be created with a customerID.
                {
                    int orderID = await _orderService.CreateOrderWithCustomerIDAsync(_customer.CustomerID, _totalPrice, _totalPriceWithDiscount); // Creates an order associated with the customer and returns the ID.
                    await _productLineService.CreateProductLinesAsync(orderID, _order.ToList()); // Creates product lines associated with the order for each product in the order.
                    await _productService.UpdateSeveralProductsAsync(_order.ToList()); // Updates the stock status of each product in the order.
                    DialogResult messageBoxConfirmation = MessageBox.Show($"Ordren er blevet oprettet.\n Ordre #{orderID}\n {_customer.FirstName} {_customer.LastName} \n {_customer.PhoneNumber} \n {_customer.Address}", "Ordre oprettet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Parent.Controls.Clear();
                    return;
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Clear();
        }

        private void discountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (_totalPrice != 0)
            {
                decimal discount = (_totalPrice * ((100 - discountNumericUpDown.Value) / 100));
                totalPriceInfoLabel.Text = discount.ToString(); // Updates UI
                _totalPriceWithDiscount = discount; // Updates the total price with the added discount
            }
        }

        private async void addToOrderButton_Click(object sender, EventArgs e)
        {
            _selectedProduct = (Domain.Models.Product)allProductsListBox.SelectedItem; // Sets the product, that is selected in the listbox, as the product that will get added to the order.

            if (_selectedProduct == null)
            {
                allProductsListBox.SetSelected(0, true); // The first product in the listbox is set as the selected item.
                _selectedProduct = (Domain.Models.Product)allProductsListBox.SelectedItem;
            }

            if (_order.Any(pr => pr.EAN == _selectedProduct.EAN)) // If the order already contains the product, nothing will happen.
            {
                return;
            }
            else if (_selectedProduct != null)
            {
                _selectedProduct.QuantityInOrder = 1; // Update quantity
                _selectedProduct.TotalPrice = _selectedProduct.QuantityInOrder * _selectedProduct.PricePerUnit; // Update total price
                _order.Add(_selectedProduct); // Add to order

                orderProductsListBox.DataSource = _order; // Update order listbox data source
                orderProductsListBox.Refresh(); // Update control

                _totalPrice += _selectedProduct.PricePerUnit; // Update the total price for the order
                totalPriceInfoLabel.Text = $"{_totalPrice.ToString()} kr.";
                totalPriceInfoLabel.Refresh();

                _allProducts.Remove(_selectedProduct); // Remove product from the listbox that shows products in stock
                _allProducts.ResetBindings();
                allProductsListBox.Refresh();

                if (_allProducts.Count == 0)
                {
                    addToOrderButton.Enabled = false;
                }
            }
            if (removeFromOrderButton.Enabled == false || addMoreButton.Enabled == false || createOrderButton.Enabled == false) // Enable buttons
            {
                removeFromOrderButton.Enabled = true;
                addMoreButton.Enabled = true;
                createOrderButton.Enabled = true;
            }
        }

        private void AddMoreButton_Click(object sender, EventArgs e)
        {
            if (_selectedProductInOrder == null)
            {
                orderProductsListBox.SetSelected(0, true); // The first product in the listbox is set as the selected item.
                _selectedProductInOrder = (Domain.Models.Product)orderProductsListBox.SelectedItem;
            }

            _selectedProductInOrder.QuantityInOrder += 1; // Updates the quantity of the product in the order
            _selectedProductInOrder.TotalPrice += _selectedProductInOrder.PricePerUnit; // Updates the total price of the product in the order
            _totalPrice += _selectedProductInOrder.PricePerUnit; // Updates the total price of the order

            totalPriceInfoLabel.Text = $"{_totalPrice.ToString()} kr.";
            totalPriceInfoLabel.Refresh();
            _order.ResetBindings();
            orderProductsListBox.DataSource = _order;
            orderProductsListBox.Refresh();
        }

        private void removeFromOrder_Click(object sender, EventArgs e)
        {
            _selectedProductInOrder = (Domain.Models.Product)orderProductsListBox.SelectedItem; // Sets the product, that is selected in the listbox, as the product that will get added to the order.

            if (_selectedProductInOrder == null)
            {
                orderProductsListBox.SetSelected(0, true); // The first product in the listbox is set as the selected item.
            }

            _totalPrice -= _selectedProductInOrder.TotalPrice; // Substracts the total order price of the product(s) from the total price of the order.
            _selectedProductInOrder.QuantityInOrder = 0; // Sets quantity in order to 0.
            _selectedProductInOrder.TotalPrice = 0; // Sets total order price of the product to 0
            _allProducts.Add(_selectedProductInOrder); // The products moves back to the list of products in stock
            _order.Remove(_selectedProductInOrder); // The product gets removed from the order.

            _order.ResetBindings();
            allProductsListBox.Refresh();
            orderProductsListBox.Refresh();
            totalPriceInfoLabel.Text = $"{_totalPrice.ToString()} kr.";
            totalPriceInfoLabel.Refresh();

            if (_order.Count == 0) // Buttons get disabled if there are no products left in the order.
            {
                removeFromOrderButton.Enabled = false;
                addMoreButton.Enabled = false;
                createOrderButton.Enabled = false;
            }
            if (!addToOrderButton.Enabled) // Enables this button so the user can add products to the order again
            {
                addToOrderButton.Enabled = true;
            }
        }

        private void allProductsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedProduct = (Domain.Models.Product)allProductsListBox.SelectedItem;
        }

        private void orderProductsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedProductInOrder = (Domain.Models.Product)orderProductsListBox.SelectedItem;
        }
    }
}
