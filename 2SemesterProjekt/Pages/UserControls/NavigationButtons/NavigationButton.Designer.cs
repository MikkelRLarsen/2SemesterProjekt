namespace _2SemesterProjekt.Pages.UserControls.NavigationButtons
{
	partial class NavigationButton
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			ButtonLabel = new Label();
			panel1 = new Panel();
			collapseTimer = new System.Windows.Forms.Timer(components);
			expandTimer = new System.Windows.Forms.Timer(components);
			SuspendLayout();
			// 
			// ButtonLabel
			// 
			ButtonLabel.Anchor = AnchorStyles.Top;
			ButtonLabel.AutoSize = true;
			ButtonLabel.Font = new Font("Segoe UI", 12F);
			ButtonLabel.ForeColor = SystemColors.HighlightText;
			ButtonLabel.Location = new Point(34, 4);
			ButtonLabel.Name = "ButtonLabel";
			ButtonLabel.Size = new Size(123, 28);
			ButtonLabel.TabIndex = 0;
			ButtonLabel.Text = "Konsultation";
			ButtonLabel.TextAlign = ContentAlignment.MiddleCenter;
			ButtonLabel.Resize += ButtonLabel_Resize;
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.Desktop;
			panel1.ForeColor = Color.Black;
			panel1.Location = new Point(11, 47);
			panel1.Name = "panel1";
			panel1.Size = new Size(206, 7);
			panel1.TabIndex = 1;
			// 
			// collapseTimer
			// 
			collapseTimer.Interval = 5;
			// 
			// expandTimer
			// 
			expandTimer.Interval = 5;
			// 
			// NavigationButton
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DodgerBlue;
			Controls.Add(panel1);
			Controls.Add(ButtonLabel);
			Margin = new Padding(0);
			Name = "NavigationButton";
			Size = new Size(200, 35);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Panel panel1;
		private System.Windows.Forms.Timer collapseTimer;
		private System.Windows.Forms.Timer expandTimer;
		public Label ButtonLabel;
	}
}
