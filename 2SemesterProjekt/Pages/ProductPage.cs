using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2SemesterProjekt.Pages
{
    public partial class ProductPage: UserControl
    {
        public ProductPage()
        {
            InitializeComponent();
            buttonFlowPanel.Controls.Add(new ButtonPanel("Find kæledyr", "FindCustomer.png", Color.SteelBlue));
            buttonFlowPanel.Controls.Add(new ButtonPanel("Tilføj kæledyr", "AddCustomer.png", Color.MediumSeaGreen));
            buttonFlowPanel.Controls.Add(new ButtonPanel("Redigér kæledyr", "EditCustomer.png", Color.Goldenrod));
            buttonFlowPanel.Controls.Add(new ButtonPanel("Fjern kæledyr", "RemoveCustomer.png", Color.IndianRed));
        }
    }
}
