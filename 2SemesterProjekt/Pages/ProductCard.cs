using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2SemesterProject.Domain.Models;
using _2SemesterProject.Domain.Models.ExaminationSection;

namespace _2SemesterProjekt
{
    public partial class ProductCard: UserControl
    {
        private Examination _examination;
        
        public ProductCard(Examination product)
        {
            InitializeComponent();
            _examination = product;
            InitializeUIDesign();
        }

        private void InitializeUIDesign()
		{
            productIdLabel.Text = _examination.ExaminationID.ToString();
            productNameLabel.Text = _examination.Pet.PetName;
            productPriceLabel.Text = _examination.ExaminationType.ExaminationTypeName;
        }
    }
}
