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
		}

		private void CreateExamination_Click(object sender, EventArgs e)
		{
			ExaminationFlowPanel.Controls.Clear();
			ExaminationFlowPanel.Controls.Add(new CreateExaminationUserControl(ExaminationFlowPanel));
		}

		private void KonsultationPage_Load(object sender, EventArgs e)
		{
			CRUDPanel.Controls.Add(new ButtonPanel("Find", Color.MediumAquamarine, FindExamination_Click));
			CRUDPanel.Controls.Add(new ButtonPanel("Opret", Color.MediumSeaGreen, CreateExamination_Click));
		}

		private void FindExamination_Click(object sender, EventArgs e)
		{

		}
	}
}
