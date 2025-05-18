using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2SemesterProjekt.Pages.UserControls.ExaminationUserControl;

namespace _2SemesterProjekt.Pages
{
    public partial class Page : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public Page()
        {
            InitializeComponent();
        }

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

        private void Page_Load(object sender, EventArgs e)
        {
            panel2.Controls.Add(new CreateExaminationUserControlUpdate());
        }
    }
}
