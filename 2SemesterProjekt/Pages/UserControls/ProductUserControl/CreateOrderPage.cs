using System.ComponentModel;
using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProjekt.Domain.Models;
using _2SemesterProjekt.Pages.UserControls.MainPageWallpaperControl;
using Microsoft.Extensions.DependencyInjection;

namespace _2SemesterProjekt.Pages.UserControls.ProductUserControl
{
    public partial class CreateOrderPage : UserControl
    {
        public List<Product> _order = new List<Product>(); // Products in the order is stored here.
        private readonly IProductService _productService;
        private int _itemsInCart;
        private Panel _mainPagePanel;
        private CustomerCartPage _customerCartPage;
        public List<ProductCard> _allProductCards = new List<ProductCard>();

        public CreateOrderPage(Panel mainPagePanel)
        {
            InitializeComponent();
            _mainPagePanel = mainPagePanel;

            _productService = ServiceProviderSingleton.GetServiceProvider().GetService<IProductService>()!;

            _order = new List<Product>();
            _customerCartPage = new CustomerCartPage(_order, _mainPagePanel);
        }

        private async void CreateOrderPage_Load(object sender, EventArgs e)
        {
            Task.Run(() => FindAndSetAllProductsAsync());
        }

        private async void FindAndSetAllProductsAsync()
        {
            IEnumerable<Product> allProductsInStock = await _productService.GetAllProductsInStockAsync();

            foreach (var product in allProductsInStock)
            {
                _allProductCards.Add(new ProductCard(this, _customerCartPage, this.flowPanel, product, ProductCard.CardMode.AddToCart));
            }

            findAllButton.Image = Properties.Resources.FindAllButton;
        }

        public async void LoadAndShowProductCards(IEnumerable<ProductCard> productCardsToBeLoaded)
        {
            // Clears the panel and then adds the wanted ExaminationCards
            flowPanel.Controls.Clear();
            flowPanel.Controls.AddRange(productCardsToBeLoaded.ToArray());
        }

        private void findAllButton_Click(object sender, EventArgs e)
        {
            LoadAndShowProductCards(_allProductCards);
        }

        public void IncrementItemsInCart(int amount)
        {
            _itemsInCart += amount;

            itemsInCart.Text = _itemsInCart.ToString();
        }

        public void DecreaseItemsInCart(int amount)
        {
            _itemsInCart -= amount;

            itemsInCart.Text = _itemsInCart.ToString();
        }

        private void goToCartButton_Click(object sender, EventArgs e)
        {
            _mainPagePanel.Controls.Add(_customerCartPage);

            _customerCartPage.BringToFront();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            _mainPagePanel.Controls.Remove(this);
            _mainPagePanel.Controls.Add(new MainPageWallpaper());
        }

        private void productSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Search by name
                IEnumerable<ProductCard> productCards = _allProductCards
                    .Where(p => p._productData.Name.Contains(textBoxProduct.Text, StringComparison.OrdinalIgnoreCase));

                LoadAndShowProductCards(productCards);

                // No hits - show user
                if (flowPanel.Controls.Count == 0)
                {
                    MessageBox.Show($"Ingen hits på \"{textBoxProduct.Text}\"", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                textBoxProduct.Text = string.Empty;
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

        private void cancelButton_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void cancelButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void customerSearchButton_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void customerSearchButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void findAllButton_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void findAllButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void goToCartButton_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void goToCartButton_MouseLeave(object sender, EventArgs e)
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
