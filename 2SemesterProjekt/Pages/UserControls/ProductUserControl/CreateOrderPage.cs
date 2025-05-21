using System.ComponentModel;
using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProjekt.Domain.Models;
using Microsoft.Extensions.DependencyInjection;

namespace _2SemesterProjekt.Pages.UserControls.ProductUserControl
{
    public partial class CreateOrderPage : UserControl
    {
        public List<Domain.Models.Product> _order; // Products in the order is stored here.
        public BindingList<Domain.Models.Product> _allProducts; // Products in stock is stored here.
        private readonly IProductService _productService;
        private readonly ICustomerService _customerService;
        private readonly IOrderService _orderService;
        private readonly IProductLineService _productLineService;
        private int _itemsInCart;
        private Panel _mainPagePanel;
        private CustomerCartPage _customerCartPage;
        public List<ProductCardUpdated> AllProductCards { get; set; } = new List<ProductCardUpdated>();

        public CreateOrderPage(Panel mainPagePanel)
        {
            InitializeComponent();
            _mainPagePanel = mainPagePanel;

            IServiceScope scope = ServiceProviderSingleton.GetServiceProvider().CreateScope();
            _productService = scope.ServiceProvider.GetService<IProductService>(); /* This ensure that the Listbox gets the newest
                                                                                    * data everytime the user wants to create an order.*/
            _customerService = ServiceProviderSingleton.GetServiceProvider().GetService<ICustomerService>();
            _orderService = ServiceProviderSingleton.GetServiceProvider().GetService<IOrderService>();
            _productLineService = ServiceProviderSingleton.GetServiceProvider().GetService<IProductLineService>();

            _order = new List<Domain.Models.Product>();
            _customerCartPage = new CustomerCartPage(_order, _mainPagePanel, this);
        }

        private async void CreateOrderPage_Load(object sender, EventArgs e)
        {
            Task.Run(() => FindAndSetAllProductsAsync());
        }

        private async void FindAndSetAllProductsAsync()
        {
            IEnumerable<Domain.Models.Product> allProductsInStock = await _productService.GetAllProductsInStockAsync();

            foreach (var product in allProductsInStock)
            {
                AllProductCards.Add(new ProductCardUpdated(this, _customerCartPage, this.flowPanel, product, ProductCardUpdated.ProductCardMode.AddToCart));
            }
        }

        public async void LoadAndShowProductCards(IEnumerable<ProductCardUpdated> productCardsToBeLoaded)
        {
            // Clears the panel and then adds the wanted ExaminationCards
            flowPanel.Controls.Clear();
            flowPanel.Controls.AddRange(productCardsToBeLoaded.ToArray());
        }

        private void findAllButton_Click(object sender, EventArgs e)
        {
            LoadAndShowProductCards(AllProductCards);
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
    }
}
