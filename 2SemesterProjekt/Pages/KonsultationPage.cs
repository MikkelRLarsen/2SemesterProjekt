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
using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProjekt.Services;
using Microsoft.Extensions.DependencyInjection;
using _2SemesterProjekt.Domain.Models;

namespace _2SemesterProjekt.Pages
{
	public partial class KonsultationPage : UserControl
	{
		private readonly IExaminationService _examinationService;
		public KonsultationPage()
		{
			InitializeComponent();
			_examinationService = ServiceProviderSingleton.GetServiceProvider().GetService<IExaminationService>();
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

		private async void FindExamination_Click(object sender, EventArgs e)
		{

			try
			{
				if (ValidPhoneNumberTextBox() == true)
				{
					IEnumerable<Examination> allCustomerExamination = await _examinationService.GetAllExaminationOnCustomerPhoneNumber(Convert.ToInt32(textBoxCustomerPhoneNumber.Text));

					ExaminationFlowPanel.Controls.Clear();

					foreach (var examination in allCustomerExamination)
					{
						ExaminationFlowPanel.Controls.Add(new ExaminationCard(examination));
					}
				}
				else
				{
					IEnumerable<Examination> allExaminations = await _examinationService.GetAllExaminationsAsync();

					ExaminationFlowPanel.Controls.Clear();

					foreach (var examination in allExaminations)
					{
						ExaminationFlowPanel.Controls.Add(new ExaminationCard(examination));
					}
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private bool ValidPhoneNumberTextBox()
		{
			// Validate phonenumber: only numbers and 8-digit long.
			if (!Int32.TryParse(textBoxCustomerPhoneNumber.Text, out int phoneNumber) || textBoxCustomerPhoneNumber.Text[0] == '0' || phoneNumber < 10000000 || phoneNumber > 99999999)
			{
				textBoxCustomerPhoneNumber.ForeColor = Color.White;
				textBoxCustomerPhoneNumber.BackColor = Color.LightCoral;
				throw new ArgumentException("Telefonnummer skal være et helt 8-cifret tal");
			}

			return true;
		}
	}
}
