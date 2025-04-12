namespace _2SemesterProjekt.Pages
{
	partial class ProductPage
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
			pageNameLabel = new Label();
			flowLayoutPanel1 = new FlowLayoutPanel();
			SuspendLayout();
			// 
			// pageNameLabel
			// 
			pageNameLabel.AutoSize = true;
			pageNameLabel.Font = new Font("Gadugi", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
			pageNameLabel.Location = new Point(432, 36);
			pageNameLabel.Name = "pageNameLabel";
			pageNameLabel.Size = new Size(336, 77);
			pageNameLabel.TabIndex = 2;
			pageNameLabel.Text = "Produkter";
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.BackColor = SystemColors.ControlLightLight;
			flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
			flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
			flowLayoutPanel1.Location = new Point(250, 150);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(709, 580);
			flowLayoutPanel1.TabIndex = 3;
			// 
			// ProductPage
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(flowLayoutPanel1);
			Controls.Add(pageNameLabel);
			Name = "ProductPage";
			Size = new Size(1200, 825);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label pageNameLabel;
		private FlowLayoutPanel flowLayoutPanel1;
	}
}
