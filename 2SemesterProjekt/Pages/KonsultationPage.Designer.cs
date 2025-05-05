namespace _2SemesterProjekt.Pages
{
	partial class KonsultationPage
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
			ExaminationFlowPanel = new FlowLayoutPanel();
			CRUDPanel = new FlowLayoutPanel();
			textBoxCustomerPhoneNumber = new TextBox();
			SuspendLayout();
			// 
			// pageNameLabel
			// 
			pageNameLabel.AutoSize = true;
			pageNameLabel.Font = new Font("Gadugi", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
			pageNameLabel.Location = new Point(566, 65);
			pageNameLabel.Margin = new Padding(4, 0, 4, 0);
			pageNameLabel.Name = "pageNameLabel";
			pageNameLabel.Size = new Size(625, 115);
			pageNameLabel.TabIndex = 2;
			pageNameLabel.Text = "Konsultation";
			// 
			// ExaminationFlowPanel
			// 
			ExaminationFlowPanel.AutoScroll = true;
			ExaminationFlowPanel.BackColor = SystemColors.ControlLightLight;
			ExaminationFlowPanel.BorderStyle = BorderStyle.FixedSingle;
			ExaminationFlowPanel.Location = new Point(357, 250);
			ExaminationFlowPanel.Margin = new Padding(4, 5, 4, 5);
			ExaminationFlowPanel.Name = "ExaminationFlowPanel";
			ExaminationFlowPanel.Size = new Size(1012, 965);
			ExaminationFlowPanel.TabIndex = 3;
			// 
			// CRUDPanel
			// 
			CRUDPanel.Location = new Point(1399, 715);
			CRUDPanel.Margin = new Padding(4, 5, 4, 5);
			CRUDPanel.Name = "CRUDPanel";
			CRUDPanel.Size = new Size(299, 502);
			CRUDPanel.TabIndex = 4;
			// 
			// textBoxCustomerPhoneNumber
			// 
			textBoxCustomerPhoneNumber.Location = new Point(1399, 673);
			textBoxCustomerPhoneNumber.Name = "textBoxCustomerPhoneNumber";
			textBoxCustomerPhoneNumber.Size = new Size(299, 31);
			textBoxCustomerPhoneNumber.TabIndex = 5;
			// 
			// KonsultationPage
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(textBoxCustomerPhoneNumber);
			Controls.Add(CRUDPanel);
			Controls.Add(ExaminationFlowPanel);
			Controls.Add(pageNameLabel);
			Margin = new Padding(4, 5, 4, 5);
			Name = "KonsultationPage";
			Size = new Size(1714, 1375);
			Load += KonsultationPage_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label pageNameLabel;
		private FlowLayoutPanel ExaminationFlowPanel;
		private FlowLayoutPanel CRUDPanel;
		private TextBox textBoxCustomerPhoneNumber;
	}
}
