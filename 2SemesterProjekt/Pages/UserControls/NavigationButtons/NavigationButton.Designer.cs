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
			ButtonLabel = new Label();
			SuspendLayout();
			// 
			// ButtonLabel
			// 
			ButtonLabel.Anchor = AnchorStyles.None;
			ButtonLabel.AutoSize = true;
			ButtonLabel.Font = new Font("Segoe UI", 22F);
			ButtonLabel.ForeColor = SystemColors.HighlightText;
			ButtonLabel.Location = new Point(38, 11);
			ButtonLabel.Name = "ButtonLabel";
			ButtonLabel.Size = new Size(228, 50);
			ButtonLabel.TabIndex = 0;
			ButtonLabel.Text = "Konsultation";
			ButtonLabel.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// NavigationButton
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Highlight;
			Controls.Add(ButtonLabel);
			Name = "NavigationButton";
			Size = new Size(300, 70);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label ButtonLabel;
	}
}
