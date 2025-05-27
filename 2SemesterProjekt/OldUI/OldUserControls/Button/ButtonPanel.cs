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
    // Custom button including hover effects and click-based events
    public partial class ButtonPanel : UserControl
    {
		private readonly Color _buttonColor; // Stores base color of button for reverting
		private readonly Image? _buttonImage; // Stores the image of button if initailized
		public Label ButtonText { 
			get { return this.buttonNameLabel; } // Stores the label of the button to handle removal
            set { this.buttonNameLabel = value; }
		} 

        // Constructor for ButtonPanel with image
        public ButtonPanel(string buttonName, string imageResourceName, Color color, EventHandler? onClick = null)
        {
			InitializeComponent();

			// Loads image from embedded resources
			var resourceManager = Properties.Resources.ResourceManager;
            _buttonImage = resourceManager.GetObject(Path.GetFileNameWithoutExtension(imageResourceName)) as Image;

			if (_buttonImage != null)
			{
				pictureBox.Image = _buttonImage;
			}
			else
			{
				pictureBox.Image = null; // Clear if not found
			}

			// Sets label and background color of the button
			buttonNameLabel.Text = buttonName;
			_buttonColor = color;
            this.BackColor = color;

			// Connects click event to this panel and all child components
			if (onClick != null) 
			{
				this.Click += onClick;
				foreach (Control control in this.Controls)
				{
					control.Click += onClick;
				}
			}

			InitializeMouseOnHover(); // Hover effects to button
            CenterLabel(); // Center nameLabel
		}

        // Constructor for ButtonPanel without an image
        public ButtonPanel(string buttonName, Color color, EventHandler? onClick = null)
        {
            InitializeComponent();

            // Sets label and background color of the button
            buttonNameLabel.Text = buttonName;
            _buttonColor = color;
            this.BackColor = color;
			pictureBox.Image = null;

            // Connects click event to this panel and all child components
            if (onClick != null)
            {
                this.Click += onClick;
                foreach (Control control in this.Controls)
                {
                    control.Click += onClick;
                }
            }

            InitializeMouseOnHover(); // Hover effects to button
            CenterLabel(); // Center nameLabel
        }

        public void CenterLabel()
		{
			int centerX;

			if (pictureBox.Image != null)
			{
				centerX = ((this.Width + pictureBox.Width) - buttonNameLabel.Width) / 2; // Center based on both control width and image width

            }
			else
			{
				centerX = (this.Width - buttonNameLabel.Width) / 2; // Fallback centering without image
            }

            buttonNameLabel.Location = new Point(centerX, buttonNameLabel.Location.Y);
        }

        /// <summary>
        /// Hover effects to this control and all child components
        /// </summary>
        private void InitializeMouseOnHover()
		{
            this.MouseEnter += ButtonPanel_MouseEnter;
            this.MouseLeave += ButtonPanel_MouseLeave;
            this.Cursor = Cursors.Hand;

            foreach (Control control in this.Controls)
			{
                control.MouseEnter += ButtonPanel_MouseEnter;
				control.MouseLeave += ButtonPanel_MouseLeave;
				control.Cursor = Cursors.Hand;
			}
		}

        // Background color change on hover
        private void ButtonPanel_MouseEnter(object? sender, EventArgs e)
		{
			this.BackColor = Color.DeepSkyBlue;
		}

        // Revert background color on leave
        private void ButtonPanel_MouseLeave(object? sender, EventArgs e)
		{
			this.BackColor = _buttonColor;
		}
	}
}
