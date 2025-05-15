namespace _2SemesterProjekt
{
	partial class CustomerPage
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
            customerFlowPanel = new FlowLayoutPanel();
            pageNameLabel = new Label();
            buttonFlowPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // customerFlowPanel
            // 
            customerFlowPanel.AutoScroll = true;
            customerFlowPanel.BackColor = SystemColors.ControlLightLight;
            customerFlowPanel.BorderStyle = BorderStyle.FixedSingle;
            customerFlowPanel.Location = new Point(250, 150);
            customerFlowPanel.Name = "customerFlowPanel";
            customerFlowPanel.Size = new Size(709, 580);
            customerFlowPanel.TabIndex = 0;
            // 
            // pageNameLabel
            // 
            pageNameLabel.AutoSize = true;
            pageNameLabel.Font = new Font("Gadugi", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pageNameLabel.Location = new Point(473, 36);
            pageNameLabel.Name = "pageNameLabel";
            pageNameLabel.Size = new Size(253, 77);
            pageNameLabel.TabIndex = 1;
            pageNameLabel.Text = "Kunder";
            // 
            // buttonFlowPanel
            // 
            buttonFlowPanel.Location = new Point(976, 429);
            buttonFlowPanel.Name = "buttonFlowPanel";
            buttonFlowPanel.Size = new Size(209, 301);
            buttonFlowPanel.TabIndex = 3;
            // 
            // CustomerPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(buttonFlowPanel);
            Controls.Add(pageNameLabel);
            Controls.Add(customerFlowPanel);
            Name = "CustomerPage";
            Size = new Size(1200, 825);
            Load += CustomerPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel customerFlowPanel;
		private Label pageNameLabel;
		private FlowLayoutPanel buttonFlowPanel;
	}
}
