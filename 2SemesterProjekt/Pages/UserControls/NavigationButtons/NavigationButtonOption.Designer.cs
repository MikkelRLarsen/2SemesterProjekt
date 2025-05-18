namespace _2SemesterProjekt.Pages.UserControls.NavigationButtons
{
	partial class NavigationButtonOption
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
			ButtonLabel = new Label();
			SuspendLayout();
			// 
			// ButtonLabel
			// 
			ButtonLabel.Anchor = AnchorStyles.Right;
			ButtonLabel.AutoSize = true;
			ButtonLabel.Font = new Font("Segoe UI", 22F);
			ButtonLabel.ForeColor = SystemColors.HighlightText;
			ButtonLabel.Location = new Point(72, 11);
			ButtonLabel.Name = "ButtonLabel";
			ButtonLabel.Size = new Size(228, 50);
			ButtonLabel.TabIndex = 1;
			ButtonLabel.Text = "Konsultation";
			ButtonLabel.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// NavigationButtonOption
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DodgerBlue;
			Controls.Add(ButtonLabel);
			Name = "NavigationButtonOption";
			Size = new Size(300, 70);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		public Label ButtonLabel;
	}
}
