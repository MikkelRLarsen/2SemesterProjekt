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
        public CreateOrder(FlowLayoutPanel orderPanel)
        {
            InitializeComponent();
            _orderPanel = orderPanel;
        }


    }
}
