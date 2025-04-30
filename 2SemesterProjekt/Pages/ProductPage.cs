using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2SemesterProjekt.Pages
{
    public partial class ProductPage : UserControl
    {
        public ProductPage()
        {
            InitializeComponent();
            buttonFlowPanel.Controls.Add(new ButtonPanel("Eksporter til .txt", "", Color.MediumSeaGreen, ExportToTxt_Click));
        }

        private void ExportToTxt_Click(object sender, EventArgs e)
        {

        }
    }
}
