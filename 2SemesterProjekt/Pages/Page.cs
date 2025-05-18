using _2SemesterProjekt.Pages.UserControls.NavigationButtons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2SemesterProjekt.Pages
{
	public partial class Page : Form
	{
		private bool mouseDown;
		private Point lastLocation;


		public Page()
		{
			InitializeComponent();

			KonsultationNav.AddOption(new NavigationButtonOption(OpenPageClick));
			KonsultationNav.AddOption(new NavigationButtonOption(OpenPageClick));
			KonsultationNav.ButtonLabel.Text = "Examination";
			KonsultationNav.BringToFront();
		}

		//KonsultationMenu

		private async void OpenPageClick(object sender, EventArgs e)
		{
			MainPanel.Controls.Clear();
			MainPanel.Controls.Add(new KonsultationPage());
		}

		//MedicinMenu

		//SalgMenu

		//KundeMenu

		//AdministrationMenu


		// MoveHandler
		private void Page_MouseDown(object sender, MouseEventArgs e)
		{
			mouseDown = true;
			lastLocation = e.Location;

		}

		private void Page_MouseMove(object sender, MouseEventArgs e)
		{
			if (mouseDown)
			{
				this.Location = new Point(
					(this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

				this.Update();
			}

		}

		private void Page_MouseUp(object sender, MouseEventArgs e)
		{
			mouseDown = false;
		}
	}
}
