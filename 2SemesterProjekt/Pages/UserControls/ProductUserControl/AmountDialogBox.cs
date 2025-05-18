using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2SemesterProjekt.Pages.UserControls.ProductUserControl
{
    public partial class AmountDialogBox : Form
    {
        public int Amount { get; private set; } = 1;

        public AmountDialogBox(Domain.Models.Product product, int amount)
        {
            InitializeComponent();
            amountUpDown.Value = 1;
            amountUpDown.Maximum = amount;
            amountUpDown.Minimum = 1;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = $"Tilføj mængde af {product.Name}";
        }

        private void addAmountButton_Click(object sender, EventArgs e)
        {
            Amount = (int)amountUpDown.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
