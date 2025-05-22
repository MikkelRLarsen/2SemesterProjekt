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
    public partial class InCartProductCardUpdated : UserControl
    {
        public ProductCardUpdated ProductCardUpdated { get; set; }

        public InCartProductCardUpdated(ProductCardUpdated productCard)
        {
            ProductCardUpdated = productCard;
            ProductCardUpdated.SetInCartWrapper(this);
            InitializeComponent();
            InitializeUIDesign();
        }

        private void InitializeUIDesign()
        {
            cardPanel.Controls.Clear();
            cardPanel.Controls.Add(ProductCardUpdated);
            amountLabel.Text = ProductCardUpdated._product.QuantityInOrder.ToString();
        }

        public void UpdateAmountLabel()
        {
            amountLabel.Text = ProductCardUpdated._product.QuantityInOrder.ToString();
        }
    }
}
