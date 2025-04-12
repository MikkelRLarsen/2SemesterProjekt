namespace _2SemesterProjektWinForms
{
    partial class FrontPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			panel1 = new Panel();
			navigationFlowPanel = new FlowLayoutPanel();
			mainPanel = new Panel();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.MidnightBlue;
			panel1.Controls.Add(navigationFlowPanel);
			panel1.Dock = DockStyle.Left;
			panel1.Location = new Point(0, 0);
			panel1.Margin = new Padding(0);
			panel1.Name = "panel1";
			panel1.Size = new Size(250, 825);
			panel1.TabIndex = 0;
			// 
			// navigationFlowPanel
			// 
			navigationFlowPanel.Location = new Point(3, 160);
			navigationFlowPanel.Name = "navigationFlowPanel";
			navigationFlowPanel.Size = new Size(244, 662);
			navigationFlowPanel.TabIndex = 0;
			// 
			// mainPanel
			// 
			mainPanel.BackColor = Color.WhiteSmoke;
			mainPanel.Dock = DockStyle.Fill;
			mainPanel.Location = new Point(250, 0);
			mainPanel.Margin = new Padding(0);
			mainPanel.Name = "mainPanel";
			mainPanel.Size = new Size(1200, 825);
			mainPanel.TabIndex = 1;
			// 
			// FrontPage
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1450, 825);
			Controls.Add(mainPanel);
			Controls.Add(panel1);
			Name = "FrontPage";
			Text = "Form1";
			panel1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Panel mainPanel;
		private FlowLayoutPanel navigationFlowPanel;
	}
}
