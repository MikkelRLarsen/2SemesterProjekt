namespace _2SemesterProjekt
{
	partial class ButtonPanel
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
			pictureBox = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
			SuspendLayout();
			// 
			// buttonNameLabel
			// 
			buttonNameLabel.AutoSize = true;
			buttonNameLabel.Font = new Font("Gadugi", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonNameLabel.ForeColor = SystemColors.ButtonHighlight;
			buttonNameLabel.Location = new Point(56, 14);
			buttonNameLabel.Name = "buttonNameLabel";
			buttonNameLabel.Size = new Size(105, 21);
			buttonNameLabel.TabIndex = 1;
			buttonNameLabel.Text = "Knap navn";
			// 
			// pictureBox
			// 
			pictureBox.Image = Properties.Resources.member;
			pictureBox.Location = new Point(0, 0);
			pictureBox.Name = "pictureBox";
			pictureBox.Size = new Size(50, 50);
			pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox.TabIndex = 4;
			pictureBox.TabStop = false;
			// 
			// ButtonPanel
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(pictureBox);
			Controls.Add(buttonNameLabel);
			Name = "ButtonPanel";
			Size = new Size(200, 50);
			((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label buttonNameLabel;
		private PictureBox pictureBox;
	}
}
