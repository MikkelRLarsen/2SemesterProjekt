using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _2SemesterProjekt
{
    // Navigation button including hover effects and click-based page navigation
    public partial class NavigationButton : UserControl
    {
		private Panel? _targetPanel; // The panel where the user control (_targetPage) will be loaded
        private UserControl? _targetPage; // The user control (page) to navigate to

        public NavigationButton(string buttonName, Panel targetPanel, UserControl targetPage)
        {
            InitializeComponent();
            buttonNameLabel.Text = buttonName;
			_targetPanel = targetPanel;
			_targetPage = targetPage;
			CenterButtonNameLabel();

            // Hover effects to this control and the label
            this.MouseEnter += NavigationButton_MouseEnter;
			this.MouseLeave += NavigationButton_MouseLeave;
            this.Cursor = Cursors.Hand;
			buttonNameLabel.MouseEnter += NavigationButton_MouseEnter;
			buttonNameLabel.MouseLeave += NavigationButton_MouseLeave;
            buttonNameLabel.Cursor = Cursors.Hand;

            // Click event handler to this control and the label
            this.Click += HandleClick;
			buttonNameLabel.Click += HandleClick;
		}

        // Overloaded constructor for use without navigation (Exit button)
        public NavigationButton(string buttonName)
		{
			InitializeComponent();
			buttonNameLabel.Text = buttonName;
			CenterButtonNameLabel();

            // Hover effects to this control and the label
            this.MouseEnter += NavigationButton_MouseEnter;
            this.MouseLeave += NavigationButton_MouseLeave;
            this.Cursor = Cursors.Hand;
            buttonNameLabel.MouseEnter += NavigationButton_MouseEnter;
			buttonNameLabel.MouseLeave += NavigationButton_MouseLeave;
            buttonNameLabel.Cursor = Cursors.Hand;

            // Click event handler to this control and the label
            this.Click += HandleClick;
			buttonNameLabel.Click += HandleClick;
		}

		/// <summary>
		/// Centers the textLabel horizontally within the button
		/// </summary>
		private void CenterButtonNameLabel()
		{
			int centerX = (this.Width - buttonNameLabel.Width) / 2;
			buttonNameLabel.Location = new Point(centerX, buttonNameLabel.Location.Y);
		}

		/// <summary>
		/// Handles what happens when the button is clicked
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void HandleClick(object? sender, EventArgs e)
		{
			if (_targetPage != null)
			{
				_targetPanel.Controls.Clear(); // Clear existing content
                _targetPanel.Controls.Add(_targetPage); // Load the new page
            }
			else
			{
				Application.Exit(); // If no page is set, exit the application
            }
		}

        // Background color change on hover
        private void NavigationButton_MouseEnter(object? sender, EventArgs e)
		{
			this.BackColor = Color.RoyalBlue;
		}

        // Revert background color on leave
        private void NavigationButton_MouseLeave(object? sender, EventArgs e)
		{
			this.BackColor = Color.MidnightBlue;
		}
	}
}
