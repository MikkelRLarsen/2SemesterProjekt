using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using Microsoft.Extensions.DependencyInjection;

namespace _2SemesterProjekt.Pages.UserControls.ProductUserControl
{
    public partial class AllProductsPage : UserControl
    {
        private readonly IProductService _productService;
        private List<ProductCard> _allProductCards = new List<ProductCard>();
        public AllProductsPage()
        {
            InitializeComponent();
            _productService = ServiceProviderSingleton.GetServiceProvider().GetService<IProductService>();
        }
        private async void ProductPage_Load(object sender, EventArgs e)
        {

            Task.Run(() => GetAllProductsAsync());
        }

        private async void GetAllProductsAsync()
        {
            IEnumerable<Domain.Models.Product> allProducts = await _productService.GetAllProductsAsync();

            foreach (Domain.Models.Product product in allProducts)
            {
                _allProductCards.Add(new ProductCard(product));
            }
        }
        private void findAllButton_Click(object sender, EventArgs e)
        {
            ViewAllProducts();
        }

        private void ViewAllProducts()
        {
            flowPanel.Controls.Clear();
            flowPanel.Controls.AddRange(_allProductCards.ToArray());
        }

        private async void ExportToTxtButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Tekstfil|*.txt";
            saveFileDialog.FileName = $"Lagerbeholdning.txt";
            saveFileDialog.Title = "Gem din tekstfil";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                await _productService.ExportStockStatusToTxtAsync(saveFileDialog.FileName);
                NotificationMessage("Filen er blevet oprettet.");
            }
        }

        private void NotificationMessage(string typeOfMsg)
        {
            MessageBox.Show(typeOfMsg, "Information", MessageBoxButtons.OK);
        }
    }
}
