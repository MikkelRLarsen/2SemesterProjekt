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
    public partial class InCartProductCard : UserControl
    {
        public ProductCard ProductCard { get; set; }
        public Product Product { get; set; }

        public InCartProductCard(ProductCard productCard, Product product, FlowLayoutPanel cartPanel)
        {
            ProductCard = productCard;
            Product = product;
            InitializeComponent();
            InitializeUIDesign();
        }

        private void InitializeUIDesign()
        {
            cardPanel.Controls.Clear();
            ProductCard.UpdateInStockLabel(Product);
            cardPanel.Controls.Add(ProductCard);
            quantityLabel.Text = $"{ProductCard._productData.QuantityInOrder.ToString()}x";
        }

        public void UpdateAmountLabel()
        {
            quantityLabel.Text = $"{ProductCard._productData.QuantityInOrder.ToString()}x";
        }
        public void UpdateCardPanel()
        {
            cardPanel.Refresh();
        }
        public void UpdateAmountUpDown(int addAmount)
        {
            var amountSelector = ProductCard.Controls
                .OfType<NumericUpDown>()
                .First();

            amountSelector.Maximum += addAmount;
        }
    }
}
