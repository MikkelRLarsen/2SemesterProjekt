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
    public partial class NavigationButton: UserControl
    {
		private Panel _panel;
		private UserControl? _page;

        public NavigationButton(string name, Panel panel, UserControl page)
        {
            InitializeComponent();
            buttonNameLabel.Text = name;
			_panel = panel;
			_page = page;
            CenterButtonNameLabel();
			this.MouseEnter += NavigationButton_MouseEnter;
			this.MouseLeave += NavigationButton_MouseLeave;
			this.Cursor = Cursors.Hand;
			buttonNameLabel.Cursor = Cursors.Hand;
			buttonNameLabel.MouseEnter += NavigationButton_MouseEnter;
			buttonNameLabel.MouseLeave += NavigationButton_MouseLeave;

			this.Click += HandleClick;
			buttonNameLabel.Click += HandleClick;
		}

		public NavigationButton(string name)
		{
			InitializeComponent();
			buttonNameLabel.Text = name;
			CenterButtonNameLabel();
			this.MouseEnter += NavigationButton_MouseEnter;
			this.MouseLeave += NavigationButton_MouseLeave;
			buttonNameLabel.MouseEnter += NavigationButton_MouseEnter;
			buttonNameLabel.MouseLeave += NavigationButton_MouseLeave;
			this.Cursor = Cursors.Hand;
			buttonNameLabel.Cursor = Cursors.Hand;

			this.Click += HandleClick;
			buttonNameLabel.Click += HandleClick;
		}

		private void CenterButtonNameLabel()
		{
			int centerX = (this.Width - buttonNameLabel.Width) / 2;
			buttonNameLabel.Location = new Point(centerX, buttonNameLabel.Location.Y);
		}

		private void HandleClick(object sender, EventArgs e)
		{
			if (_page != null)
			{
				_panel.Controls.Clear();
				_panel.Controls.Add(_page);
			}
			else
			{
				Application.Exit();
			}
		}

		private void NavigationButton_MouseEnter(object sender, EventArgs e)
		{
			this.BackColor = Color.RoyalBlue;
		}

		private void NavigationButton_MouseLeave(object sender, EventArgs e)
		{
			this.BackColor = Color.MidnightBlue;
		}
	}
}
