using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace _2SemesterProjekt.Pages.UserControls.NavigationButtons
{
	public partial class NavigationButtonOption : UserControl
	{
		public NavigationButtonOption(EventHandler onClick)
		{
			InitializeComponent();
			AddEventHandler(onClick, this);
		}

		private void AddEventHandler(EventHandler onClick, Control parent)
		{
			parent.Click += onClick;

			foreach (Control child in parent.Controls)
			{
				AddEventHandler(onClick, child);
			}
		}

		public void UpdateColor(Color color)
		{
			this.BackColor = color;
		}
	}
}
