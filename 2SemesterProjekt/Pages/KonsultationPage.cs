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
			CRUDPanel.Controls.Add(new ButtonPanel("Tilføj medicin", Color.MediumPurple, AddMedicine_Click));
		}

		private async void FindExamination_Click(object sender, EventArgs e)
		{

			try
			{
				// Checks if phonenumber is valid
				if (ValidPhoneNumberTextBox() == true)
				{
					// If valid then retrieve all Examination a customers pet have
					IEnumerable<Examination> allCustomerExamination = await _examinationService.GetAllExaminationOnCustomerPhoneNumber(Convert.ToInt32(textBoxCustomerPhoneNumber.Text));

					// If the customer doens't exist or they dont have any pets throw error which will be caught in Catch
					if (allCustomerExamination.Count() == 0)
					{
						throw new ArgumentException("Kunden er ikke registeret i databasen eller ikke har nogen kæledyr");
					}

					ExaminationFlowPanel.Controls.Clear();

					foreach (var examination in allCustomerExamination)
					{
						ExaminationFlowPanel.Controls.Add(new ExaminationCard(examination));
					}
				}
				else // If ValidPhoneNumberTextBox == False
				{
					// Retrieve all Examinations
					IEnumerable<Examination> allExaminations = await _examinationService.GetAllExaminationsAsync();

					ExaminationFlowPanel.Controls.Clear();

					foreach (var examination in allExaminations)
					{
						ExaminationFlowPanel.Controls.Add(new ExaminationCard(examination));
					}
				}

				textBoxCustomerPhoneNumber.Text = string.Empty;
				textBoxCustomerPhoneNumber.BackColor = Color.White;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private bool ValidPhoneNumberTextBox()
		{
			// If User haven't input any text into TextBox and will therefore return false -> Retrieves all Customers
			if(textBoxCustomerPhoneNumber.Text == String.Empty)
			{
				return false;
			}

			// Validate phonenumber: only numbers and 8-digit long.
			if (!Int32.TryParse(textBoxCustomerPhoneNumber.Text, out int phoneNumber) || textBoxCustomerPhoneNumber.Text[0] == '0' || phoneNumber < 10000000 || phoneNumber > 99999999)
			{
				textBoxCustomerPhoneNumber.ForeColor = Color.White;
				textBoxCustomerPhoneNumber.BackColor = Color.LightCoral;
				throw new ArgumentException("Telefonnummer skal være et helt 8-cifret tal");
			}
			else
			{
				return true;
			}
		}
        private void AddMedicine_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Nothing here yet");
		}

    }
}
