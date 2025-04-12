namespace _2SemesterProjekt.Pages
{
	partial class OrderPage
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
			CustomerflowPanel = new FlowLayoutPanel();
			SuspendLayout();
			// 
			// pageNameLabel
			// 
			pageNameLabel.AutoSize = true;
			pageNameLabel.Font = new Font("Gadugi", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
			pageNameLabel.Location = new Point(473, 36);
			pageNameLabel.Name = "pageNameLabel";
			pageNameLabel.Size = new Size(232, 77);
			pageNameLabel.TabIndex = 2;
			pageNameLabel.Text = "Ordrer";
			// 
			// CustomerflowPanel
			// 
			CustomerflowPanel.BackColor = SystemColors.ControlLightLight;
			CustomerflowPanel.BorderStyle = BorderStyle.FixedSingle;
			CustomerflowPanel.FlowDirection = FlowDirection.TopDown;
			CustomerflowPanel.Location = new Point(250, 150);
			CustomerflowPanel.Name = "CustomerflowPanel";
			CustomerflowPanel.Size = new Size(709, 580);
			CustomerflowPanel.TabIndex = 3;
			// 
			// OrderPage
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(CustomerflowPanel);
			Controls.Add(pageNameLabel);
			Name = "OrderPage";
			Size = new Size(1200, 825);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label pageNameLabel;
		private FlowLayoutPanel CustomerflowPanel;
	}
}
