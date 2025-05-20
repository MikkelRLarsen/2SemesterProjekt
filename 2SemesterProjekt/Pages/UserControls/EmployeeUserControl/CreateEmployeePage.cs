using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProjekt.Domain.Models;
using _2SemesterProjekt.Pages.UserControls.MainPageWallpaperControl;
using _2SemesterProjekt.Properties;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2SemesterProjekt.Pages.UserControls.EmployeeUserControl
{
	public partial class CreateEmployeePage : UserControl
	{
		private readonly Panel _mainPagePanel;
		private IEmployeeService _employeeService;
		public CreateEmployeePage(Panel mainPagePanel)
		{
			InitializeComponent();
			_mainPagePanel = mainPagePanel;
		}

		private void comboBoxType_SelectionChangeCommitted(object sender, EventArgs e)
		{
			submitButton.Enabled = true;
			submitButton.Image = Resources.CreateButton;
		}

		private async void submitButton_Click(object sender, EventArgs e)
		{
			try
			{
				Employee newEmployee = new Employee(textBoxFirstName.Text, textBoxLastName.Text, comboBoxType.SelectedItem.ToString());

				await _employeeService.CreateEmployeeAsync(newEmployee);

				MessageBox.Show("Oprettelse fuldført");
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			_mainPagePanel.Controls.Remove(this);
			_mainPagePanel.Controls.Add(new MainPageWallpaper());
		}

		private async void CreateEmployeePage_Load(object sender, EventArgs e)
		{
			_employeeService = ServiceProviderSingleton.GetServiceProvider().GetService<IEmployeeService>()!;
			comboBoxType.DataSource = await _employeeService.GetAllEmployeeTypesAsync();
		}
	}
}
