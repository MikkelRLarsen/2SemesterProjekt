using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2SemesterProjekt.Pages.UserControls.NavigationButtons
{
	public partial class NavigationButton : UserControl
	{
		private LinkedList<NavigationButtonOption> _navOptions = new LinkedList<NavigationButtonOption>();
		private int minHeight = 35;
		private int maxHeight = 35;
		public NavigationButton()
		{
			InitializeComponent();
			RegisterHoverEvents(this);

			collapseTimer.Tick += collapseTimer_Tick;
			expandTimer.Tick += expandTimer_Tick;
		}


		// Sets all Event Handlers foreach Control
		private void RegisterHoverEvents(Control parent)
		{
			parent.MouseEnter += MouseEnter;
			parent.MouseLeave += MouseLeave;

			foreach (Control child in parent.Controls)
			{
				RegisterHoverEvents(child);
			}
		}

		// Timers
		private void collapseTimer_Tick(object sender, EventArgs e)
		{
			this.Height -= 5;
			if (this.Height <= minHeight)
			{
				collapseTimer.Stop();
				this.Height = minHeight;
			}
		}

		private void expandTimer_Tick(object sender, EventArgs e)
		{
			this.Height += 5;
			if (this.Height >= maxHeight)
			{
				expandTimer.Stop();
				this.Height = maxHeight;
			}
		}


		// MouseEnter / MouseLeave Events;
		private void MouseEnter(object sender, EventArgs e)
		{
			collapseTimer.Stop();

			UpdateColor(Color.MidnightBlue);

			expandTimer.Start();
		}

		private void MouseLeave(object sender, EventArgs e)
		{
			expandTimer.Stop();

			UpdateColor(Color.DodgerBlue);

			collapseTimer.Start();
		}

		// Set Color
		private void UpdateColor(Color color)
		{
			this.BackColor = color;

			foreach (NavigationButtonOption options in _navOptions)
			{
				options.UpdateColor(color);
			}
		}

		// Add Option to NavMenu
		public void AddOption(NavigationButtonOption option)
		{
			// Sets Layout for option
			option.Size = new Size(this.Width, 35);
			option.Location = new Point(0, (_navOptions.Count * 35) + 40);

			// Adds option to _navOptions, so its easier to add more options in the future
			_navOptions.AddLast(option);
			maxHeight = (_navOptions.Count * 35) + 40; // Is Base Height + 5 for Black Underline

			// Needed to show the option
			this.Controls.Add(option);
			option.BringToFront();

			// Adds the HoverEvents to option
			RegisterHoverEvents(option);
		}

		private void ButtonLabel_Resize(object sender, EventArgs e)
		{
			// WHen changing the text in ButtonLabel, then its Resized and this centeres the Text to the middle on the User Control
			ButtonLabel.Left = (this.ClientSize.Width - ButtonLabel.Width) / 2;
			ButtonLabel.Top = (this.ClientSize.Height - ButtonLabel.Height) / 2;
		}
	}
}
