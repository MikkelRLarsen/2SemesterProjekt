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
        private decimal _totalPrice;
        private BindingList<Domain.Models.Product> _order;
        private BindingList<Domain.Models.Product> _allProducts;
        private Domain.Models.Product _selectedProduct;
        private Domain.Models.Product _selectedProductInOrder;
        private Customer _customer;
        public CreateOrder(FlowLayoutPanel orderPanel)
        {
            InitializeComponent();
            _orderPanel = orderPanel;
            _productService = ServiceProviderSingleton.GetServiceProvider().GetService<IProductService>();
            _customerService = ServiceProviderSingleton.GetServiceProvider().GetService<ICustomerService>();
            _order = new BindingList<Domain.Models.Product>();
        }

        private async void CreateOrder_Load(object sender, EventArgs e)
        {
            _allProducts = new BindingList<Domain.Models.Product>((List<Domain.Models.Product>)await _productService.GetAllProductsInStockAsync());
            allProductsListBox.DataSource = _allProducts;
            allProductsListBox.DisplayMember = "ProductInfo";
            orderProductsListBox.DataSource = _order;
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
            int phoneNumber = Convert.ToInt32(customerPhoneNumberTextbox.Text);
            Customer customer = await _customerService.GetCustomerByPhoneNumberAsync(phoneNumber);
            if (customer == null)
            {
                customerNameLabel.Text = "Kunne ikke finde kunden.";
                customerNameLabel.Visible = true;
                customerAddressLabel.Visible = false;
                customerEmailLabel.Visible = false;
                _customer = null;
            }
            else
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


        private void createOrderButton_Click(object sender, EventArgs e)
        {
            if (discountNumericUpDown.Value >= 60)
            {
                DialogResult messageBoxResult = MessageBox.Show("Indtastet rabat er over 60%. Er du sikker på, at du vil fortsætte?", "Advarsel", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (messageBoxResult == DialogResult.No)
                {
                    return;
                }
            }
            else if (customerPhoneNumberTextbox != null || customerNameLabel.Text == "Kunne ikke finde kunden.")
            {
                DialogResult messageBoxResult = MessageBox.Show("Du har ikke indtastet et telefonnummer, som findes i systemet. Vil du stadigvæk fortsætte?", "Advarsel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (messageBoxResult == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                if (_customer != null)
                {
                    int orderID = await _orderService.CreateOrderWithCustomerIDAsync(_customer.CustomerID, _totalPrice);
                    _productLineService.CreateProductLinesAsync(orderID, _order);
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
                totalPriceInfoLabel.Text = discount.ToString();
            }
        }

        private void allProductsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            _selectedProduct = (Domain.Models.Product)lb.SelectedItem;
        }

        private async void addToOrderButton_Click(object sender, EventArgs e)
        {
            _selectedProduct = (Domain.Models.Product)allProductsListBox.SelectedItem;

            if (_selectedProduct == null)
            {
                allProductsListBox.SetSelected(0, true);
            }

            long eAN = _selectedProduct.EAN;
            Domain.Models.Product productToSell = await _productService.GetProductByEANAsync(eAN);

            if (_order.Any(pr => pr.EAN == productToSell.EAN))
            {
                return;
            }
            else if (productToSell != null)
            {
                productToSell.QuantityInOrder = 1;
                productToSell.TotalPrice = productToSell.QuantityInOrder * productToSell.PricePerUnit;
                _order.Add(productToSell);
                orderProductsListBox.DataSource = _order;
                orderProductsListBox.Refresh();
                _allProducts.Remove(productToSell);
                _allProducts.ResetBindings();
                allProductsListBox.Refresh();

                _totalPrice += productToSell.PricePerUnit;
                totalPriceInfoLabel.Text = $"{_totalPrice.ToString()} kr.";
                totalPriceInfoLabel.Refresh();
            }
            if (removeFromOrderButton.Enabled == false || addMoreButton.Enabled == false)
            {
                removeFromOrderButton.Enabled = true;
                addMoreButton.Enabled = true;
            }
        }

        private void AddMoreButton_Click(object sender, EventArgs e)
        {
            if (_selectedProductInOrder == null)
            {
                orderProductsListBox.SetSelected(0, true);
            }
            _selectedProductInOrder.QuantityInOrder += 1;
            _selectedProductInOrder.TotalPrice += _selectedProductInOrder.PricePerUnit;
            _totalPrice += _selectedProductInOrder.PricePerUnit;

            totalPriceInfoLabel.Text = $"{_totalPrice.ToString()} kr.";
            totalPriceInfoLabel.Refresh();
            _order.ResetBindings();
            orderProductsListBox.DataSource = _order;
            orderProductsListBox.Refresh();
        }

        private void orderProductsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            _selectedProductInOrder = (Domain.Models.Product)lb.SelectedItem;
        }

        private void removeFromOrder_Click(object sender, EventArgs e)
        {
            _selectedProductInOrder = (Domain.Models.Product)orderProductsListBox.SelectedItem;

            if (_selectedProductInOrder == null)
            {
                orderProductsListBox.SetSelected(0, true);
            }

            _totalPrice -= _selectedProductInOrder.TotalPrice;
            _selectedProductInOrder.QuantityInOrder = 0;
            _selectedProductInOrder.TotalPrice = 0;
            _allProducts.Add(_selectedProductInOrder);
            _order.Remove(_selectedProductInOrder);

            _order.ResetBindings();
            allProductsListBox.Refresh();
            orderProductsListBox.Refresh();
            totalPriceInfoLabel.Text = $"{_totalPrice.ToString()} kr.";
            totalPriceInfoLabel.Refresh();

            if (_order.Count == 0)
            {
                removeFromOrderButton.Enabled = false;
                addMoreButton.Enabled = false;
            }
        }
    }
}
