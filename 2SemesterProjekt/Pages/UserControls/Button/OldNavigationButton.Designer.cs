namespace _2SemesterProjekt
{
	partial class OldNavigationButton
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
			buttonNameLabel = new Label();
			SuspendLayout();
			// 
			// buttonNameLabel
			// 
			buttonNameLabel.AutoSize = true;
			buttonNameLabel.BackColor = Color.Transparent;
			buttonNameLabel.Font = new Font("Gadugi", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonNameLabel.ForeColor = SystemColors.ControlLight;
			buttonNameLabel.Location = new Point(56, 18);
			buttonNameLabel.Name = "buttonNameLabel";
			buttonNameLabel.Size = new Size(120, 38);
			buttonNameLabel.TabIndex = 0;
			buttonNameLabel.Text = "Button";
			// 
			// NavigationButton
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(buttonNameLabel);
			Name = "NavigationButton";
			Size = new Size(238, 75);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label buttonNameLabel;
	}
}
