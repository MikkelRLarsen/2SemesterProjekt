using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2SemesterProjekt.Properties;

namespace _2SemesterProjekt
{
    public partial class ButtonPanel: UserControl
    {
		private readonly Color _buttonColor;

		public ButtonPanel(string labelName, string pictureName, Color color, EventHandler? onClick = null)
        {
			InitializeComponent();
			var resourceManager = Properties.Resources.ResourceManager;
			var image = (Image)resourceManager.GetObject(Path.GetFileNameWithoutExtension(pictureName));
            pictureBox.Image = image;
            buttonNameLabel.Text = labelName;
			_buttonColor = color;
            this.BackColor = color;

			if (onClick != null) 
			{
				this.Click += onClick;
				foreach (Control control in this.Controls)
				{
					control.Click += onClick;
				}
			}

			InitializeMouseOnHover();
			CenterButtonNameLabel();
		}

		private void CenterButtonNameLabel()
		{
			int centerX = ((this.Width + 50) - buttonNameLabel.Width) / 2;
			buttonNameLabel.Location = new Point(centerX, buttonNameLabel.Location.Y);
		}
		
		private void InitializeMouseOnHover()
		{
			this.MouseEnter += ButtonPanel_MouseEnter;
			this.MouseLeave += ButtonPanel_MouseLeave;
			buttonNameLabel.MouseEnter += ButtonPanel_MouseEnter;
			buttonNameLabel.MouseLeave += ButtonPanel_MouseLeave;
			pictureBox.MouseEnter += ButtonPanel_MouseEnter;
			pictureBox.MouseLeave += ButtonPanel_MouseLeave;
			this.Cursor = Cursors.Hand;
			buttonNameLabel.Cursor = Cursors.Hand;
			pictureBox.Cursor = Cursors.Hand;
		}

		private void ButtonPanel_MouseEnter(object sender, EventArgs e)
		{
			this.BackColor = Color.DeepSkyBlue;
		}

		private void ButtonPanel_MouseLeave(object sender, EventArgs e)
		{
			this.BackColor = _buttonColor;
		}
	}
}
