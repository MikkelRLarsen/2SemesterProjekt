using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2SemesterProjekt
{
	public partial class CustomerPage : UserControl
	{
		public CustomerPage()
		{
			InitializeComponent();
			buttonFlowPanel.Controls.Add(new ButtonPanel("Find kunde", "FindCustomer.png", Color.SteelBlue));
			buttonFlowPanel.Controls.Add(new ButtonPanel("Tilføj kunde", "AddCustomer.png", Color.MediumSeaGreen));
			buttonFlowPanel.Controls.Add(new ButtonPanel("Redigér kunde", "EditCustomer.png", Color.Goldenrod));
			buttonFlowPanel.Controls.Add(new ButtonPanel("Fjern kunde", "RemoveCustomer.png", Color.IndianRed));
		}
	}
}
