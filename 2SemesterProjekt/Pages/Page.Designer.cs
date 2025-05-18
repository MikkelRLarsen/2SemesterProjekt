namespace _2SemesterProjekt.Pages
{
    partial class Page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			panel1 = new Panel();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.Highlight;
			panel1.Location = new Point(0, 0);
			panel1.Margin = new Padding(2);
			panel1.Name = "panel1";
			panel1.Size = new Size(2500, 70);
			panel1.TabIndex = 0;
			// 
			// Page
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(2500, 1650);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Page";
			Text = "Page";
			MouseDown += Page_MouseDown;
			MouseMove += Page_MouseMove;
			MouseUp += Page_MouseUp;
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
	}
}