using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2SemesterProjekt.Pages.UserControls.MedicineUserControl
{
    public partial class MedicineUserControl : UserControl
    {
        FlowLayoutPanel _konsultationPanl;
        public MedicineUserControl(FlowLayoutPanel konsultationPanl)
        {
            InitializeComponent();
            _konsultationPanl = konsultationPanl;
            
            //Hardcode muligheder til ordinering af medicin:
            OrdineretDropdownBox.Items.AddRange(new string[] { "Ja", "Nej" });

        }

        private void OrdineretDropdownBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectedValue = OrdineretDropdownBox.SelectedItem.ToString();

            if (selectedValue == "Ja")
            {
                
            }
            else if (selectedValue == "Nej")
            {
                MedicineDropdownBox.Enabled = false;
            }
        }
    }
}
