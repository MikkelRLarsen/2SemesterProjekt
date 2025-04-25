using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2SemesterProjekt.Pages.UserControls.ExaminationUserControl;

namespace _2SemesterProjekt.Pages
{
	public partial class KonsultationPage : UserControl
	{
		public KonsultationPage()
		{
			InitializeComponent();
			CRUDPanel.Controls.Add(new ButtonPanel("Find kunde", "FindCustomer.png", Color.SteelBlue));
			CRUDPanel.Controls.Add(new ButtonPanel("Tilføj kunde", "AddCustomer.png", Color.MediumSeaGreen,CreateExamination_Click));
			CRUDPanel.Controls.Add(new ButtonPanel("Redigér kunde", "EditCustomer.png", Color.Goldenrod));
			CRUDPanel.Controls.Add(new ButtonPanel("Fjern kunde", "RemoveCustomer.png", Color.IndianRed));


		}

		private void CreateExamination_Click(object sender, EventArgs e)
		{
			ExaminationFlowPanel.Controls.Clear();
			ExaminationFlowPanel.Controls.Add(new CreateExaminationUserControl());
		}
	}
}
