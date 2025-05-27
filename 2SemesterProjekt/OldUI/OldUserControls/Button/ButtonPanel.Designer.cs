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
            buttonNameLabel.Location = new Point(80, 23);
            buttonNameLabel.Margin = new Padding(4, 0, 4, 0);
            buttonNameLabel.Name = "buttonNameLabel";
            buttonNameLabel.Size = new Size(162, 35);
            buttonNameLabel.TabIndex = 1;
            buttonNameLabel.Text = "Knap navn";
            // 
            // pictureBox
            // 
            pictureBox.Image = Properties.Resources.member;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Margin = new Padding(4, 5, 4, 5);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(71, 83);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 4;
            pictureBox.TabStop = false;
            // 
            // ButtonPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonNameLabel);
            Controls.Add(pictureBox);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ButtonPanel";
            Size = new Size(286, 83);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label buttonNameLabel;
		private PictureBox pictureBox;
	}
}
